#include <iostream>
#include <cmath>

using namespace std;

void main() {
	long long t, x, x1 = 1, x2 = 10, z, s, y;
	bool f = true;
	cin >> t;
	long long *a = new long long[t];
	for (int i = 1; i <= t; i++) {
		cin >> s;
		if (s == 1) a[i] = -1;
		else {
			f = true;
			x = pow(10, s - 1);
			int c = x;
				for (c = x; c < pow(10, s); c++) {
					y = (x / x1) % 10;
					if (x%y == 0) { f = false; break; }
					x1 *= 10;
				}
			if (f == true) { a[i] = c; break; }
		}
	}
	for (int i = 1; i <= t; i++) cout << a[i] << endl;
}