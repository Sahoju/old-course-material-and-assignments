/*************************************************
Teht‰v‰: Harjoitus 12
Kuvaus:
	Tee ohjelma, joka kysyy k‰ytt‰j‰lt‰ kokonaisluvun v‰lilt‰ 1-9 ja
	tulostaa vastauksen perusteella seuraavan kuvion (jos vastaus on 6):

	1
	22
	333
	4444
	55555
	666666

	Jokainen numero tulee tulostaa toistorakenten avulla erikseen lauseella:
	cout << rivinro;
Pvm: 27.9.2017
Ver: 1.0 SurJu
*************************************************/


#include <iostream>
#include <clocale>
using namespace std;
void main() {
	setlocale(LC_ALL, "fi-FI");
	int num;
	int rownum = 1; // rivien m‰‰r‰
	int spacenum; // v‰lien m‰‰r‰ ennen tulostettua numerosarjaa
	int i; // toistolausekkeiden laskua varten

	cout << "Syˆt‰ kokonaisluku suurempi kuin 1:\n";
	cin >> num;
	spacenum = num - 1;

	while (rownum <= num) {
		for (i = 0; i <= spacenum; i++) {
			cout << " ";
		}

		for (i = rownum + (rownum - 1); i > 0; i--) { // jokaisella rivill‰ on joulukuusen runko, jonka molemmilla puolilla on rownum - 1 m‰‰r‰ rownum numeroita
			cout << rownum;
		}

		cout << endl;
		rownum++;
		spacenum--; // v‰lien m‰‰r‰ v‰henee joka kerta, kun menn‰‰n lukua suuremmaksi
	}
}