string = input('Write everything you want!')

letters_counts = {}
# Đếm letter xuất hiện trong string
for letter in string:
    letters_counts[letter] = letters_counts.get(letter, 0 ) + 1

# print(letters_counts)

# Chuyển về list, rồi sắp xếp
letter_key = list(letters_counts.items())
letter_key.sort()


i = 0
# Do letter_key là nhiều list nằm trong một list
for i in range(len(letter_key)):
    print(letter_key[i][0], end=" ")
    print(letter_key[i][1])
    i += 1



