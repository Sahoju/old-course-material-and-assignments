/*************************************
Teht�v�: Harjoitus 7
Tekij�: Jussi Surma-Aho
Kuvaus:
	Tee ohjelma, joka kysyy k�ytt�j�lt� nimen, pituuden senttein� ja painon kiloina.
	Ohjelma laskee ja tulostaa k�ytt�j�n ihannepainon (pituus-100). Lis�ksi
	ohjelma kertoo k�ytt�j�n nykyisen painon eron kiloina verrattuna ihanne-
	painoon.
Pvm: 13.9.2017
Ver: 1.0 SurJu
*************************************/

#include <iostream>
using namespace std;
void main() {
	char nimi[32];
	char osoite[64];
	double korkeus;
	double paino;

	cout << "Anna nimesi: ";
	cin.get(nimi, 32);
	cout << endl << "Anna osoitteesi: ";
	cin.get();
	cin.get(osoite, 64);
	cout << endl << "Anna korkeutesi: ";
	cin >> korkeus;
	cout << endl << "Anna painosi: ";
	cin >> paino;

	double ihannepaino = korkeus - 100.0;

	cout << endl << endl << "Arvoisa " << nimi << ",\n"
		<< "Osoitteenne on " << osoite << ".\n"
		<< "Painatte " << paino << " kiloa.\n"
		<< "Korkeimmat tutkijat ovat hyvaksyneet taman kaavan ihmisen ihannepainon laskemiseen: korkeus - 100.\n"
		<< "Taten voimme laskea, etta Teidan ihannepainonne on " << ihannepaino << ".\n";
	
	if (paino - ihannepaino > 0) {
		cout << "Teidan on viela laihdutettava " << paino - ihannepaino << " kiloa saavuttaaksenne ihannepainonne. Suosittelen syomaan enemman kasviksia ja liikkumaan enemman.\n";
	}
	else if (paino == ihannepaino){
		cout << "Olette tasmalleen ihannepainossanne! Mestarini ei tarvitse huolehtia yli- tai alipainoisuudesta. Olen ylpea Teista!\n";
	}
	else {
		cout << "Olette " << -1 * (paino - ihannepaino) << " kiloa alle ihannepainonne. Teidan olisi syyta lihottaa hieman. Miten olisi paivittaisten aterioidenne maaran lisaaminen?\n";
	}


}