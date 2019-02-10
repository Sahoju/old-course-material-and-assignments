/**********************************************
Tehtävä: Harjoitus 10
Kuvaus:
	Tee ohjelma, joka laskee syötetyistä kokonaisluvuista sekä positiivisten
	että negatiivisten kokonaislukujen osuuden. Lukujen syöttä lopetetaan
	syöttämällä luku 0.
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

	cout << "Syötä kokonaislukuja niin paljon kuin haluat. Lopeta syöttö nollalla. Paina enteriä jokaisen numeron jälkeen.\n";

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

	cout << "\n\nSyöttösi tulokset: \n"
		<< "Positiivisia lukuja oli " << (float)pos / (float)sum * 100 << "%.\n"
		<< "Negatiivisia lukuja oli " << (float)neg / (float)sum * 100 << "%.\n"
		<< "Yhteensä kaikkia lukuja oli 100%.\n"
		<< "Nollia oli yksi kappale. Mitä luulit?\n";
} // void main()