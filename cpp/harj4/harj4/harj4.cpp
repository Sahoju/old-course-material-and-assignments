#include <iostream>
using namespace std;
#define MINIMI 10 // vanha, ei-suositeltava tapa määrittää vakio
const int MAKSIMI = 20; // nykyään käytetty vakion määritys
int summa; // määrittää muuttujan "summa"
void Laske(int, int); // kutsuu aliohjelman "Laske"
void main() {
	int luku1 = 2; // määrittää muuttujan "luku1" ja antaa sille arvon 2
	int luku2; // määrittää muuttujan "luku2"
	cout << "Syötä luku, joka lisätään numeroon 2: ";
	cin >> luku2; // mahdollistaa käyttäjän syötön. käyttäjän syöttämä arvo (numero) menee muuttujan "luku2" arvoksi 
	Laske(luku1, luku2); // kutsuu aliohjelman "Laske"
	if (summa < MINIMI)
		cout << "Summa on pienempi kuin " << MINIMI << "\n";
	if (summa > MAKSIMI)
		cout << "Summa on suurempi kuin " << MAKSIMI << "\n";
	if (summa > MINIMI && summa < MAKSIMI) // && == ja-merkki
		cout << "Summa on " << MINIMI << ":n ja " << MAKSIMI << ":n välissä\n";
}

void Laske(int eka, int toka) { // aliohjelman "Laske" määritys
	summa = eka + toka;
}