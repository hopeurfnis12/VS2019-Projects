// 16.2
#include <fstream>
#include <iostream>
#include <vector>
using namespace std;
int main() {
	int n, m, x = 0, y = 0, i, j, a, b;
	ifstream in("input.txt");
	in >> n >> m;
	vector<vector<int> > A(n, vector<int>(m, 0));
	cin >> a >> b;
	for (i = 0; i < n; i++) {
		x = 0;
		for (j = 0; j < m; j++) {
			in >> A[i][j];
			if (A[i][j] >= a && A[i][j] <= b) {
				x++;
			}
		}
		if (x == m) {
			cout << i + 1 << " ";
			y++;
		}
	}
	if (y == 0) cout << -1;
}