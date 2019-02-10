import countryData

def iterate():
    for x in countryData.countries:
        print(x)
        for y in countryData.countries[x]:
            print('\t', y, ':', end=' ')
            if y != "population":
                 print(countryData.countries[x][y][0], ", who is", countryData.countries[x][y][1], "years old")
            elif y == "population":
                print(countryData.countries[x][y])

