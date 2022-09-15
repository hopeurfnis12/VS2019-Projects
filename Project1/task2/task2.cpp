#include <iostream>
#include <fstream>
#include <string>
#include <ctime>
using namespace std;

ifstream in("input.txt");
ofstream out("output.txt");

int main() {
	int start = clock();
	string str; // строка
	string substr; // подстрока которую ищем в строке

	in >> str;
	in >> substr;

	int sl, ssl; // длины строк str и substr
	sl = str.length();
	ssl = substr.length();
	for (int i = 0; i < sl - ssl + 1; i++) {

		for (int j = 0; j < ssl; j++) {

			if (substr[j] != str[i + j]) break; // break если символ подстроки
											  // несовпадает
											  // с символом строкой

			else

				if (j == ssl - 1) {
					cout << i << " "; // вывод индекса строки
					break;
				}

		}

	}
	int end = clock();
	cout << endl << end - start << endl << (sl - ssl + 1) * ssl;
}