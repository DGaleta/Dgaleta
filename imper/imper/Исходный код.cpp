#include <stdio.h>
#include <iostream>
#include <ctime>

using namespace std;

int main(int argc, char* argv[])
{
	srand(time(0));
	const int raw = 10, col = 10;
	int a[raw][col];
	for (int i = 0; i < raw; i++)
	{
		for (int j = 0; j < col; j++)
		{
			a[i][j] = rand() % 10;
			cout << a[i][j] << " ";
		}
		cout << "\n";
	}
	cout << "\n";
	for (int k = 0; k < raw; k++)
	{
		for (int i = 0; i < col; i++)
		{
			for (int j = raw - 1; j > i; j--)
			if (a[k][j] < a[k][j - 1])
			{
				int tmp = a[k][j];
				a[k][j] = a[k][j - 1];
				a[k][j - 1] = tmp;
			}
			cout << a[k][i] << " ";
		}
		cout << "\n";	
	}
	system("pause");
}
