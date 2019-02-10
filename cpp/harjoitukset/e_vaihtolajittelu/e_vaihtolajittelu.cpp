#include <iostream>
#include <clocale>
using namespace std;

int main() {
	setlocale(LC_ALL, "fi-FI");
	const int MAX = 4;
	int luvut[MAX] = {2, 7, 1, 3};

	cout << "Vaihtolajittelu\n\n";

	for (int i = 0; i < MAX; i++) {
		cout << "Järjestysnumero: " << i;
		cout << " Sisältö: " << luvut[i] << endl;
	}

	for (int j = 0; j < MAX-1; j++) {
		for (int k = j+1; k < MAX; k++) {
			if (luvut[k] > luvut[j]) {
				int apu = luvut[j];
				luvut[k] = luvut[j];
				luvut[j] = apu;
			}
		}
	}

	cout << endl;

	for (int i = 0; i < MAX; i++) {
		cout << "Järjestysnumero: " << i;
		cout << " Sisältö: " << luvut[i] << endl;
	}

}