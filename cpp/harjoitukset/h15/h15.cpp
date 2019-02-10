/***********************************************
Tehtävä: Harjoitus 15
Kuvaus:
	Tee ohjelma, joka kysyy henkilötietosi seuraavasti:
	Anna (kaikki) etunimesi (merkkijono):
	Anna kengannumero (kokonaisluku):
	Anna sukunimi (merkkijono):
	Anna koulumatka (reaaliluku):
	Anna osoitteesi:
	Anna postinumero:

	Ohjelma tulostaa tiedot seuraavasti:
	sukunimi etunimet
	osoite
	postinumero
	kengannumero ja koulumatka

	Käytä C++:n cin- ja cout-olioita ohjelman toteuttamiseen.
Pvm: 25.10.2017
Ver: 1.0 SurJu
***********************************************/

#include <iostream>
#include <clocale>
using namespace std;
void main() {
	setlocale(LC_ALL, "fi-FI");
	struct YT {
		char firstname[51];
		int shoesize;
		char surname[51];
		float triplength;
		char address[51];
		int postnum;
	};

	YT yhteystiedot;

	cout << "Anna kaikki etunimesi: \n";
	cin.get(yhteystiedot.firstname, 51);
	cin.get();
	cout << "\nAnna kengännumerosi: \n";
	cin >> yhteystiedot.shoesize;
	cin.get();
	cout << "\nAnna sukunimesi: \n";
	cin.get(yhteystiedot.surname, 51);
	cin.get();
	cout << "\nAnna koulumatkasi pituus: \n";
	cin >> yhteystiedot.triplength;
	cin.get();
	cout << "\nAnna osoitteesi: \n";
	cin.get(yhteystiedot.address, 51);
	cin.get();
	cout << "\nAnna postinumerosi: \n";
	cin >> yhteystiedot.postnum;
	cin.get();

	cout << endl << yhteystiedot.firstname << " " << yhteystiedot.surname << endl
		<< yhteystiedot.address << endl
		<< yhteystiedot.postnum << endl
		<< yhteystiedot.shoesize << " " << yhteystiedot.triplength << " km" << endl;
}