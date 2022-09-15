#include <iostream>
#include <cstring>

using namespace std;

int main() {
	setlocale(LC_ALL, "ru-RU");
	char s[100];
	fgets(s, 100, stdin);
	int x = 0;
	for (int i = 0; i < 100; i++) {
		cout << s[i];
	}
	return 0;
}