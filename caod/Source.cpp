#include <cstdlib>
#include <stdio.h>
using namespace std;

long *A = new long[1000000];

int comp(const void *i, const void *j) {
	return *(long *)i - *(long *)j;
}

int main() {
	FILE *in;
	FILE *out;
	in = fopen("input.txt", "r");
	out = fopen("output.txt", "w");
	int n;
	fscanf(in, "%d", &n);
	for (int i = 0; i < n; i++) {
		fscanf(in, "%ld", &A[i]);
	}
	qsort(A, n, sizeof(long), comp);
	for (int i = 0; i < n; i++) {
		fprintf(out, "%ld", A[i]);
		fprintf(out, "%c", ' ');
	}
}