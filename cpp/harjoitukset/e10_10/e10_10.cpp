#include <fstream>
#include <iostream>
using namespace std;
#include "pvm.h"
void Nayta(PVM);
int main()
{
	PVM tietue;
	ifstream lue("tiedot.txt");
	if (lue.is_open()) {
		while (lue.peek() != EOF) {
			lue >> tietue.pp >> tietue.kk >> tietue.vv;
			lue.get(); // luetaan rivinvaihto roskiin
			cout << tietue.pp << "." << tietue.kk << "." << tietue.vv << endl;
		}
		lue.close();
	}
	else {
		cout << "\nSyötä päivämäärä muodossa pp kk vv: ";
		cin >> tietue.pp >> tietue.kk >> tietue.vv;
	}
	Nayta(tietue);
	return 0;
}
void Nayta(PVM p_tietue)
{
	cout << "\nPäivämäärä on: ";
	cout << p_tietue.pp << "." << p_tietue.kk << "." << p_tietue.vv;
	ofstream kirjoita("tiedot.txt");
	kirjoita << p_tietue.pp << " " << p_tietue.kk << " " << p_tietue.vv << endl;
	kirjoita << p_tietue.pp+1 << " " << p_tietue.kk+1 << " " << p_tietue.vv+1 << endl;
	kirjoita.close();
}

