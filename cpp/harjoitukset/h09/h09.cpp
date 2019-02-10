/*************************************
Tehtävä: Harjoitus 9 ja 11
Tekijä: Jussi Surma-Aho
Kuvaus:
	Harjoitus 9
	Tee ohjelma, joka toimii laskimena.
	Käyttäjältä kysytään kaksi kokonaislukua,
	jonka jälkeen ohjelma antaa valikon
	laskutoimituksista.

	Harjoitus 11
	Muuta tehtävän 9 laskin-ohjelmaa niin, etta
	laskimella on mahdollista käsitellä
	useita lukupareja käyttäjän toiveiden
	mukaisesti. Mita tapahtuu, jos luku2 on 0?
	HUOM! goto -lauseen käyttä on KIELLETTY!!!!
Pvm: 20.9.2017
Ver: 1.0 SurJu
*************************************/

#include <iostream>
#include <clocale> // mahdollistaa ääkköset
using namespace std;
void main() {
	setlocale(LC_ALL, "fi-FI"); // mahdollistaa ääkköset
	int int1;
	int int2;
	int choice;
	float divide;
	char exitc = 'd';
	bool exitb = false;
	bool exitb2 = false;

	while(exitb != true) {
		cout << "Syötä kaksi lukua: ";
		cin >> int1;
		cout << "Toinen luku: ";
		cin >> int2;

		while(exitb2 != true) {
			cout << "VALIKKO\n"
				<< "0. Lopetus\n"
				<< "1. Summa\n"
				<< "2. Erotus\n"
				<< "3. Tulo\n"
				<< "4. Osamäärä\n"
				<< "5. Jakojäännös\n"
				<< "6. Syötä uudet luvut\n\n"
				<< "Syötä numero: ";
			cin >> choice;

			switch (choice) {
			case 0:
				cout << "Tämä lopettaa ohjelman. Oletko varma (y/n)? ";
				while (exitc != 'y' || exitc != 'n') { // heittomerkit char-muuttujan arvojen vertaamiseen, ei lainausmerkkejä!
						cin >> exitc;
					if (exitc == 'y') {
						exitb = true;
						exitb2 = true;
						cout << "Kiitos käynnistä, tervetuloa uudelleen!\n";
						break;
					}
					else if (exitc == 'n') {
						cout << "Palataan valikkoon...\n\n";
						break;
					}
					else {
						cout << "Välillä elämässä pitää rikkoa sääntöjä päästäkseen eteenpäin. Tämä ei ole niitä hetkiä!\n"
							<< "\"y\" eli yes vai n eli \"no\"? "; // cout-komennossa \" sallii lainausmerkkien käytön!
					}
				} // while (exitc != 'y' || exitc != 'n')
				break;

			case 1:
				cout << int1 << " + " << int2 << " = " << int1 + int2 << endl << endl;
				break;

			case 2:
				cout << int1 << " - " << int2 << " = " << int1 - int2 << endl << endl;
				break;

			case 3:
				cout << int1 << " * " << int2 << " = " << int1 * int2 << endl << endl;
				break;

			case 4:
				if (int2 == 0) {
					cout << "Nollalla ei voi jakaa!\n\n";
					break;
				}
				divide = (float)int1 / (float)int2; // (float) välttämättömiä int-muuttujien edessä saadakseen reaaliluvun lopputulokseksi
				cout << int1 << " / " << int2 << " = " << divide << endl << endl;
				break;

			case 5:
				cout << int1 << " % " << int2 << " = " << int1 % int2 << endl << endl;
				break;

			case 6:
				cout << "Syötä kaksi lukua: ";
				cin >> int1;
				cout << "Toinen luku: ";
				cin >> int2;
				break;

			default:
				break;
			} // switch
		} // while(choice != 0)
	} // while(exitb != true)
} // main