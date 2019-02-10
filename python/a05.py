for i in range(0, 10):
    if i == 0 or i == 9:
        for i in range(0, 20):
            if i == 0 or i == 19:
                if i == 0:
                    print("+", end='') # end='' is for not including EOL
                else:
                    print("+")
            else:
                print("-", end='')
    else:
        for i in range(0, 20):
            if i == 0 or i == 19:
                if i == 0:
                    print("|", end='') # end='' is for not including EOL
                else:
                    print("|")
            else:
                print(".", end='')


