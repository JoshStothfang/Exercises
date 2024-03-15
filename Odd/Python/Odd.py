numbers = { 25, 1, 52, 85, 93, 44, 17, 36, 12, 94, 4, 27, 89, 99, 49, 22, 12, 36, 58, 43, 29, 91, 4 }

oddNumbers = list()

for number in numbers:
    if number % 2 != 0:
        oddNumbers.append(number)

for oddNumber in oddNumbers:
    print(oddNumber)
