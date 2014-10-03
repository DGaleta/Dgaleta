#include <stdio.h>
#include <iostream>
#include <ctime>

using namespace std;

int main(int argc, char* argv[])
{
	int t, i, num[4][4];
	/* загрузка чисел */
		for (t = 0; t<3; ++t)
			for (i = 0; i<4; ++i)
				num[t][i] = (t * 4) + i + 1;

	/* вывод чисел */
		for (t = 0; t<3; ++t)
		{
			for (i = 0; i<4; ++i)
				printf("%d  ", num[t][i]);
				printf("\n");
		}
	system("pause");
	return 0;
}