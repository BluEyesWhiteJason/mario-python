import sys

if len(sys.argv) != 2:
    print("Wrong number of arguments")

#Convert CLA to int
num = int(sys.argv[1])

#Get string to be encoded
sword = input("Enter string: ")


#loop to change nums
for i in sword:
    newWord[i] = chr(ord(sword[i]) + num)

#Print result
print(newWord)



