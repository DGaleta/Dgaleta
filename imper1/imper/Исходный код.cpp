#include <stdio.h>
#include <iostream>
#include <ctime>

using namespace std;

int main(int argc, char* argv[])
{
	setlocale(0, "");
	srand(unsigned(time(NULL)));
	int N, M;
	cout << "Введите размер матрицы(2а значения): ";
	cin >> N >> M;
	int ** A = new int *[N];
	for (int i = 0; i < N; i++)
		A[i] = new int[M];

	for (int i = 0; i < N; i++)
	for (int j = 0; j < M; j++)
		A[i][j] = ((rand() % 10));


	cout << "Матрица:" << endl << endl;
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < M; j++)
			cout << A[i][j] << " ";
		cout << endl;
	}

	cout << endl;
	for (int i = 0; i < N; i++)
		delete[] A[i];
	delete[] A;
	system("pause");
}
