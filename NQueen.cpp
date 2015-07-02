#include <iostream>
#define N 4

using namespace std;

int board[N][N];

bool Check(int row, int col)
{
    for (int i = 0; i < col; i++)
    {
        if (board[row][i] == 1)
            return false;
    }
    for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
    {
        if (board[i][j] == 1)
            return false;
    }
 
    for (int i = row, j = col; j >= 0 && i < N; i++, j--)
    {
        if (board[i][j] == 1)
            return false;
    }
 
    return true;
}
bool SolveQueen(int col)
{
    if (col >= N)
{
        return true;
	}
    for (int i = 0; i < N; i++)
    {
        if ( Check(i, col) )
        {
            board[i][col] = 1;
            if (SolveQueen(col + 1) == true)
			{
                return true;
			}
			else
			{
				board[i][col] = 0;
			}
        }
    }
    return false;
}
bool InitialStep()
{
    int board[N][N] = {0};
    if (SolveQueen(0) == false)
    {
        cout<<"NO SOLUTION"<<endl;
        return false;
    }
    return true;
}
 
int main()
{
    InitialStep();
	for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
		{	
			if(board[i][j] == 1)
			{
				cout<<"QN\t";
			}
			else
			{
				cout<<board[i][j]<<"\t";
			}
		}
        cout<<endl;
    }
    return 0;
}

