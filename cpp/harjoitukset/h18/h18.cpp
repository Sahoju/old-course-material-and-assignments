/***********************************************
Teht�v�: Harjoitus 18
Kuvaus:
	Tee ohjelma, joka kysyy viiden koiran nimet ja i�t.
	Tiedot tallennetaan tietuetaulukkoon.
	a) j�rjest� tiedot ik� -kent�n mukaan suuruusj�rjestykseen
	(pienimm�st� suurimpaan). Ohjelma tulostaa lopuksi
	jarjestetyn taulukon n�yt�lle.
	b) j�rjest� tiedot nimi -kent�n mukaan aakkosj�rjestyksess�
	Ohjelma tulostaa lopuksi jarjestetyn taulukon n�ytolle.

	Lajittelu tulee toteuttaa siten, ett� se toimisi samoin
	my�s 50 tai 5000 koiran tapauksssa.
Pvm: 25.10.2017
Ver: 1.0 SurJu
***********************************************/

#include <iostream>
#include <clocale>
using namespace std;
void main() {
	setlocale(LC_ALL, "fi-FI");
	int amount = 0;
	int con_add_dogs;
	char choice;
	struct DOG {
		char name[21];
		float age;
	};
	cout << "Sy�t� koirille nimet ja i�t. Ik� voi olla reaaliajassa, mutta ei kuukausina.\n\n";

	DOG dog[5000];
	DOG help;
	cout << "Montako koiraa laitetaan? ";
	cin >> con_add_dogs;
	cin.get();

	do {
		cout << "Sy�t� koiran nimi: ";
		cin.get(dog[amount].name, 21);
		cin.get();
		cout << "Sy�t� koiran ik�: ";
		cin >> ws >> dog[amount].age;
		cin.get();
		amount++;
		con_add_dogs--;
		if (con_add_dogs == 0) {
			cout << "Laitetaanko lis�� koiria? y/n: ";
			cin >> choice;
			if (choice == 'y') {
				continue;
			}
			else if (choice == 'n') {
				break;
			}
			else {
				break;
			}
			cout << "Montako laitetaan? ";
			cin >> con_add_dogs;
		}
	} while (con_add_dogs > 0);

	cout << "J�rjestet��n koirat\n"
		<< "a) i�n mukaan\n"
		<< "b) nimen mukaan\n";
	cin >> choice;
	cin.get();

	if (choice == 'a') {
		for (int j = 0; j < amount - 1; j++) {
			for (int k = j + 1; k < amount; k++) {
				if (j > amount) {
					help = dog[j];
					dog[j] = dog[k];
					dog[k] = help;
				}
			}
		}

		while (amount > 0) {
			cout << dog[amount].age << " " << dog[amount].name << endl;
			amount--;
		}
	}
	else if (choice == 'b') {

	}
}