# Make a two-player Rock-Paper-Scissors game.
#(Hint: Ask for player plays (using input), compare them, print out a message of congratulations to the winner,
# and ask if the players want to start a new game)

#Remember the rules:

    #Rock beats scissors
    #Scissors beats paper
    #Paper beats rock

game = ["Rock","Paper","Scissors"]
print("This is a two-player Rock-Paper-Scissors game.")
print("Use R for Rock.")
print("Use P for Paper.")
print("Use S for Scissors.")
print("Use Q for quit game.")
print("Start: ")
p = "A"
pp = "B"
while p != "Q" and pp != "Q":
  p = input("Player 1, please enter Rock,Paper, or Scissors : ")
  if p == "Q":
      print("Player 1 : exit game.")
      break
  if p != "R" and p != "P" and p != "S":
      print("Player 1 input a invalid value.")
      continue
    
  pp = input("Player 2, please enter Rock,Paper or Scissors : ")
  if pp == 'Q':
      print("Player 2 : exit game.")
      break
  if pp != "R" and pp != "P" and pp != "S":
      print("Player 2 input a invalid value.")
      continue
    
  if p == pp:
    print("Players Equal!")
  elif p == "R" and pp == "P":
    print("P2 wins")
  elif p == "P" and pp == "S":
    print("P2 wins")
  elif p == "S" and pp == "R":
    print("P2 wins")
  elif pp == "R" and p == "P":
    print("P1 wins")
  elif pp == "P" and p == "S":
    print("P1 wins")
  elif pp == "S" and p == "R":
    print("P1 wins")
