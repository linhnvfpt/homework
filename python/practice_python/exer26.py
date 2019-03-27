game_board = [[1, 2, 0],
	     [2, 1, 0],
	     [2, 1, 1]]

winner_is_2 = [[2, 0, 2],
	      [2, 1, 0],
	      [2, 1, 1]]

winner_is_1 = [[1, 2, 0],
	      [2, 2, 2],
	      [2, 1, 1]]

also_no_winner = [[1, 2, 0],
	         [2, 1, 0],
	         [2, 1, 0]]

size_board = 3

# check element duplicate in list
def check_element_duplicate(array_list):
    lst = [row for row in array_list
           if row.count(1) == size_board or row.count(2) == size_board]
    if len(lst) != 0:
        return True
    else:
        return False

# check row full 1' or 2'
def check_row_win(matrix):
    return check_element_duplicate(matrix)
    
# check colum full 1' or 2'
def check_colum_win(matrix):
    # get array of columns
    count = 0
    list_columns = []
    while count < size_board:
       column = [row[count] for row in matrix]
       list_columns.append(column)
       count += 1
    return check_element_duplicate(list_columns)
    
# check diagonal
def check_diagonal_win(matrix):
    diagonal_1 = [row[i] for i,row in enumerate(matrix)]
    diagonal_2 = [row[-i-1] for i,row in enumerate(matrix)]
    list_diagonal = []
    list_diagonal.append(diagonal_1)
    list_diagonal.append(diagonal_2)
    return check_element_duplicate(list_diagonal)
    
# when user pick, then check win
def check_player_win(matrix):
    if check_row_win(matrix) or check_colum_win(matrix) or check_diagonal_win(matrix):
        return True
    else:
        return False
    
def check_win_game(game_board):
    if check_player_win(game_board):
        print("You win game.")
    else:
        print("You don't win game.")

check_win_game(game_board)
check_win_game(winner_is_2)
check_win_game(winner_is_1)
check_win_game(also_no_winner)
