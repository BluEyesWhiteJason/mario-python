#Get input
num = int(input("Number of rows: "))


#loop to make pyramid

for row in range(num + 1):
    for space in range(num - row):
        print(" ", end = " ") 
    for hash in range(row):
        print("#", end = " ")
    print("  ", end = " ")
    for hash in range(row):
        print("#", end = " ")
    print("\n")

