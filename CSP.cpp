#include<iostream>
#include<string>
using namespace std;

#define V 6
int color[V],m,n;
bool graph[V][V];
void printSolution(int color[]);

bool isSafe (int v, bool graph[V][V], int color[], int c)
{
	for (int i = 0; i < V; i++)
	{
		if (graph[v][i] == 1 && c == color[i])
		{
			return false;
		}
	}
	return true;
}
bool continueColoring(bool graph[V][V], int m, int color[], int v)
{  
	if (v == V)
	{
		return true;
	}
	for (int c = 1; c <= m; c++)
	{
        if (isSafe(v, graph, color, c))
		{
			color[v] = c;
			if (continueColoring (graph, m, color, v+1) == true)
			{
				return true;
			}
			color[v] = 0;
		}
	}
	return false;
}
string stringColor(int nodecolor)
{
	if(nodecolor == 1){
		return "RED";
	}
	else if(nodecolor == 2){
		return "GREEN";
	}
	else{
		return "BLUE";
	}
}
bool coloring(bool graph[V][V], int m)
{
	for (int i = 0; i < V; i++)
	{
		color[i] = 0;
	}
	if (continueColoring(graph, m, color, 0) == false)
	{
		cout<<"No Solution";
		return false;
	}
	for (int i = 0; i < V; i++)
	{
		cout<<"Node "<<i<<", Color = "<<stringColor(color[i])<<" \n";
	}
	return true;
}

int main()
{	
	cout<<"Total 3 Colors, 6 Nodes and 9 Edges\n";
	cout<<"EDGES\n";
	for(int i=0;i<9;i++){
		cin>>m>>n;
		graph[m][n] = graph[n][m] = 1;
	}
	cout<<endl;
	int m = 3; 
	coloring (graph, m);
	return 0;
}