def NameErrorHandling(a, b):
    try:
        print(a + b + c)
    except NameError:
        print("Variable c does not exist!")

def IndexErrorHandling(a):
    try:
        print(a[5])
    except IndexError:
        print("Requested index was out of range!")

def KeyErrorHandling(a):
    try:
        print(a['c'])
    except KeyError:
        print("Requested key was not found!")

NameErrorHandling(5,2)
IndexErrorHandling([0, 1, 2, 3])
KeyErrorHandling({'a':0, 'b':1})


