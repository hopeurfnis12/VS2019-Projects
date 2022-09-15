#include <iostream>
using namespace std;

int main() {
	double s=10, a[10], d, min, z, m;
	for (int i = 0; i < s; i++) {
		cin >> a[i];
	}
	d = a[0];
	min = a[0];
	for (int i = 1; i < s; i++) {
		z = abs(a[0] - a[i]);
		if (min >= z) {
			min = z;
			m = a[i];
		}
	}
	cout << m << endl;
}
