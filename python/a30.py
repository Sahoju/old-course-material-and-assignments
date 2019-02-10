add = lambda x,y: float(x)+float(y)
sub = lambda x,y: float(x)-float(y)
mul = lambda x,y: float(x)*float(y)
div = lambda x,y: float(x)/float(y)

def menu(choice):
    choice = 0
    print("1. Add")
    print("2. Subtract")
    print("3. Multiply")
    print("4. Divide")
    print("5. Exit")
    
    while (choice <= 0 or choice >= 6):
        choice = input("CHOOSE YOUR HOLY RELIC: ")
        if (choice <= 0 or choice >= 6):
            print("THOU SHALT BE PURGED!!")
            
    return choice

choice = 0

while(choice != 5):
    num1 = 'a'
    num2 = 'b'

    choice = menu(choice)

    if(choice == 5):
        print("FARE THEE WELL")
        break;

    # isinstance checks if given variable is a given type
    while not (isinstance(num1, (int, float))):
        try:
            num1 = input("GIVE US A NUMBER: ")
        except NameError:
            print("THAT IS NOT A NUMBER")

    while not (isinstance(num2, (int, float))):
        try:
            num2 = input("GIVE US AN ANOTHER NUMBER: ")
        except NameError:
            print("THAT IS NOT A NUMBER")

    if(choice == 1):
        print("{0} + {1} = {2}\n".format(num1, num2, add(num1, num2)))
    elif(choice == 2):
        print("{0} + {1} = {2}\n".format(num1, num2, sub(num1, num2)))
    elif(choice == 3):
        print("{0} + {1} = {2}\n".format(num1, num2, mul(num1, num2)))
    elif(choice == 4):
        print("{0} + {1} = {2}\n".format(num1, num2, div(num1, num2)))
    else:
        print("SINNER!\n")
