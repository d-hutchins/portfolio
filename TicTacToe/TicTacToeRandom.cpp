#include <iostream>
#include <ctime>
#include <cstdio>
#include <cstdlib>

/*
Daniel Hutchins - CECS 130 Section 01
Lab 10 (Tic-Tac-Toe program w/ Inheritance) - Dr. Yampolskiy
This program allows the user to play a game of tic-tac-toe against the computer AI.
This is done on a 3 x 3 x 3 board. 
*/

using namespace std;

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
	        turnFirst = rand()% (2 - 1 + 1)+1;//generates starting person.
	
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

int main()
{
	int playAgain;
	derivedTTT game;
	do{	
		game.resetBoards();
		game.play();
		cout << "Do you want to play again? (1 for yes, 2 for no.)" << endl;
		cin >> playAgain;
	}while(playAgain == 1);
	return 0;
}
