#include <iostream>
using namespace std;
int main()
{
	int luku[5] = { 2,4,5,6,7 };
	int *osoitin; // t�hdet kertovat osoittimen
	osoitin = &luku[0]; // osoite alustetaan
	cout << "\nLuku-muuttujan osoite on: " << osoitin;
	cout << "\nLuku-muuttujan osoite on: " << &luku[0];
	cout << "\nLuku-muuttujan sis�lt� on: " << *osoitin;
	cout << "\nLuku-muuttujan sis�lt� on: " << luku[0];
	osoitin = &luku[1];
	cout << "\nLuku-muuttujan osoite on: " << osoitin;
	cout << "\nLuku-muuttujan osoite on: " << &luku[1];
	cout << "\nLuku-muuttujan sis�lt� on: " << *osoitin;
	cout << "\nLuku-muuttujan sis�lt� on: " << luku[1];
	osoitin++; // osoitin osoittaa taulukon luku[2] paikkaa
	cout << "\nLuku-muuttujan osoite on: " << osoitin;
	cout << "\nLuku-muuttujan osoite on: " << &luku[2];
	cout << "\nLuku-muuttujan sis�lt� on: " << *osoitin;
	cout << "\nLuku-muuttujan sis�lt� on: " << luku[2];

	cout << "\nLuku-muuttujan osoite on: " << osoitin + 1;
	cout << "\nLuku-muuttujan osoite on: " << &luku[3];
	cout << "\nLuku-muuttujan sis�lt� on: " << *(osoitin + 1);
	cout << "\nLuku-muuttujan sis�lt� on: " << luku[3];

	cout << "\nLuku-muuttujan osoite on: " << osoitin + 2;
	cout << "\nLuku-muuttujan osoite on: " << &luku[4];
	cout << "\nLuku-muuttujan sis�lt� on: " << osoitin[2];
	cout << "\nLuku-muuttujan sis�lt� on: " << luku[4];
	return 0;
}