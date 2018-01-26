// Exercise 1.12

let rec pascalsTriangle row col = 
    if col = 0 || row = col then 1
    else pascalsTriangle (row - 1) (col - 1) + pascalsTriangle (row - 1) col

pascalsTriangle 8 3
