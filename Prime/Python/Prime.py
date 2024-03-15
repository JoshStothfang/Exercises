startNum = 2
endNum = 100

for i in range(startNum, endNum + 1):
    prime = True
    for j in range(2, i):
        if i % j == 0:
            prime = False
            break
    if prime == True:
        print(i)
