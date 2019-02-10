/***********************************************
Tehtävä: Harjoitus 18
Kuvaus:
	Tee ohjelma, joka kysyy viiden koiran nimet ja iät.
	Tiedot tallennetaan tietuetaulukkoon.
	a) järjestä tiedot ikä -kentän mukaan suuruusjärjestykseen
	(pienimmästä suurimpaan). Ohjelma tulostaa lopuksi
	jarjestetyn taulukon näytälle.
	b) järjestä tiedot nimi -kentän mukaan aakkosjärjestyksessä
	Ohjelma tulostaa lopuksi jarjestetyn taulukon näytolle.

	Lajittelu tulee toteuttaa siten, että se toimisi samoin
	myäs 50 tai 5000 koiran tapauksssa.
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
	cout << "Syötä koirille nimet ja iät. Ikä voi olla reaaliajassa, mutta ei kuukausina.\n\n";

	DOG dog[5000];
	DOG help;
	cout << "Montako koiraa laitetaan? ";
	cin >> con_add_dogs;
	cin.get();

	do {
		cout << "Syötä koiran nimi: ";
		cin.get(dog[amount].name, 21);
		cin.get();
		cout << "Syötä koiran ikä: ";
		cin >> ws >> dog[amount].age;
		cin.get();
		amount++;
		con_add_dogs--;
		if (con_add_dogs == 0) {
			cout << "Laitetaanko lisää koiria? y/n: ";
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

	cout << "Järjestetään koirat\n"
		<< "a) iän mukaan\n"
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