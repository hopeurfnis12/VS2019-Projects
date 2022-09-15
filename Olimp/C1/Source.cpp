#include <iostream>

using namespace std;

int main() {
	int n, m;
	int x = 0;
	int y = 0;
	int z = 0;
	int f = 0;

	cin >> n >> m;

	int**arr = new int*[n];

	for (int i = 0; i < n; i++)
		arr[i] = new int[m];

	for (int i = 0; i < n; i++)
		for (int c = 0; c < m; c++)cin >> arr[i][c];

	for (int i = 0; i < n; i++) {
		for (int c = 0; c < m; c++) {
			if (arr[i][c] == 0)z++;
			else {
				z = 0; continue;
			}
			if (x < z)x = z;
		}
		z = 0;
	}

	for (int c = 0; c < m; c++) {
		for (int i = 0; i < n; i++) {
			if (arr[i][c] == 1)f++;
			else { f = 0; continue; }
			if (y < f)y = f;
		}
		f = 0;
	}

	cout << x << " " << y << endl;

	for (int i = 0; i < n; i++)delete[]arr[i];
	delete[]arr;
}