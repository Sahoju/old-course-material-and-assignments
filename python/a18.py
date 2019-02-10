# this file includes assignments 18, 19 and 20

def division(x, y):
    try:
        return x/y
    except ZeroDivisionError:
        print("Can not divide by zero!")
        return
    except TypeError:
        print("One or both of your parameters are wrong type! Please insert numbers")
        return

try:
    print(division(8, 2))
except TypeError:
    print("Two arguments are required for function division, no more, no less.")

