# Write a function called symbols that takes a string
# containing +, = and letters. The function should
# return True if all of the letters in the string
# are surrounded by a + symbol.

def IsSurroundedBy(stuff):
    plusopen = False
    
    for i in stuff:
        if i == '+' and plusopen == False:
            plusopen = True
        elif i == '+' and plusopen == True:
            plusopen = False
        if i.isalpha():
            if plusopen == False:
                print(i, "is missing a + from its left side!")
                return False
    if plusopen == True:
        print(i, "is missing a + from its right side!")
        return False
    else:
        print("Everything is alright!")

IsSurroundedBy("+a+")
IsSurroundedBy("+a")
IsSurroundedBy("a+")
IsSurroundedBy("+a+a+")
IsSurroundedBy("+=========a===========+")
