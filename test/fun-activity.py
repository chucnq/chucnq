from turtle import *

ki = Turtle()

ki.color("black")
ki.speed(-1)

size = 5

for i in range(99):
    ki.fillcolor(127,127,65)
    ki.begin_fill()
    for i in range(4):
        ki.forward(size)
        ki.left(90)
    ki.end_fill()
    ki.left(7)
    ki.forward(5)
    size = size + 7