#include <iostream>
#include <clocale>
using namespace std;

struct HT {
	char etunimi[15];
	float matka;
	int hattu;
};

int Valikko(int);
void TulostaHenkilo(HT[], int);
void TulostaKaikkiHenkilot(HT[], int);
void LisaaHenkilo(HT[], int *);

void main() {
	setlocale(LC_ALL, "fi-FI");
	HT henkilot[5000];
	int choice = 1;
	int lkm = 0;

	while (choice != 0) {
		choice = Valikko(choice);
		switch (choice) {
			case 1:
				LisaaHenkilo(henkilot, &lkm);
				break;
			case 2:
				TulostaKaikkiHenkilot(henkilot, lkm);
				break;
		}
	}
}

int Valikko(int choice) {
	char cont_yn = 'a';

	while (cont_yn != 'y') {
		cout << "VALIKKO\n"
			<< "0 Lopeta\n"
			<< "1 Lisää henkilö\n"
			<< "2 Näytä kaikki henkilöt\n";
		cin >> choice;

		switch (choice) {
			case 0:
				while (cont_yn != 'y' && cont_yn != 'n') {
					cout << "Oletko varma? y/n\n";
					cin >> cont_yn;
					if (cont_yn == 'y') {
						cout << "Lopetetaan ohjelma. Kiitos käytöstä!\n";
						return choice;
					}
					else if (cont_yn == 'n') {
						cout << "Palataan valikkoon...\n\n";
						break;
					}
				}
			case 1:
				choice = 1;
				return choice;

			case 2:
				choice = 2;
				return choice;
		}
	}
}

void TulostaHenkilo(HT henkilot[], int lkm) {
	cout << henkilot[lkm].etunimi << endl
		<< henkilot[lkm].matka << endl
		<< henkilot[lkm].hattu << endl << endl;
}

void TulostaKaikkiHenkilot(HT henkilot[], int lkm) {
	do {
		TulostaHenkilo(henkilot, lkm);
		lkm--;
	} while (lkm >= 0);
}

void LisaaHenkilo(HT henkilot[], int *lkm) {
	cout << "Anna henkilön etunimi: ";
	cin >> henkilot[*lkm].etunimi;
	cout << "Anna henkilön koulumatkan pituus: ";
	cin >> henkilot[*lkm].matka;
	cout << "Anna henkilön hattukoko: ";
	cin >> henkilot[*lkm].hattu;
	(*lkm)++;
	cout << "Henkilö lisätty! Palataan valikkoon...\n\n";
}