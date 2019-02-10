# Make a function which takes two parameters,
# sums them up and checks if the sum is divisible by 2.
# If it is print "Yes it is!" and if not "Nope." (tip: %)

def SumIsDivisible(num1, num2):
    sumsum = int(num1) + int(num2) # for some reason the script gives a string formatting error if it's just num1 + num2...
    if sumsum % 2 == 0:
        print("The sum of the numbers is divisible by two!")
    else:
        print("The sum of the numbers is not divisible by two.")

int1 = input("Give number one: ")
int2 = input("Give number two: ")
SumIsDivisible(int1, int2)
