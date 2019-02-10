/* #include <iostream>
using namespace std;
void Korota(int); //esittely
int main()
{
	int luku;
	cout << "\nSyˆt‰ jokin kokonaisluku: ";
	cin >> luku;
	Korota(luku); // kutsu
	cout << "\nP‰‰ohjelman luku on: " << luku;
	return 0;
}
void Korota(int p_luku) // m‰‰rittely
{
	p_luku = p_luku * p_luku;
	cout << "\nLuku * luku: " << p_luku;
} */

/* #include <iostream>
using namespace std;
void Korota(int *); //esittely, * = osoitin
int main()
{
	int luku;
	cout << "\nSyˆt‰ jokin kokonaisluku: ";
	cin >> luku;
	Korota(&luku); // luku-muuttujan osoite
	cout << "\nLuku *luku: " << luku;
	return 0;
}
void Korota(int *p_luku) // osoittaa luku-muuttujaan
{
	*p_luku = (*p_luku) * (*p_luku);
} */

/* #include <iostream>
using namespace std;
int Korota(int); //esittely
int main()
{
	int luku, tulos;
	cout << "\nSyˆt‰ jokin kokonaisluku: ";
	cin >> luku;
	tulos = Korota(luku);
	cout << "\nLuku * luku: " << tulos;
	return 0;
}
int Korota(int p_luku)
{
	return(p_luku * p_luku);
} */

/* #include <iostream>
using namespace std;
#include "pvm.h"
void Nayta(PVM);
int main()
{
	PVM tietue;
	cout << "\nSyˆt‰ p‰iv‰m‰‰r‰ muodossa pp kk vv: ";
	cin >> tietue.pp >> tietue.kk >> tietue.vv;
	Nayta(tietue);
	return 0;
}
void Nayta(PVM p_tietue)
{
	cout << "\nP‰iv‰m‰‰r‰ on: ";
	cout << p_tietue.pp << "." << p_tietue.kk << "." << p_tietue.vv;
} */

/* #include <iostream>
using namespace std;
#include "pvm.h"
void Kysy(PVM *); // * = osoitin, pointer
int main()
{
	PVM tietue;
	Kysy(&tietue); // & = muuttujan osoite, address
	cout << "\nP‰iv‰m‰‰r‰ on: ";
	cout << tietue.pp << "." << tietue.kk << "." << tietue.vv;
	return 0;
}
void Kysy(PVM *p_tietue) // osoite otetaan vastaan osoittimeen
{
	cout << "\nSyˆt‰ p‰iv‰m‰‰r‰ muodossa pp kk vv: ";
	cin >> p_tietue->pp >> p_tietue->kk >> (*p_tietue).vv;
} */

/* #include <iostream>
using namespace std;
#include "pvm.h"
PVM Kysy();
int main()
{
	PVM tietue;
	tietue = Kysy();
	cout << "\nP‰iv‰m‰‰r‰ on: ";
	cout << tietue.pp << "." << tietue.kk << "." << tietue.vv;
	return 0;
}
PVM Kysy()
{
	PVM p_tietue;
	cout << "\nSyˆt‰ p‰iv‰m‰‰r‰ muodossa pp kk vv: ";
	cin >> p_tietue.pp >> p_tietue.kk >> p_tietue.vv;
	return p_tietue;
} */

/* #include <iostream>
using namespace std;
#include "pvm.h"
PVM *Kysy();
int main()
{
	PVM *tietue;
	tietue = Kysy();
	cout << "\nP‰iv‰m‰‰r‰ on: ";
	cout << tietue->pp << "." << tietue->kk << "." << tietue->vv;
	return 0;
}
PVM *Kysy()
{
	static PVM p_tietue; // static varaa p_tietue-tietueen osoitteen
	cout << "\nSyˆt‰ p‰iv‰m‰‰r‰ muodossa pp kk vv: ";
	cin >> p_tietue.pp >> p_tietue.kk >> p_tietue.vv;
	return &p_tietue; // jos static arvoa ei olisi, p_tietue menett‰isi osoitteensa ja sen tilalle tulisi jotain muuta tilalle
} */

#include <iostream>
using namespace std;
// void Kysy(int[], int lkm);
void Kysy(int *p_taulu, int lkm); // ylempi rivi on lyhennetty versio t‰st‰
int main()
{
	int ind;
	int taulu[5];
	// Kysy(taulu, 5); // l‰hett‰‰ taulu-taulukon osoitteen
	Kysy(&taulu[0], 5); // ylempi rivi on lyhennetty versio t‰st‰
	for (ind = 0; ind < 5; ind++)
		cout << "\n" << taulu[ind];
	return 0;
}
// void Kysy(int p_taulu[], int lkm)
void Kysy(int *p_taulu, int lkm) // ylempi rivi on sama lyhennettyn‰
{
	for (int ind = 0; ind < lkm; ind++)
	{
		cout << "Syˆt‰ luku: ";
		cin >> p_taulu[ind]; // tieto talletetaan saadun parametrin osoitteeseen, eli taulu-taulukon
	}
}





