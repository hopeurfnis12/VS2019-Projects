#include <iostream>

using namespace std;

int main() {
	long long n, x = 0, y = 1, z=1;
	cin >> n;
	long long *a = new long long[n];
	for (long long i = 1; i <= n; i++) {
		cin >> a[i];
	}
	a[0] = 0;
	x = a[1];
	for (long long i = 1; i <= n; i++) {
		if (i > 1) {	
			y = i - 1;
			if (a[y] >= a[i - 2]) {
				if (a[y] > a[z]) z = y;
				x = a[z];
			}
			a[i] = a[i] + x;
		}
	}
	for (long long i = 1; i <= n; i++) cout << a[i] << " ";
}