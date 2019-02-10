/*************************************
Teht„v„: Harjoitus 8b
Tekij„: Jussi Surma-Aho
Kuvaus:
	Tee ohjelma, joka tulostaa annetut kolme lukua suuruus-
	j„rjestyksess„ (pienimm„st„ suurimpaan) n„yt”lle
	(katso harj. 1 suunnitelma)
	b) k„yt„ liukulukuja (=reaalilukuja)
Pvm: 20.9.2017
Ver: 1.0 SurJu
*************************************/

#include <iostream>
#include <clocale>
using namespace std;
void main() {
	setlocale(LC_ALL, "fi-FI");
	float l1;
	float l2;
	float l3;

	cout << "Sy”t„ kolme lukua (paina Enteria jokaisen luvun j„lkeen): ";
	cin >> l1 >> l2 >> l3;

	if (l1 > l2) {
		if (l1 > l3) {
			if (l2 > l3) {
				cout << "Lukusi suuruusj„rjestyksess„: " << l1 << " " << l2 << " " << l3 << endl;
			}
			else {
				cout << "Lukusi suuruusj„rjestyksess„: " << l1 << " " << l3 << " " << l2 << endl;
			}
		}
		else {
			cout << "Lukusi suuruusj„rjestyksess„: " << l3 << " " << l1 << " " << l2 << endl;
		}
	}
	else if (l2 > l3) {
		if (l1 > l3) {
			cout << "Lukusi suuruusj„rjestyksess„: " << l2 << " " << l1 << " " << l3 << endl;
		}
		else {
			cout << "Lukusi suuruusj„rjestyksess„: " << l2 << " " << l3 << " " << l1 << endl;
		}
	}
	else {
		cout << "Lukusi suuruusj„rjestyksess„: " << l3 << " " << l2 << " " << l1 << endl;
	}
}

