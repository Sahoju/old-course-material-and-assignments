#include <iostream>
using namespace std;
struct PVM
{
	int pp, kk, vv;
};
int main()
{
	PVM pvm1 = { 1, 1, 1996 };
	PVM pvm2;
	cout << "\nMonesko p�iv� t�n��n on "
		"(sy�t� muodossa 99 99 99)?\n";
	cin >> ws >> pvm2.pp >> ws >> pvm2.kk >> ws >> pvm2.vv; // ws = poistetaan whitespacet, mit� on sy�tetty
	cout << "\nVuoden ensimm�inen p�iv� on: ";
	cout << pvm1.pp << '.' << pvm1.kk << '.' << pvm1.vv;
	cout << "\nT�n��n on: " << pvm2.pp << '.' << pvm2.kk << '.' << pvm2.vv;
	return 0;
}


