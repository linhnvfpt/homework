# draw line --- --- ---
def draw_line_horizonal(size):
    x = "-"
    draw_line_first = (size - 1) * (" " + 3 * x)
    draw_line_last = " " + 3 * x + " "
    print(draw_line_first + draw_line_last)

# draw line |   |   |   |
def draw_line_vertical(size):
    y = " "
    draw_vertical_first = (size - 1) * ("|"+ 3 * y)
    draw_vertical_last = "|" + 3 * y + "|"
    print(draw_vertical_first + draw_vertical_last)

def draw_game_boards(size):
    i = 0
    while i < size:
        draw_line_horizonal(size)
        draw_line_vertical(size)
        i += 1
    draw_line_horizonal(size)

size = int(input("Input size game board: "))
draw_game_boards(size)


