#include <iostream>
using namespace std;
void main() {
	int luku1 = 1;
	int luku2 = 2;
	cout << "Sy�t� luku 1: ";
	cin >> luku1;
	cout << "Sy�t� luku 2: ";
	cin >> luku2;
	if (luku1 == luku2) {
		cout << "BINGO\n";
	}
	else {
		cout << "BONGO\n";
	}
}
