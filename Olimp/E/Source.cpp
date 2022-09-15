#include <iostream>
#include <string>

using namespace std;

int main() {
	int x  = 0;
	int y  = 0;
	int rl = 0;
	string com;
	string g="D";
	string r="R";
	string R = "RRRR";
	string l="L";
	string L = "LLLL";
	getline(cin,com);
	for (int i = 0; i < com.length(); i++) {
		while (com.find(R) != string::npos) {
			auto pos = com.find(R);
			com.erase(pos, R.size());
		}
		while (com.find(L) != string::npos) {
			auto pos = com.find(L);
			com.erase(pos, L.size());
		}
		while (com.find(g) != string::npos) {
			auto pos= com.find(g);
			com.erase(pos, g.size());
			x++;
		}
		while (com.find(r) != string::npos) {
			auto pos = com.find(r);
			com.erase(pos, r.size());
			rl++;
			if (rl == 4)rl = 0;
		}
		while (com.find(l) != string::npos) {
			auto pos = com.find(l);
			com.erase(pos, l.size());
			rl--;
			if (rl == -4)rl = 0;
		}
		if (x == rl && x==0)cout << 0 << endl;
		else
			if (-1 == rl)cout << 0 << endl;
			else
				if (0 == rl) cout << 0 << endl;
				else
					if ((-3 == rl)&&(x==0)) cout << 0 << endl;
				else
					if (x == 0)cout << 0 << endl;
					else
						cout << 1 << endl;
	}
}