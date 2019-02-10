/*************************************
Tehtävä: Harjoitus 8a
Tekijä: Jussi Surma-Aho
Kuvaus:
	Tee ohjelma, joka tulostaa annetut kolme lukua suuruus-
	järjestyksessä (pienimmästä suurimpaan) näytölle
	(katso harj. 1 suunnitelma)
	a) käytä kokonaislukuja
Pvm: 20.9.2017
Ver: 1.0 SurJu
*************************************/

#include <iostream>
using namespace std;
void main() {
	int l1;
	int l2;
	int l3;

	cout << "Syota kolme lukua (paina Enteria jokaisen luvun jalkeen): ";
	cin >> l1 >> l2 >> l3;

	if (l1 > l2) {
		if (l1 > l3) {
			if (l2 > l3) {
				cout << "Lukusi suuruusjarjestyksessa: " << l1 << " " << l2 << " " << l3 << endl;
			}
			else {
				cout << "Lukusi suuruusjarjestyksessa: " << l1 << " " << l3 << " " << l2 << endl;
			}
		}
		else {
			cout << "Lukusi suuruusjarjestyksessa: " << l3 << " " << l1 << " " << l2 << endl;
		}
	}
	else if (l2 > l3) {
		if (l1 > l3) {
			cout << "Lukusi suuruusjarjestyksessa: " << l2 << " " << l1 << " " << l3 << endl;
		}
		else {
			cout << "Lukusi suuruusjarjestyksessa: " << l2 << " " << l3 << " " << l1 << endl;
		}
	}
	else {
		cout << "Lukusi suuruusjarjestyksessa: " << l3 << " " << l2 << " " << l1 << endl;
	}
}