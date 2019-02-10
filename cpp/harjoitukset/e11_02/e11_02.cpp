/* #include <iostream>
using namespace std;
#include "pvm.h"
int main()
{
	PVM *pvm = NULL; // tiedet‰‰n, ettei ole mit‰‰n j‰rkev‰‰ osoitetta
	pvm = new PVM; // varataan dynaamisesti tila tietueelle
	if (pvm) // testataan saatiinko tila varattua. sama kuin pvm != NULL
	{
		cout << "Syˆt‰ pp kk vv ";
		cin >> pvm->pp >> pvm->kk >> pvm->vv;
		cout << "Pvm on: " << pvm->pp << "/";
		cout << pvm->kk << "/" << pvm->vv;
	}
	else
		cout << "Tilanvaraus ep‰onnistui";
	delete pvm;
	return 0;
} */

/* #include <iostream>
using namespace std;
int main()
{
	int *luku_osoitin1 = NULL;
	int vastaus, laskuri = 0;
	cout << "\nMontako lukua varataan ? ";
	cin >> vastaus;
	luku_osoitin1 = new int[vastaus];
	if (luku_osoitin1)
	{
		for (laskuri = 0; laskuri < vastaus; laskuri++)
		{
			cout << "\nLuku ?";
			cin >> luku_osoitin1[laskuri];
		}
		for (laskuri = 0; laskuri < vastaus; laskuri++)
		{
			cout << "\nLuku: " << luku_osoitin1[laskuri];
			cout << " osoitteessa: " << &luku_osoitin1[laskuri];
		}
	}
	else
		cout << "\nTilanvaraus ep‰onnistui";
	delete[] luku_osoitin1;
	luku_osoitin1 = NULL; // ettei vahingossakaan tule deletoitua kahteen kertaan. se kaataa koneen
	return 0;
} */

#include <iostream>
using namespace std;
struct Alkio
{
	int luku;
	Alkio *seuraava; // wot
};
int KysyValinta();
int main()
{
	Alkio *alku = NULL; // m‰‰ritell‰‰n alkio alku tyhj‰ksi, joka on osoitin
	Alkio *kohdalla, *uusi; // m‰‰ritell‰‰n osoitin alkiot
	int vastaus;
	vastaus = KysyValinta();
	while (vastaus != 0)
	{
		switch (vastaus)
		{
		case 1: uusi = new Alkio; // varataan dynaamisesti tila tietueelle
			if (uusi)
			{
				cout << "\nLuku: ";
				cin >> uusi->luku;
				uusi->seuraava = NULL;
				if (!alku)
					alku = uusi;
				else
				{
					kohdalla = alku;
					while (kohdalla->seuraava)
						kohdalla = kohdalla->seuraava;
					kohdalla->seuraava = uusi;
				}
			}
			else
				cout << "\nTilanvaraus ep‰onnistui";
			break;
		case 2: kohdalla = alku;
			while (kohdalla)
			{
				cout << "\nLuku: " << kohdalla->luku;
				cout << " osoite: " << &kohdalla->luku;
				kohdalla = kohdalla->seuraava;
			}
			break;
		default: cout << "\nVirheellinen valinta";
		}
		vastaus = KysyValinta();
	}
	Alkio *seuraava;
	kohdalla = alku;
	while (kohdalla)
	{
		seuraava = kohdalla->seuraava;
		delete kohdalla;
		kohdalla = seuraava;
	}
	return 0;
}
int KysyValinta()
{
	int vastaus;
	cout << "\nVALIKKO";
	cout << "\n1) Lis‰‰ uusi luku";
	cout << "\n2) N‰yt‰ kaikki luvut";
	cout << "\n0) Lopetus\n";
	cin >> vastaus;
	return vastaus;
}



