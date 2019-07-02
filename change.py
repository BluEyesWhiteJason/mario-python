change = float(input("How much change is owed? "))

#Define coins
quarters = 0
dimes = 0
nickels = 0
pennies = 0

#Whittle down the number, add coins
while change > 0:
    if change >= .25:
        change -= .25
        quarters += 1
    elif change < .25 and change > .09:
        change -= .10
        dimes += 1
    elif change < .10 and change > .04:
        change -= .05
        nickels += 1
    else:
        change -= .01
        pennies += 1

#print
print(f"Quarters: {quarters}")
print(f"Dimes: {dimes}")
print(f"Nickels: {nickels}")
print(f"Pennies: {pennies}")
