numbers = { 25, 1, 52, 85, 93, 44, 17, 36, 12, 94, 4, 27, 89, 99, 49, 22, 58, 43, 29, 91 }

for number in numbers:
    divisibleBySelf = True

    for ch in str(number):
        if number % int(ch) != 0:
            divisibleBySelf = False
    
    if divisibleBySelf == True:
        print(number)