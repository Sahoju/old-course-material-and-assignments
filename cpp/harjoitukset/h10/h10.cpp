/**********************************************
Teht�v�: Harjoitus 10
Kuvaus:
	Tee ohjelma, joka laskee sy�tetyist� kokonaisluvuista sek� positiivisten
	ett� negatiivisten kokonaislukujen osuuden. Lukujen sy�tt� lopetetaan
	sy�tt�m�ll� luku 0.
Pvm: 27.9.2017
Ver: 1.0 SurJu
**********************************************/

#include <iostream>
#include <clocale>
using namespace std;

void main() {
	setlocale(LC_ALL, "fi-FI");
	int num = 1;
	int pos = 0;
	int neg = 0;
	int sum = 0;

	cout << "Sy�t� kokonaislukuja niin paljon kuin haluat. Lopeta sy�tt� nollalla. Paina enteri� jokaisen numeron j�lkeen.\n";

	while (num != 0) {
		cin >> num;
		if (num > 0) {
			pos++;
			sum++;
		}
		else if (num < 0){
			neg++;
			sum++;
		}
	}

	cout << "\n\nSy�tt�si tulokset: \n"
		<< "Positiivisia lukuja oli " << (float)pos / (float)sum * 100 << "%.\n"
		<< "Negatiivisia lukuja oli " << (float)neg / (float)sum * 100 << "%.\n"
		<< "Yhteens� kaikkia lukuja oli 100%.\n"
		<< "Nollia oli yksi kappale. Mit� luulit?\n";
} // void main()