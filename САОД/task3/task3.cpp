#include <stdio.h>
#include <ctime>

using namespace std;

long *b;
void Merge(long *A, int p, int q, int r) {
	int i1, i2, i;
	i1 = p; i2 = q + 1; i = p;
	while (i1 <= q && i2 <= r) {
		if (A[i1] <= A[i2]) b[i++] = A[i1++];
		else b[i++] = A[i2++];
	}
	while (i1 <= q) b[i++] = A[i1++];
	while (i2 <= r) b[i++] = A[i2++];
	for (i = p; i <= r; i++) A[i] = b[i];
	return;
}

void Sort(long *A, int p, int r) {
	int q;
	if (p < r) {
		q = (p + r) / 2;
		Sort(A, p, q);
		Sort(A, q + 1, r);
		Merge(A, p, q, r);
		return;
	}
}

int main() {
	FILE *in;
	FILE *out;
	in = fopen("input.txt", "r");
	out = fopen("output.txt", "w");
	long *A;
	int n;
	fscanf(in, "%d", &n);
	A = new long[n];
	b = new long[n];
	for (int i = 0; i < n; i++) {
		fscanf(in, "%ld", &A[i]);
	}
	Sort(A, 0, n - 1);
	for (int i = 0; i < n; i++) {
		fprintf(out, "%ld", A[i]);
		fprintf(out, "%c", ' ');
	}
	fclose(in);
	fclose(out);
}