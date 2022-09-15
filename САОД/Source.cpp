#include <iostream>
#include <ctime>
#include <fstream>

using namespace std;

long long Sort(long long *A, int n) {
	int x, y;
	for (int j = 0; j < n; j++) {
		for (int i = n - 1; i > 0; i--) {
			if (A[i] < A[i - 1]) {
				x = A[i];
				A[i] = A[i - 1];
				A[i - 1] = x;
			}
		}
	}
	return 0;
}
int main() {
	ifstream in("input.txt");
	ofstream out("output.txt");
	srand(time(0));
	long long *A, n;
	cin >> n;
	A = new long long[n];
	for (int i = 0; i < n; i++) {
//		in >> A[i];
		A[i] = 0 + 11 * (1.0*rand()) / RAND_MAX;
	//	cout << A[i] << " ";
	}
//	cout << endl;
	int t0 = clock();
	Sort(A, n);
	int t1 = clock() - t0;
	cout << t1;
//	for (int i = 0; i < n; i++) {
//		out << A[i] << " ";
//	}
	in.close();
	out.close();
}