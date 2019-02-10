# Make a function called "compareNumbers" which takes two parameters,
# compares them and returns the greater number.

def CompareNumbers(num1, num2):
    if num1 > num2:
        return print(num1, "is bigger than", num2)
    else:
        return print(num2, "is bigger than", num1)

num1 = input("Give number one: ")
num2 = input("Give number two: ")
CompareNumbers(num1, num2)
