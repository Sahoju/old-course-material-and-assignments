/*********************************
Harjoitus 13 (Palautus vko 43)
Kuvaus: Tee ohjelma, joka kysyy etunimesi ja sukunimesi. Ohjelma
		yhdistää nimet yhdeksi merkkijonoksi ja tulostaa ne
		lopuksi naytölle.

		a) Kayta cstring-kirjastoa (C:n merkkitaulukot)
		tehdäksesi merkkijonojen yhdistämisen
		b) Kayta string-kirjastoa (C++:n merkkijonot)
		tehdäksesi merkkijonojen yhdistämisen  TEE, JOS ON AIKAA
Pvm: 4.10.2017
Versio: 1.0 SurJu
*********************************/

#include <iostream>
#include <clocale>
#include <cstring>
#include <string>
using namespace std;
void main() {
	setlocale(LC_ALL, "fi-FI");
	char choice = 'c';
	char a_fname[11];
	char a_sname[21];
	char a_fullname[31];
	string b_fname;
	string b_sname;
	string b_fullname;

	cout << "Valitse harjoituksen 13 a tai b: ";
	cin >> choice;
	cin.get();
	choice = tolower(choice); // muuttaa käyttäjän antaman kirjaimen (choice) pieneksi
	while (choice != 'a' && choice != 'b') {
		cout << "Valitse harjoituksen 13 a tai b: ";
		cin >> choice;
		cin.get();
	}

	switch (choice) {
	case 'a':
		cout << "asd";
		cout << "Syötä etunimi: ";
		cin.get(a_fname, 11);
		cin.get();
		cout << "Syötä sukunimi: ";
		cin.get(a_sname, 21);
		cin.get();
		strcpy_s(a_fullname, a_fname);
		strcat_s(a_fullname, " ");
		strcat_s(a_fullname, a_sname);
		cout << "Nimesi on " << a_fullname << ".\n\n";
		break;

	case 'b':
		cout << "Syötä etunimi: ";
		cin >> b_fname;
		cin.get();
		cout << "Syötä sukunimi: ";
		cin >> b_sname;
		cin.get();
		b_fullname.append(b_fname);
		b_fullname.append(" ");
		b_fullname.append(b_sname);
		cout << "Nimesi on " << b_fullname << ".\n\n";
		break;
	} // switch(choice)
}

