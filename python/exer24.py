# draw line --- --- ---
def DrawLineHorizonal(size):
    x = "-"
    drawLineFirst = (size - 1) * (" " + 3 * x)
    drawLineLast = " " + 3 * x + " "
    print(drawLineFirst + drawLineLast)

# draw line |   |   |   |
def DrawLineVertical(size):
    y = " "
    drawVerticalFirst = (size - 1) * ("|"+ 3 * y)
    drawVerticalLast = "|" + 3 * y + "|"
    print(drawVerticalFirst + drawVerticalLast)

def DrawGameBoards(size):
    i = 0
    while i < size:
        DrawLineHorizonal(size)
        DrawLineVertical(size)
        i += 1
    DrawLineHorizonal(size)

size = int(input("Input size game board: "))
DrawGameBoards(size)


