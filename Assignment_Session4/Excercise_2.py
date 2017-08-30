prices = {
    "banana" : 4,
    "apple" : 2,
    "orange" : 1.5,
    "pear" : 3
}

purchased_items = {
    "banana" : 5,
    "orange" : 3
}

total = 0

for key in purchased_items:
    print(key,end=",")
    print(" quanity: ", purchased_items[key],end=",")
    print(" unit price: ",prices[key])
    total += purchased_items[key]*prices[key]

print(total)




