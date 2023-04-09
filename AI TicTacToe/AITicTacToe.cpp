/* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
~ CECS Final
~ David Spencer & Daniel Hutchins
~ 4/19/19
~ 
~ Two random AI's play each other.
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

#include <iostream>
#include <stdlib.h>
#include <stdio.h>
#import <windows.h>
#include <ctime>

using namespace std;

static int XScoreGlobal = 0;
static int OScoreGlobal = 0;
static int gameNumber = 0;
int endCondition = 1;

class TTTBuilder
{
	
public:
	int position;
	char value;
	
	char getValue();
	void setValue(char);
	
	TTTBuilder(int);
	TTTBuilder();
};

TTTBuilder::TTTBuilder(int a)
{
	position = a;
	value = ' ';
}

TTTBuilder::TTTBuilder()
{
	position = 0;
	value = ' ';
}

char TTTBuilder::getValue()
{
	return value;
}

void TTTBuilder::setValue(char a)
{
	value = a;
}

class TTTBoard : public TTTBuilder
{

public:
	char dimension;
	int level;
	TTTBuilder spot1, spot2, spot3, spot4, spot5, spot6, spot7, spot8, spot9;
	
	char getDimension();
	char getLevel();
	
	TTTBoard(TTTBuilder, TTTBuilder, TTTBuilder,
			 TTTBuilder, TTTBuilder, TTTBuilder,
			 TTTBuilder, TTTBuilder, TTTBuilder,
			 char, int);
	
	TTTBoard();
};

TTTBoard::TTTBoard(TTTBuilder spotA, TTTBuilder spotB, TTTBuilder spotC,
		 		   TTTBuilder spotD, TTTBuilder spotE, TTTBuilder spotF,
		 		   TTTBuilder spotG, TTTBuilder spotH, TTTBuilder spotI,
		 		   char dimensionInput, int levelInput)
{
	spot1 = spotA;
	spot2 = spotB;
	spot3 = spotC;
	spot4 = spotD;
	spot5 = spotE;
	spot6 = spotF;
	spot7 = spotG;
	spot8 = spotH;
	spot9 = spotI;
	
	dimension = dimensionInput;
	level = levelInput;
}

TTTBoard::TTTBoard()
{
}

void printBoard(TTTBoard board);
int checkWinEventTotal(TTTBoard board1, TTTBoard board2, TTTBoard board3);
int checkAxis(TTTBoard board, char check);
int checkDiagonal(TTTBoard board, char check);

void printBoard(TTTBoard board)
{
	char charA, charB, charC;
	char charD, charE, charF;
	char charG, charH, charI;
	
	charA = board.spot1.value; charB = board.spot2.value; charC = board.spot3.value; 
	charD = board.spot4.value; charE = board.spot5.value; charF = board.spot6.value;
	charG = board.spot7.value; charH = board.spot8.value; charI = board.spot9.value;
	
	cout << endl;
	cout << charA << "|" << charB << "|" << charC << endl;
	cout << "-+-+-" << endl;
	cout << charD << "|" << charE << "|" << charF << endl;
	cout << "-+-+-" << endl;
	cout << charG << "|" << charH << "|" << charI << endl;
	cout << endl;
}

int checkWinEventTotal(TTTBoard board1, TTTBoard board2, TTTBoard board3)
{
	int XScore = 0; int OScore = 0;
	TTTBoard BoardX1 = board1;
	TTTBoard BoardX2 = board2;
	TTTBoard BoardX3 = board3;
	TTTBoard BoardY1(board1.spot1, board1.spot4, board1.spot7,
					 board2.spot1, board2.spot4, board2.spot7,
					 board3.spot1, board3.spot4, board3.spot7, 'Y', 1);

	TTTBoard BoardY2(board1.spot2, board1.spot5, board1.spot8,
					 board2.spot2, board2.spot5, board2.spot8,
					 board3.spot2, board3.spot5, board3.spot8, 'Y', 2);	
										
	TTTBoard BoardY3(board1.spot3, board1.spot6, board1.spot9,
					 board2.spot3, board2.spot6, board2.spot9,
					 board3.spot3, board3.spot6, board3.spot9, 'Y', 3);	
										
	TTTBoard BoardZ1(board1.spot7, board1.spot8, board1.spot9,
					 board2.spot7, board2.spot8, board2.spot9,
					 board3.spot7, board3.spot8, board3.spot9, 'Z', 1);
										
	TTTBoard BoardZ2(board1.spot4, board1.spot5, board1.spot6,
			   	     board2.spot4, board2.spot5, board2.spot6,
				     board3.spot4, board3.spot5, board3.spot6, 'Z', 2);
										
	TTTBoard BoardZ3(board1.spot1, board1.spot2, board1.spot3,
					 board2.spot1, board2.spot2, board2.spot3,
					 board3.spot1, board3.spot2, board3.spot3, 'Z', 3);
				
				

							
	XScore = ((checkAxis(BoardX1, 'X') + checkAxis(BoardX2, 'X') + checkAxis(BoardX3, 'X') +
			   checkAxis(BoardY1, 'X') + checkAxis(BoardY2, 'X') + checkAxis(BoardY3, 'X') +
	  		   checkAxis(BoardZ1, 'X') + checkAxis(BoardZ2, 'X') + checkAxis(BoardZ3, 'X')) / 2);			  	  

	XScore += (checkDiagonal(BoardX1, 'X') + checkDiagonal(BoardX2, 'X') + checkDiagonal(BoardX3, 'X') +
			   checkDiagonal(BoardY1, 'X') + checkDiagonal(BoardY2, 'X') + checkDiagonal(BoardY3, 'X') +
			   checkDiagonal(BoardZ1, 'X') + checkDiagonal(BoardZ2, 'X') + checkDiagonal(BoardZ3, 'X'));
			  	  
	OScore = ((checkAxis(BoardX1, 'O') + checkAxis(BoardX2, 'O') + checkAxis(BoardX3, 'O') +
			   checkAxis(BoardY1, 'O') + checkAxis(BoardY2, 'O') + checkAxis(BoardY3, 'O') +
			   checkAxis(BoardZ1, 'O') + checkAxis(BoardZ1, 'O') + checkAxis(BoardZ3, 'O')) / 2);		  	  

	OScore += (checkDiagonal(BoardX1, 'O') + checkDiagonal(BoardX2, 'O') + checkDiagonal(BoardX3, 'O') +
			   checkDiagonal(BoardY1, 'O') + checkDiagonal(BoardY2, 'O') + checkDiagonal(BoardY3, 'O') +
			   checkDiagonal(BoardZ1, 'O') + checkDiagonal(BoardZ1, 'O') + checkDiagonal(BoardZ3, 'O'));	 
		
	XScoreGlobal = XScore;
	OScoreGlobal = OScore;	
		
//	cout << "X's score: " << XScore << endl;
//	cout << "O's score: " << OScore << endl; 	
}

int checkAxis(TTTBoard board, char check)
{
	int total = 0;
	
	if (board.spot1.value == check && board.spot1.value == board.spot2.value && board.spot2.value == board.spot3.value)
	{
		total += 1;
	}
	
	if (board.spot4.value == check && board.spot4.value == board.spot5.value && board.spot5.value == board.spot6.value)
	{
		total += 1;
	}
	
	if (board.spot7.value == check && board.spot7.value == board.spot8.value && board.spot8.value == board.spot9.value)
	{
		total += 1;
	}
	
	if (board.spot1.value == check && board.spot1.value == board.spot4.value && board.spot4.value == board.spot7.value)
	{
		total += 1;
	}
	
	if (board.spot2.value == check && board.spot2.value == board.spot5.value && board.spot5.value == board.spot8.value)
	{
		total += 1;
	}
	
	if (board.spot3.value == check && board.spot3.value == board.spot6.value && board.spot6.value == board.spot9.value)
	{
		total += 1;
	}
	return total;
}

int checkDiagonal(TTTBoard board, char check)
{
	int total = 0;
	
	if (board.spot1.value == check && board.spot1.value == board.spot5.value && board.spot5.value == board.spot9.value)
	{
		total += 1;
	}
	
	if (board.spot3.value == check && board.spot3.value == board.spot5.value && board.spot5.value == board.spot7.value)
	{
		total += 1;
	}
	
	return total;
}

int startingPlayer()
{
	int flip;
	flip = rand() % 2 + 1;
	
	if (flip == 1)
	{
		return 1;
	}
	else
	{
		return 2;
	}
}
class TicTacToe{
	
	//player interaction
	int playerChoice;
	
	public:
		//board array
		char block[10]; 
		int turnFirst; //variable to decide whoever goes first
		bool playerTurn;
		//keeping score
		int playerScore;
    	int computerScore;

		void checkWin()
		//first block: first 8 winning combinations for player
		//second block: first 8 winning combinations for computer
		{
			playerScore = 0;
			computerScore = 0;
			//check for player combinations
		    if(block[1] == 'X' && block[5] == 'X' && block[9] == 'X'){ //diagonal, 1 - 5 = 9
		        playerScore++; //This will increment score for player.
		    }
		    if(block[3] == 'X' && block[5] == 'X' && block[7] == 'X'){ //diagonal, 3 - 5 = 7
		        playerScore++;
		    }
		    if(block[1] == 'X' && block[2] == 'X' && block[3] == 'X'){ //horizontal 1 - 2 = 3
		        playerScore++;
		    }
		    if(block[4] == 'X' && block[5] == 'X' && block[6] == 'X'){ //horizontal 4 - 5 = 6
		        playerScore++;
		    }
		    if(block[7] == 'X' && block[8] == 'X' && block[9] == 'X'){ //horizontal 7 - 8 = 9
		        playerScore++;
		    }
		    if(block[1] == 'X' && block[4] == 'X' && block[7] == 'X'){ //vertical 1 - 4 = 7
		        playerScore++;
		    }
		    if(block[2] == 'X' && block[5] == 'X' && block[8] == 'X'){ //vertical 2 - 5 = 8
		        playerScore++;
		    }
		    if(block[3] == 'X' && block[6] == 'X' && block[9] == 'X'){ //vertical 3 - 6 = 9
		        playerScore++;
		    }
			//check for computer scores
			if(block[1] == 'O' && block[5] == 'O' && block[9] == 'O'){ //diagonal, 1 - 5 - 9
		        computerScore++; //This will increment score for computer.
		    }
		    if(block[3] == 'O' && block[5] == 'O' && block[7] == 'O'){ //diagonal, 3 - 5 - 7
		        computerScore++;
			}
		    if(block[1] == 'O' && block[2] == 'O' && block[3] == 'O'){ //horizontal 1 - 2 - 3
		        computerScore++;
		    }
		    if(block[4] == 'O' && block[5] == 'O' && block[6] == 'O'){ //horizontal 4 - 5 - 6
		        computerScore++;
			}
		    if(block[7] == 'O' && block[8] == 'O' && block[9] == 'O'){ //horizontal 7 - 8 - 9
		        computerScore++;
		    }
		    if(block[1] == 'O' && block[4] == 'O' && block[7] == 'O'){ //vertical 1 - 4 - 7
		        computerScore++;
		    }
		    if(block[2] == 'O' && block[5] == 'O' && block[8] == 'O'){ //vertical 2 - 5 - 8
		        computerScore++;
		    }
		    if(block[3] == 'O' && block[6] == 'O' && block[9] == 'O'){ //vertical 3 - 6 - 9
		        computerScore++;
	    	}
		}
		int computerAI()
		{
			bool validChoice;
			int r = 0;
			srand(time(0));
		    playerTurn = false;
		    
		    //find an available square
		    while(!validChoice){
		    	r = (rand() % (9)) + 1;
		    	if(block[r] == r + '0'){
		    		validChoice = true;
		    	}
		    }
		    
			//set computer's choice
			block[r] = 'O';
		    return 0;
		}
		
		int checkPlayerInput(){
		    if(int(playerChoice) == 1 && block[1] == '1'){
		        block[1] = 'X';
		    }
		    if(int(playerChoice) == 2 && block[2] == '2'){
		        block[2] = 'X';
		    }
		    if(playerChoice == 3 && block[3] == '3'){
		        block[3] = 'X';
			}
		    if(playerChoice == 4 && block[4] == '4'){
		        block[4] = 'X';
		    }
		    if(playerChoice == 5 && block[5] == '5'){
		        block[5] = 'X';
		    }
		    if(playerChoice == 6 && block[6] == '6'){
		        block[6] = 'X';
		    }
		    if(playerChoice == 7 && block[7] == '7'){
		        block[7] = 'X';
		    }
		    if(playerChoice == 8 && block[8] == '8'){
		        block[8] = 'X';
		    }
		    if(playerChoice == 9 && block[9] == '9'){
		        block[9] = 'X';
		    }
		
		    return 0;
		}
		
		//Display to user
		void gameBoard()
		{
		    cout << "+-----+-----+-----+" << endl;
		    cout << "|  " <<block[1] << "  |  " << block[2] << "  |  " << block[3] << "  |" << endl;
		    cout << "+-----+-----+-----+" << endl;
		    cout << "|  " <<block[4] << "  |  " << block[5] << "  |  " << block[6] << "  |" << endl;
		    cout << "+-----+-----+-----+" << endl;
		    cout << "|  " <<block[7] << "  |  " << block[8] << "  |  " << block[9] << "  |\n";
		    cout << "+-----+-----+-----+" << endl;
		}
		
		void displayScore()
		{
		    cout << "Player: " << playerScore << " Computer: "<< computerScore << endl;
		}
		bool checkTie()
		{
		    if(block[1] != '1' && block[2] != '2' && block[3] != '3' && block[4] != '4' && block[5] != '5' && block[6] != '6' && block[7] != '7' && block[8] != '8' && block[9] != '9')
		    {
				return true;
		    }
		    else{
		    	return false;
		    }
		
		}
		//adds user input verification then continues to next turn in game
		int nextTurn(){
		    int counter = 0;

			bool validChoice;
			int i = 0;
            if(playerTurn == true) //player loop
            {
            	validChoice = false;
            	counter = 0;
            	//verification of user input (only integers)
            	while (!validChoice){
            		if (counter > 0){
            			cout << "Last choice was invalid. Please try again. " << endl << endl;
					}
                	cout << "Please choose a grid to place (only integers 1-9)(X): " << endl << endl;
	                cin >> playerChoice; //error traps letters and words
	                
                	if(int(playerChoice) > 0 && int(playerChoice) < 10){
                		i = int(playerChoice);
                		if(block[i] == playerChoice + '0'){
                			validChoice = true;
                		}
					}

	                if(validChoice){
	                	checkPlayerInput();
	                	playerTurn = false;
	            	} else {
	            		counter++;
	           		}
	            }
            }
			else
            {
                computerAI();
                playerTurn = true;
            }
		}
		
		//starts the game
		int initiatePlay(){
			int i;
			srand(time(0));
		    playerScore = 0;
		    computerScore = 0;
	        turnFirst = rand()% (2)+1;//generates starting person.
	
			//initialize gameplay
			for(i = 0; i < 10; i++){
				block[i] = i + '0';
			}
			
	        if(turnFirst == 1)//player first
	        {
	        	playerTurn = true;
	    	} else {
	    		playerTurn = false;
	    	}
	    	
		}
		~TicTacToe(){};
};

//derived class for 3D game
class derivedTTT: public TicTacToe
{
	TicTacToe Board1;
	TicTacToe Board2;
	TicTacToe Board3;
	bool playerTurn;
	int playerScore;
	int computerScore;
	
	int i;
	//all winning combinations between levels, not including original 8 for each board.
	int winningCombos[25][3] = {
		{1,1,1},
		{2,2,2},
		{3,3,3},
		{4,4,4},
		{5,5,5}, 
		{6,6,6},
		{7,7,7},
		{8,8,8},
		{9,9,9},
		{1,2,3},
		{3,2,1},
		{4,5,6},
		{6,5,4},
		{7,8,9},
		{9,8,7},
		{1,4,7},
		{7,4,1},
		{2,5,8},
		{8,5,2},
		{3,6,9},
		{9,6,3},
		{1,5,9},
		{9,5,1},
		{3,5,7},
		{7,5,3}
	};
	public:
		//sets boards to blank
		void resetBoards()
		{
			Board1.initiatePlay();
			Board2.initiatePlay();
			Board3.initiatePlay();
			playerTurn = Board1.playerTurn;
		}
		void play()
		{
			do{
				system("CLS");
				cout << "Welcome to 3-D Tic-Tac-Toe!" << endl << endl;
				updateScore();
				cout << "Layer 1" << endl;
		        Board1.gameBoard();
				Board1.nextTurn();
				playerTurn = Board1.playerTurn;
			}while(!Board1.checkTie());
			
			Board2.playerTurn = playerTurn;
			
			do{
				system("CLS");
				cout << "Welcome to 3-D Tic-Tac-Toe!" << endl << endl;
				updateScore();
				cout << "Layer 1" << endl;
		        Board1.gameBoard();
		        cout << "Layer 2" << endl;
		        Board2.gameBoard();
				Board2.nextTurn();
				playerTurn = Board2.playerTurn;
			}while(!Board2.checkTie());
			
			Board3.playerTurn = playerTurn;
			
			do{
				system("CLS");
				cout << "Welcome to 3-D Tic-Tac-Toe!" << endl << endl;
				updateScore();
				cout << "Layer 1" << endl;
		        Board1.gameBoard();
		        cout << "Layer 2" << endl;
		        Board2.gameBoard();
		        cout << "Layer 3" << endl;
		        Board3.gameBoard();
				Board3.nextTurn();
				playerTurn = Board3.playerTurn;
			}while(!Board3.checkTie());
			
			system("CLS");
			updateScore();
			cout << "Layer 1" << endl;
			Board1.gameBoard();
			cout << "Layer 2" << endl;
			Board2.gameBoard();
			cout << "Layer 3" << endl;
			Board3.gameBoard();
			if(playerScore == computerScore){
				cout << "It is a tie!" << endl;
			}
			else if(playerScore > computerScore){
				cout << "The player wins!" << endl;
			}
			else{
				cout << "The computer wins!" << endl;
			}
		}
		
		void updateScore()
		{
			char checkBlock1;
			char checkBlock2;
			char checkBlock3;
			playerScore = 0;
			computerScore = 0;
			Board1.checkWin();
			Board2.checkWin();
			Board3.checkWin();
			playerScore = playerScore + Board1.playerScore + Board2.playerScore + Board3.playerScore;
			computerScore = computerScore + Board1.computerScore + Board2.computerScore + Board3.computerScore;
			
			for(i = 0;i < 25;i++){
				//getting first board element
				checkBlock1 = Board1.block[winningCombos[i][0]];
				//getting second board element
				checkBlock2 = Board2.block[winningCombos[i][1]];
				//getting third board element
				checkBlock3 = Board3.block[winningCombos[i][2]];
				if(checkBlock1 == 'X' && checkBlock2 == 'X' && checkBlock3 == 'X'){
					playerScore++;
				}
				else if(checkBlock1 == 'O' && checkBlock2 == 'O' && checkBlock3 == 'O'){
					computerScore++;
				}
			}
			cout << "Player Score: " << playerScore << "  Computer Score: " << computerScore << endl;
		}
		~derivedTTT(){};
};

class Competition: public TTTBoard, public TicTacToe
{
	public:
	int XWins; int OWins; int Winner;
	
	Competition();
};

Competition::Competition()
{
	XWins = 0;
	OWins = 0;
	Winner = 0;
}


int main()
{
	Competition competition;
	int gameNumber = 0;
	
	int turnCount = 0;
	int currentPlayer;
	int success;
	
	srand(time(NULL));
	
	TTTBuilder spotA(1);
	TTTBuilder spotB(2);
	TTTBuilder spotC(3);
	TTTBuilder spotD(4);
	TTTBuilder spotE(5);
	TTTBuilder spotF(6);
	TTTBuilder spotG(7);
	TTTBuilder spotH(8);
	TTTBuilder spotI(9);
	
	
	currentPlayer = startingPlayer();
	
	while (gameNumber < 10)
	{
	turnCount = 0;
	endCondition = 1;
	XScoreGlobal;
	OScoreGlobal;
	
	
	//Instructions
	
	
	spotA.setValue(' ');
	spotB.setValue(' ');
	spotC.setValue(' ');
	spotD.setValue(' ');
	spotE.setValue(' ');
	spotF.setValue(' ');
	spotG.setValue(' ');
	spotH.setValue(' ');
	spotI.setValue(' ');
	
	TTTBoard boardX1(spotA, spotB, spotC, spotD,
				 spotE, spotF, spotG, spotH,
				 spotI, 'X', 1);
				 
	TTTBoard boardX2(spotA, spotB, spotC, spotD,
				 spotE, spotF, spotG, spotH,
				 spotI, 'X', 2);
					 
	TTTBoard boardX3(spotA, spotB, spotC, spotD,
				 spotE, spotF, spotG, spotH,
				 spotI, 'X', 3);
	TTTBuilder *boardArray1 = new TTTBoard[9];
	TTTBuilder *boardArray2 = new TTTBoard[9];
	TTTBuilder *boardArray3 = new TTTBoard[9];
	
	boardArray1[0] = spotA; boardArray1[1] = spotB; boardArray1[2] = spotC;
	boardArray1[3] = spotD; boardArray1[4] = spotE; boardArray1[5] = spotF;
	boardArray1[6] = spotG; boardArray1[7] = spotH; boardArray1[8] = spotI;
		
	boardArray2[0] = spotA; boardArray2[1] = spotB; boardArray2[2] = spotC;
	boardArray2[3] = spotD; boardArray2[4] = spotE; boardArray2[5] = spotF;
	boardArray2[6] = spotG; boardArray2[7] = spotH; boardArray2[8] = spotI;
	
	boardArray3[0] = spotA; boardArray3[1] = spotB; boardArray3[2] = spotC;
	boardArray3[3] = spotD; boardArray3[4] = spotE; boardArray3[5] = spotF;
	boardArray3[6] = spotG; boardArray3[7] = spotH; boardArray3[8] = spotI;
	
	cout << boardArray1[0].value << boardArray1[1].value << boardArray1[2].value << boardArray1[3].value;
	
	

	
	
	
	
	
	
		
	while (endCondition)
	{
		
		if (turnCount == 27)
		{
			endCondition = 0;
			if (XScoreGlobal > OScoreGlobal)
			{
				cout << "X Wins" << endl;
				competition.XWins += 1;
			}
			if (OScoreGlobal > XScoreGlobal)
			{
				cout << "O Wins" << endl;
				competition.OWins += 1;
			}
			if (OScoreGlobal == XScoreGlobal)
			{
				cout << "Draw" << endl;
			}
			gameNumber += 1;
			
			break;
		}
		if (currentPlayer == 1)
		{
			//cout << "It is currently the computer's turn" << endl;
			
			success = 1;
			turnCount++;
		}
		else
		{
			//cout << "It is currently your turn" << endl;
			success = 1;
			turnCount++;
		}
		
		if (currentPlayer == 1)
		{
			while (success)
			{
				int computerChoicePosition;
				int computerChoiceLevel;
				
				computerChoiceLevel = rand() % 3 + 1;
				computerChoicePosition = rand() % 9 + 1;
				
				if (computerChoiceLevel == 1)
				{
					if (boardArray1[computerChoicePosition - 1].value == ' ')
					{
						switch(computerChoicePosition)
						{
							case 1:
								boardX1.spot1.setValue('O');
								break;
							case 2:
								boardX1.spot2.setValue('O');
								break;
							case 3:
								boardX1.spot3.setValue('O');
								break;
							case 4:
								boardX1.spot4.setValue('O');
								break;
							case 5:
								boardX1.spot5.setValue('O');
								break;
							case 6:
								boardX1.spot6.setValue('O');
								break;
							case 7:
								boardX1.spot7.setValue('O');
								break;
							case 8:
								boardX1.spot8.setValue('O');
								break;
							case 9:
								boardX1.spot9.setValue('O');
								
						}
						
						boardArray1[computerChoicePosition - 1].setValue('O');
						success = 0;
						currentPlayer = 2;
						
					}
				}
				
				if (computerChoiceLevel == 2)
				{
					if (boardArray2[computerChoicePosition - 1].value == ' ')
					{
						switch(computerChoicePosition)
						{
							case 1:
								boardX2.spot1.setValue('O');
								break;
							case 2:
								boardX2.spot2.setValue('O');
								break;
							case 3:
								boardX2.spot3.setValue('O');
								break;
							case 4:
								boardX2.spot4.setValue('O');
								break;
							case 5:
								boardX2.spot5.setValue('O');
								break;
							case 6:
								boardX2.spot6.setValue('O');
								break;
							case 7:
								boardX2.spot7.setValue('O');
								break;
							case 8:
								boardX2.spot8.setValue('O');
								break;
							case 9:
								boardX2.spot9.setValue('O');
								
						}
						boardArray2[computerChoicePosition - 1].setValue('O');
						success = 0;
						currentPlayer = 2;
						
					}
				
				}
				
				if (computerChoiceLevel == 3)
				{
					if (boardArray3[computerChoicePosition - 1].value == ' ')
					{
						switch(computerChoicePosition)
						{
							case 1:
								boardX3.spot1.setValue('O');
								break;
							case 2:
								boardX3.spot2.setValue('O');
								break;
							case 3:
								boardX3.spot3.setValue('O');
								break;
							case 4:
								boardX3.spot4.setValue('O');
								break;
							case 5:
								boardX3.spot5.setValue('O');
								break;
							case 6:
								boardX3.spot6.setValue('O');
								break;
							case 7:
								boardX3.spot7.setValue('O');
								break;
							case 8:
								boardX3.spot8.setValue('O');
								break;
							case 9:
								boardX3.spot9.setValue('O');
								
						}
						boardArray3[computerChoicePosition - 1].setValue('O');
						success = 0;
						currentPlayer = 2;
						
					}
				}
				
			}
		}
		
		if (currentPlayer == 2)
		{ 
			
			while (success)
			{
				int computerChoicePosition;
				int computerChoiceLevel;
				
				computerChoiceLevel = rand() % 3 + 1;
				computerChoicePosition = rand() % 9 + 1;
				
				if (computerChoiceLevel == 1)
				{
					if (boardArray1[computerChoicePosition - 1].value == ' ')
					{
						switch(computerChoicePosition)
						{
							case 1:
								boardX1.spot1.setValue('X');
								break;
							case 2:
								boardX1.spot2.setValue('X');
								break;
							case 3:
								boardX1.spot3.setValue('X');
								break;
							case 4:
								boardX1.spot4.setValue('X');
								break;
							case 5:
								boardX1.spot5.setValue('X');
								break;
							case 6:
								boardX1.spot6.setValue('X');
								break;
							case 7:
								boardX1.spot7.setValue('X');
								break;
							case 8:
								boardX1.spot8.setValue('X');
								break;
							case 9:
								boardX1.spot9.setValue('X');
								
						}
						
						boardArray1[computerChoicePosition - 1].setValue('X');
						success = 0;
						currentPlayer = 1;
						
					}
				}
				
				if (computerChoiceLevel == 2)
				{
					if (boardArray2[computerChoicePosition - 1].value == ' ')
					{
						switch(computerChoicePosition)
						{
							case 1:
								boardX2.spot1.setValue('X');
								break;
							case 2:
								boardX2.spot2.setValue('X');
								break;
							case 3:
								boardX2.spot3.setValue('X');
								break;
							case 4:
								boardX2.spot4.setValue('X');
								break;
							case 5:
								boardX2.spot5.setValue('X');
								break;
							case 6:
								boardX2.spot6.setValue('X');
								break;
							case 7:
								boardX2.spot7.setValue('X');
								break;
							case 8:
								boardX2.spot8.setValue('X');
								break;
							case 9:
								boardX2.spot9.setValue('X');
								
						}
						boardArray2[computerChoicePosition - 1].setValue('X');
						success = 0;
						currentPlayer = 1;
						
					}
				}
				
				if (computerChoiceLevel == 3)
				{
					if (boardArray3[computerChoicePosition - 1].value == ' ')
					{
						switch(computerChoicePosition)
						{
							case 1:
								boardX3.spot1.setValue('X');
								break;
							case 2:
								boardX3.spot2.setValue('X');
								break;
							case 3:
								boardX3.spot3.setValue('X');
								break;
							case 4:
								boardX3.spot4.setValue('X');
								break;
							case 5:
								boardX3.spot5.setValue('X');
								break;
							case 6:
								boardX3.spot6.setValue('X');
								break;
							case 7:
								boardX3.spot7.setValue('X');
								break;
							case 8:
								boardX3.spot8.setValue('X');
								break;
							case 9:
								boardX3.spot9.setValue('X');
								
						}
						boardArray3[computerChoicePosition - 1].setValue('X');
						success = 0;
						currentPlayer = 1;
						
					}
				}
				
			}
		}
		system("CLS");
		checkWinEventTotal(boardX1, boardX2, boardX3);
		printBoard(boardX1);
		printBoard(boardX2);
		printBoard(boardX3);
		cout << "Game number: " << gameNumber + 1 << endl;
		cout << "David has won: " << competition.XWins << " games" << endl;
		cout << "Daniel has won: " << competition.OWins << " games" << endl;
		cout << "Draws: " << (gameNumber) - (competition.XWins + competition.OWins) << endl;
		Sleep(12);
	}
	checkWinEventTotal(boardX1, boardX2, boardX3);
	}
	
	system("CLS");
	cout << endl;
	cout << "David has won: " << competition.XWins << " games" << endl;
	cout << "Daniel won: " << competition.OWins << " games" << endl;
	cout << 10 - (competition.XWins + competition.OWins) << " games ended in a draw." << endl << endl;
	if (competition.XWins > competition.OWins)
	{
		cout << "David wins overall.";
	}
	if (competition.OWins > competition.XWins)
	{
		cout << "Daniel has won overall.";
	}
	if (competition.OWins == competition.XWins)
	{
		cout << "The game has ended in a draw.";
	}
}
