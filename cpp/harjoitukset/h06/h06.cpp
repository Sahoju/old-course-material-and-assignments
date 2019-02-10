#include <iostream>
using namespace std;
void main() {
	int paaoma;
	const int lihapiirakka = 4;

	cout << "Olet ostamassa lihapiirakkaa. Paljonko sinulla on rahaa?\n";
	cin >> paaoma;

	if (paaoma - lihapiirakka == 1) {
		cout << "Ostit lihapiirakan! Sinulle jai viela euro taskuun. Silla voi vaikka ostaa kylkiaiseksi euron burgerin.\n";
	}
	else if (paaoma > lihapiirakka && paaoma < 50) {
		cout << "Ostit lihapiirakan! Sinulle jai viela " << paaoma - lihapiirakka << " euroa taskuun.\n";
	}
	else if (paaoma >= 50 && paaoma < 500) {
		cout << "Ostit lihapiirakan! Sinulle jai viela " << paaoma - lihapiirakka << " euroa lompakkoon.\n";
	}
	else if (paaoma >= 500) {
		cout << "Kuka ostaa lihapiirakan noin isolla rahalla!? Joka tapauksessa ostit lihapiirakan, mutta seuraavalla kerralla voisit ostaa vaikka tryffeleita. Sinulle jai nimittain viela " << paaoma - lihapiirakka << " euroa kullalla paallystettyyn lompakkoosi.\n";
	}
	else if (paaoma == lihapiirakka) {
		cout << "Ostit lihapiirakan! Siihen meni kaikki rahat, mutta ainakin sinulla on lihapiirakka.\n";
	}
	else {
		cout << "Sinulla ei ole tarpeeksi rahaa lihapiirakkaan! Miksi tassa kaupassa ei nay hintoja!?\n";
	}
}