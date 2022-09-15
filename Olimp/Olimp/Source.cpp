#include <iostream>

using namespace std;

int main() {
	int x;
	float z;
	float g = 0;
	int n = 0;
	cin >> x;
	int *y = new int[x];
	if (x <= 1000) {
		for (int i = 0; i < x; i++) {
			cin >> y[i];
		}
		cin >> z;
		for (int c = 0; c < x; c++) {
			if (y[c] < 2 || y[c] == 2)continue;
			else {
				y[c] = y[c] - 2;
				n = n + y[c];
			}
		}
		g = n / z;
		cout << ceil(g) << endl;
	}
	else cout << ceil(g) << endl;
	delete[] y;
}