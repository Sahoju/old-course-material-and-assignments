#include <iostream>
using namespace std;
int KysyValinta();
double Korota(int, int);
int main()
{
	int valinta;
	int kanta, eksp;
	double vastaus;
	valinta = KysyValinta();
	while (valinta != 0)
	{
		if (valinta == 1)
		{
			cout << "\nSyötä kantaluku: ";
			cin >> kanta;
			cout << "\nSyötä eksponentti: ";
			cin >> eksp;
			vastaus = Korota(kanta, eksp);
			cout << "\nVastaus on: " << vastaus;
		}
		else
			cout << "\nKo. valintaa ei ole";
		valinta = KysyValinta();
	}
	return 0;
}
int KysyValinta()
{
	int valinta;
	cout << "\nLUVUN KOROTUS POTENSSIIN";
	cout << "\n\n1) Korota luku potenssiin";
	cout << "\n0) Lopeta";
	cout << "\nValintasi: ";
	cin >> valinta;
	return valinta;
}
double Korota(int kanta, int eksp)
{
	double tulo;
	int laskuri;
	if (eksp == 0)
		tulo = 1;
	else
		if (eksp > 0)
		{
			tulo = kanta;
			for (laskuri = 1; laskuri < eksp; laskuri++)
				tulo *= kanta;
		}
		else
		{
			tulo = 1 / double(kanta);
			for (laskuri = -1; laskuri > eksp; laskuri--)
				tulo = tulo * 1 / double(kanta);
		}
	return tulo;
}

