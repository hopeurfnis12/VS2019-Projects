#include <iostream>

using namespace std;

int main() {
	int x, y, z;
	cout << "Место: ";
	cin >> z;
	cout << "Сколько заданий: ";
	cin >> x;
	y = z % x;
	if (y == 0) { y = x; }
	cout << "Задание: " << y << endl;
}