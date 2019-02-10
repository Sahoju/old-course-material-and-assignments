# Write a function vowels that is a given a string
# and it returns the number of vowels in that string.
# To keep things simple, do not include ö, ä and å.

def Vowels(stuff):
    stuff = stuff.lower() # makes all the letters lowercase, no need to check for both a and A for example
    count = 0
    for i in stuff:
        if(i=='a'):
            count += 1
        if(i=='i'):
            count += 1
        if(i=='u'):
            count += 1
        if(i=='e'):
            count += 1
        if(i=='o'):
            count += 1
    print(count)

stuff = "sAippUakauppiAs"
Vowels(stuff)
