#include <iostream>
using namespace std;
#define MINIMI 10 // vanha, ei-suositeltava tapa m��ritt�� vakio
const int MAKSIMI = 20; // nyky��n k�ytetty vakion m��ritys
int summa; // m��ritt�� muuttujan "summa"
void Laske(int, int); // kutsuu aliohjelman "Laske"
void main() {
	int luku1 = 2; // m��ritt�� muuttujan "luku1" ja antaa sille arvon 2
	int luku2; // m��ritt�� muuttujan "luku2"
	cout << "Sy�t� luku, joka lis�t��n numeroon 2: ";
	cin >> luku2; // mahdollistaa k�ytt�j�n sy�t�n. k�ytt�j�n sy�tt�m� arvo (numero) menee muuttujan "luku2" arvoksi 
	Laske(luku1, luku2); // kutsuu aliohjelman "Laske"
	if (summa < MINIMI)
		cout << "Summa on pienempi kuin " << MINIMI << "\n";
	if (summa > MAKSIMI)
		cout << "Summa on suurempi kuin " << MAKSIMI << "\n";
	if (summa > MINIMI && summa < MAKSIMI) // && == ja-merkki
		cout << "Summa on " << MINIMI << ":n ja " << MAKSIMI << ":n v�liss�\n";
}

void Laske(int eka, int toka) { // aliohjelman "Laske" m��ritys
	summa = eka + toka;
}