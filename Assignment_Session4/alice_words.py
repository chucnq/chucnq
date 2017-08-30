from urllib import request

f = open("alice_words.txt","w")

url = "http://www.gutenberg.org/cache/epub/19033/pg19033.txt"
alice_content =  request.urlopen(url).read().decode("utf-8")

alice_words = str(alice_content)

single_string =  alice_words.split("")

letter_counts = {}


for char in single_string:
    var2 = char.find('"')
    var3 = char.find('"')
    ans = char[var2+1: var3]
    letter_counts[char] = letter_counts.get(char, 0 ) + 1



# print(letter_counts)

letter_items = list(letter_counts.items())
letter_items.sort()




i = 0
# Do letter_key là nhiều list nằm trong một list
print("Word","\t\t","Count")
print("==================")
for i in range(len(letter_items)):
    print(letter_items[i][0], end="\t")
    print(letter_items[i][1])
    i += 1



