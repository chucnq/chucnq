d = {
    "apples" : 15,
    "bananas" : 35,
    "grapes" : 12
}


# Lấy value của khóa key, trả về NA nếu key không tồn tại
# print(d.get("pears", "NA"))

# Kiểm tra sự tồn tại của key, trả về True hoặc False
# "grapes" in d

# Chuyển về list, chỉ lấy keys rồi sắp xếp
# fruits = list(d.keys())
# fruits.sort()
# print(fruits)

# Xóa key apples, rồi kiểm tra sự tồn tại
# del d["apples"]
# print("apples" in d)

def add_fruit(inventory, fruit, quanity = 0):
    inventory[fruit] = quanity
    return

new_inventory = {}
add_fruit(new_inventory, "blueberry", 25)
add_fruit(new_inventory, "papaya", 10)
add_fruit(new_inventory, "strawberries", 15)

loop_continue = True
# test find fruits
while loop_continue:
    find_fruit = input("Which fruits do you want to find?")

    if find_fruit in new_inventory:
        print(find_fruit, ":" , new_inventory[find_fruit])
        # test quanity of find_fruits
        quanity_find_fruit = int(input("Which quanity fruits do you want to buy?"))
        if new_inventory[find_fruit] > quanity_find_fruit:
            print('We have ', new_inventory[find_fruit], find_fruit, " available!")
            loop_continue = False
        else:
            print('Sorry we just have ', new_inventory[find_fruit], find_fruit, " available!")
    else:
        print(find_fruit," is not available!")







