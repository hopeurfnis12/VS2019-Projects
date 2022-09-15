#include <iostream>
using namespace std;

int main() {
	char *s1 = new char[100];
	char *s2 = new char[100];
	int sum = 0, max, x = 0, y = 0;
	fgets(s1, 100, stdin);
	fgets(s2, 100, stdin);
	int n1 = strlen(s1) - 1;
	int n2 = strlen(s2) - 1;
	max = n1 + n2;
	for (int i = 0; i < max; i++) {
		if (s1[y] == s2[x]) {
			sum++;
			y++;
		}
		else {
			if (s1[y] > s2[x]) x++;
			else y++;
		}
		if (x > n2 || y > n1) break;
	}
	cout << sum << endl;
}