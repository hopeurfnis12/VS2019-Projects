#include <iostream>
#include <string>

using namespace std;

int main() {
	int x = 0;
	int y = 0;
	int z = 0;
	bool t=true;
	string c;
	string g = "D";
	string r = "R";
	string l = "L";
	getline(cin, c);
	int len = c.length();
	int *arr = new int[len];
	for (int i = 0; i <= len*2; i=i+2) {
		arr[i] = x;
		arr[i + 1] = y;
		if (c[0]=='L') {
			auto pos = c.find(l);
			c.erase(pos, l.size());
			if (z == -3) { y--; z++; }
			if (z == -2) { x++; z++; }
			if (z == -1) { y++; z++; }
			if (z ==  0) { x--; z++; }
			if (z ==  1) { y--; z++; }
			if (z ==  2) { x++; z++; }
			if (z == 3) { y++; z = 0; }
			
		}else
		if (c[0]=='R') {
			auto pos = c.find(r);
			c.erase(pos, r.size());
			if (z == -3) { y++; z=0; }
			if (z == -2) { x--; z--; }
			if (z == -1) { y--; z--; }
			if (z ==  0) { x++; z--; }
			if (z ==  1) { y++; z--; }
			if (z ==  2) { x--; z--; }
			if (z ==  3) { y--; z--; }
		}else
		if (c[0]=='D') {
			auto pos = c.find(g);
			c.erase(pos, r.size());
			if (z == -3) { x--; }
			if (z == -2) { y--; }
			if (z == -1) { x++; }
			if (z == 0) { y++; }
			if (z == 1) { x--; }
			if (z == 2) { y--; }
			if (z == 3) { x++; }
		}
	}
	for (int i = len*2; i >= 0; i=i-2) {
		for (int f = i-2; f >= 0; f=f-2) {
			if (arr[len*2] == arr[f] && arr[(len*2) + 1] == arr[f + 1])t = false;
		}
	}
	if (t == false)cout << 0 << endl;
	if (t == true)cout << 1 << endl;
	delete[]arr;
}