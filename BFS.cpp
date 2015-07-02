#include<iostream>
#include<conio.h>
#include<stdlib.h>
using namespace std;

int cost[10][10],qu[10],visit[10],visited[10];
int i,j,k,n,v,b,o,front,rare;
 
void main()
{
	int m;
	cout <<"Enter no of Vertex: ";
	cin >> n;
	cout <<"Enter no of Edges: ";
	cin >> m;
	cout <<"\nEDGES \n";
	for(k=1;k<=m;k++)
	{
		cin >>i>>j;
		cost[i][j]=1;
	}
	v = 1;
	cout <<"Vertex You Want to Find: ";
	cin >> o;
	visited[v]=1;
	k=1;
	while(k<n)
	{
		for(j=1;j<=n;j++)
			if(cost[k][j]!=0 && visited[j]!=1 && visit[j]!=1)
			{
				visit[j]=1;
				qu[rare++]=j;
			}
		k++;
		visit[v]=0; visited[v]=1;
	}
	
	for(j=0;j<=n;j++){
		if(qu[j] == o){
			b = 1;
		}
	}
	if(b == 1){
		cout<< "\nFound\n";
	}
	else{
		cout<<"\nNot Found\n";
	}
}