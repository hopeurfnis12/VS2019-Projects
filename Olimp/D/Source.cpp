#include <iostream>

using namespace std;

int main() {
	int n, x, a, b;
	bool t=true;
	cin >> n;
	cin >> a >> b;
	if (n >= 1 && n <= 10000) {
		for (int i = 0; i < 10000; i += 2) if (((abs(b - a) * i) == (n + 1)) && (abs(a - b) != 1)) {t = false; break; }
		if (t == false)cout << "NO" << endl;
		else
				if (a == n)cout << "NO" << endl;
				else
					if ((abs(b - a) == 1) && (n < 3))cout << "NO" << endl;
					else
						if (a == b)cout << "NO" << endl;
						else
							cout << "YES" << endl;
					
	}
}