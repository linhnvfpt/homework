def drawLineAbove(size, drawTime):
    x = "-"
    if drawTime < size - 1:
        drawLine = " " + size * x
    else:
        drawLine = size * x + " "
    print(drawLine)

def drawLineVertical(size,drawTime):
    y = " "
    if drawTime < size - 1:
        drawLine = "|"+ size * y
    else:
        drawLine = size * y + "|"
    print(drawLine)

def drawLineLast(size):
    x = "-"
    print(size *(" " + size * x + " "))

def drawGameBoards(size):
    i = 0
    while i < size:
        drawLineAbove(size,i)
        drawLineVertical(size,i)
        i += 1
    drawLineLast(size)

size = int(input("Input size game board: "))
drawGameBoards(size)


