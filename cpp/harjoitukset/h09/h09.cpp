/*************************************
Teht�v�: Harjoitus 9 ja 11
Tekij�: Jussi Surma-Aho
Kuvaus:
	Harjoitus 9
	Tee ohjelma, joka toimii laskimena.
	K�ytt�j�lt� kysyt��n kaksi kokonaislukua,
	jonka j�lkeen ohjelma antaa valikon
	laskutoimituksista.

	Harjoitus 11
	Muuta teht�v�n 9 laskin-ohjelmaa niin, etta
	laskimella on mahdollista k�sitell�
	useita lukupareja k�ytt�j�n toiveiden
	mukaisesti. Mita tapahtuu, jos luku2 on 0?
	HUOM! goto -lauseen k�ytt� on KIELLETTY!!!!
Pvm: 20.9.2017
Ver: 1.0 SurJu
*************************************/

#include <iostream>
#include <clocale> // mahdollistaa ��kk�set
using namespace std;
void main() {
	setlocale(LC_ALL, "fi-FI"); // mahdollistaa ��kk�set
	int int1;
	int int2;
	int choice;
	float divide;
	char exitc = 'd';
	bool exitb = false;
	bool exitb2 = false;

	while(exitb != true) {
		cout << "Sy�t� kaksi lukua: ";
		cin >> int1;
		cout << "Toinen luku: ";
		cin >> int2;

		while(exitb2 != true) {
			cout << "VALIKKO\n"
				<< "0. Lopetus\n"
				<< "1. Summa\n"
				<< "2. Erotus\n"
				<< "3. Tulo\n"
				<< "4. Osam��r�\n"
				<< "5. Jakoj��nn�s\n"
				<< "6. Sy�t� uudet luvut\n\n"
				<< "Sy�t� numero: ";
			cin >> choice;

			switch (choice) {
			case 0:
				cout << "T�m� lopettaa ohjelman. Oletko varma (y/n)? ";
				while (exitc != 'y' || exitc != 'n') { // heittomerkit char-muuttujan arvojen vertaamiseen, ei lainausmerkkej�!
						cin >> exitc;
					if (exitc == 'y') {
						exitb = true;
						exitb2 = true;
						cout << "Kiitos k�ynnist�, tervetuloa uudelleen!\n";
						break;
					}
					else if (exitc == 'n') {
						cout << "Palataan valikkoon...\n\n";
						break;
					}
					else {
						cout << "V�lill� el�m�ss� pit�� rikkoa s��nt�j� p��st�kseen eteenp�in. T�m� ei ole niit� hetki�!\n"
							<< "\"y\" eli yes vai n eli \"no\"? "; // cout-komennossa \" sallii lainausmerkkien k�yt�n!
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
				divide = (float)int1 / (float)int2; // (float) v�ltt�m�tt�mi� int-muuttujien edess� saadakseen reaaliluvun lopputulokseksi
				cout << int1 << " / " << int2 << " = " << divide << endl << endl;
				break;

			case 5:
				cout << int1 << " % " << int2 << " = " << int1 % int2 << endl << endl;
				break;

			case 6:
				cout << "Sy�t� kaksi lukua: ";
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