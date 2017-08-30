inventory = {
    "gold" : 500,
    "pouch" : ['flint', 'twine', 'gemstone'],
    "backpack" : ['xylophone', 'dagger', 'bedroll', 'bread loaf']
}


# add key 'pocket' , set the value of 'pocket'
inventory["pocket"] = ['seashell', 'strange berry', 'lint']


# sort the list stored under the 'backpack' key
inventory["backpack"].sort()

# remove('dagger') from the list stored under the 'backpack' key
inventory["backpack"].remove("dagger")
print(inventory["backpack"])

# Add 50 to the number stored under the 'gold' key
inventory["gold"] += 50
print(inventory["gold"])