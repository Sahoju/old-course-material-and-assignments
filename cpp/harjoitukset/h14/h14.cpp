/***************************************
Harjoitus 14
Kuvaus: Ohjelmassa!
Pvm: 4.10.2017
Versio: 1.0 SurJu
***************************************/

#include <iostream>
#include <clocale>
#include <cstring>
using namespace std;

void main() {
	setlocale(LC_ALL, "fi-FI");
	char shrt_a[18];
	char shrt_b[18];
	char lng[101];
	char lng_c[101];
	char choice;
	int lngth;
	int lngth_b = 0;
	int i = 0;

	do {
		cout << "Valitse harjoitus 14:sta a, b tai c: ";
		cin >> choice;
		cin.get();
	} while (choice != 'a' && choice != 'b' && choice != 'c');

	switch (choice) {
	case('a'):
		cout << "Tehtävänanto:\n"
			<< "\"Tee ohjelma, joka kysyy käyttäjältä 17 merkkiä"
			<< "pitkän merkkijonon(ei välilyäntejä).\"\n"
			<< "a) Ohjelma tulostaa merkkijonon käänteisessä järjestyksessä näytälle\n"
			<< "(tulostus tyyppiä \"cout << mjono1[4];\" jne)\n\n"
			<< "Kirjoita jokin sana. Maksimissaan 17 merkkiä, ei välilyöntejä! ";
		cin.get(shrt_a, 18);
		cin.get();

		for (lngth = strlen(shrt_a) - 1; lngth >= 0; lngth--) {
			cout << shrt_a[lngth];
		}
		cout << endl;
		break;
	case('b'):
		cout << "Tehtävänanto:\n"
			<< "\"Tee ohjelma, joka kysyy käyttäjältä 17 merkkiä"
			<< "pitkän merkkijonon(ei välilyäntejä).\"\n"
			<< "b) Ohjelma kääntää annetun merkkijonon toiseen\n"
			<< "merkkijonoon ja tulostaa sen näytälle\n"
			<< "(tulostus tyyppiä \"cout << mjono2;\")\n"
			<< "Kirjoita jokin sana. Maksimissaan 17 merkkiä, ei välilyöntejä! ";
		cin.get(shrt_a, 18);
		cin.get();

		for (lngth = strlen(shrt_a) - 1; lngth >= 0; lngth--) {
			shrt_b[lngth_b] = shrt_a[lngth];
			lngth_b++;
		}

		shrt_b[strlen(shrt_a)] = 0;
		cout << shrt_b << endl;

		break;
	case('c'):
		cout << "c) merkkijono voi olla kuinka pitkä\n"
			<< "tahansa(max 100 kirjainta).\n"
			<< "Syätetyn merkkijonon pituutta ei saa\n"
			<< "laskea millään kirjastofunktiolla\n"
			<< "(esim.lenght tms.) Ohjelma\n"
			<< "tutkii onko annettu merkkijono\n"
			<< "palindromi ja ilmoittaa sen käyttäjälle.\n"
			<< "Välilyännit jonossa ovat sallittuja.\n"
			<< "Kirjoita jokin sana tai lause. Maksimissaan 100 merkkiä, välilyönnit sallittu!\n";
		cin.get(lng, 101);
		cin.get();

		for (lngth = 0; lng[lngth] != 0; lngth++) {}
		for (lngth_b = 0; lngth_b < lngth; lngth_b++) {
			lng_c[i] = lng[lngth_b];
			if (lng[lngth_b] != ' ') {
				i++;
			}
		}

		lng_c[i] = '\0';
		lngth -= 1;
		i -= 1;
		lngth_b = 0;

		while (i >= 0) {
			if (lng_c[i] == lng_c[lngth_b]) {
				i--;
				lngth_b++;
				continue;
			}
			else {
				cout << "Antamasi merkkijono ei ole palindromi. :(\n";
				break;
			}
		}

		if (lngth_b == strlen(lng_c)) {
			cout << "Antamasi merkkijono on palindromi! Hip hip hurraa.\n";
		}

		break;
	} // switch(choice)
}