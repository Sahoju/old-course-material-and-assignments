#include <iostream>
using namespace std;
void main() {
	int spd[5] = { 0,0,0,0,0 };
	int avg = 0;

	for (int i = 0; spd[i] >= 0; i++) {
		cout << "Anna nopeus: ";
		cin >> spd[i];
		if (spd[i] < 0) {
			break;
		}
		for (int j = 0; j < 5; j++) {
			avg = avg + spd[j];
		}
		cout << "Nopeus: " << avg / 5 << " km/h\n";
		avg = 0;
		if (i == 4) {
			i = -1;
		}
	}
}