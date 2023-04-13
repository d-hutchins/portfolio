
/* Example of Ownership Chaining
Source: www.sommarskog.se/grantperm.html#examplechaining
*/ 

SELECT SUSER_SNAME()[LOGIN], USER_NAME()[DATABASE USER]

-- To check the owner of objects
SELECT
  OBJECT_ID, SCHEMA_NAME(schema_id)[Schema], [name],
  COALESCE(USER_NAME(principal_id),'--No Owner--') [Owner]  
FROM sys.objects

-------------------------
-- THE LAB BEGINS HERE --
-------------------------

USE master
GO

-- Create a test user and a test database. 
CREATE LOGIN TestUser01 WITH PASSWORD = 'CISOwnerChainTest01'
CREATE DATABASE OwnershipChainTest01
GO

-- Move to the test database.
USE OwnershipChainTest01
GO

-- Create a user to run the tests.
CREATE USER TestUser01
GO

-- Create two database-only users that will own some objects.
CREATE USER ProcOwner01 WITHOUT LOGIN
CREATE USER TableOwner01 WITHOUT LOGIN
GO

-- Create three test tables. As this is an example to demonstrate
-- permissions, we don't care about adding any data to them.
CREATE TABLE tbl1 (a int NOT NULL)
CREATE TABLE tbl2 (b int NOT NULL)
CREATE TABLE tbl3 (c int NOT NULL)
GO

-- Make the user TableOwner01 owner of tbl3.
ALTER AUTHORIZATION ON tbl3 TO TableOwner01
GO

-- Create stored procedures.
CREATE PROCEDURE sp1 AS
   SELECT a FROM tbl1
GO

CREATE PROCEDURE sp2inner AS
   SELECT a FROM tbl1
GO

CREATE PROCEDURE sp2 AS
   SELECT b FROM tbl2
   EXEC sp2inner
GO

CREATE PROCEDURE sp2ProcOwner AS
   SELECT b FROM tbl2
   EXEC sp2inner
GO

CREATE PROCEDURE sp3 AS
   SELECT c FROM tbl3
GO

-- Make ProcOwner01 the owner of sp2ProcOwner.
ALTER AUTHORIZATION ON sp2ProcOwner TO ProcOwner01
GO

-- Grant permissions to TestUser01 to execute all procedures,
-- except for sp2inner.
GRANT EXECUTE ON sp1 TO TestUser01
GRANT EXECUTE ON sp2 TO TestUser01
GRANT EXECUTE ON sp2ProcOwner TO TestUser01
GRANT EXECUTE ON sp3 TO TestUser01
GO

-- Run some commands as TestUser01, with its permissions etc.
EXECUTE AS LOGIN = 'TestUser01'
GO

-- Check out the execution context. 
select SUSER_SNAME()[LOGIN], USER_NAME()[DATABASE USER]

-- Task #1: -- Screen shot required.
-- Explain the result and explain why.  
-- Note: dbo owns both sp1 and tbl1.
PRINT 'EXEC sp1, this runs fine'
EXEC sp1
GO

-- Task #2: -- Screen shot required. 
-- Explain the result and explain why.  
PRINT 'EXEC sp2, this runs fine, despite no priv on sp2inner'
EXEC sp2
GO

-- Task #3: -- Screen shot required. 
-- Explain the results and explain why.
PRINT 'EXEC sp2ProcOwner, two permission errors'
EXEC sp2ProcOwner
GO

-- Task #4: -- Screen shot required. 
-- Explain the result and explain why.  
PRINT 'EXEC sp3, permission error'
EXEC sp3
GO

-- Check out the execution context. 
select SUSER_SNAME()[LOGIN], USER_NAME()[DATABASE USER]

-- Task #5: -- Screen shot required. 
-- Change the execution context to sysadmin and perform Task #4.
-- How is the result different from the one from Task #4? Explain why?  
-- Stop being the tester and become sysadmin.
REVERT
GO

-- Perform clean-up. 
USE master
GO

DROP LOGIN TestUser01
DROP DATABASE OwnershipChainTest01
