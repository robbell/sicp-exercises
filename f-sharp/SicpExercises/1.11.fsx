// Exercise 1.11





let countChange amount = 
    let firstDenomination kindsOfCoins = 
        match kindsOfCoins  with
        | 1 -> 1
        | 2 -> 5
        | 3 -> 10
        | 4 -> 25
        | _ -> 50
        
    let rec cc amount kindsOfCoins = 
        if amount = 0 then 1
        else if amount < 0 || kindsOfCoins = 0 then 0
        else cc amount (kindsOfCoins - 1) + cc (amount - (firstDenomination kindsOfCoins)) kindsOfCoins

    cc amount 1

countChange 2


(cc 5 2)
(cc 5 1 + cc (5 - 5) 2)
(cc 5 1 + cc 0 2)
((cc 5 0 + cc (5 - 1) 1) + 1)
((cc 5 0 + cc 4 1) + 1)
((0 + cc 4 1) + 1)
((0 + (cc 4 0 + cc (4 - 1) 1)) + 1)
((0 + (cc 4 0 + cc 3 1)) + 1)
((0 + (0 + (cc 3 0) + cc (3 - 1) 1)) + 1)
((0 + (0 + (cc 3 0) + cc 2 1)) + 1)
((0 + (0 + 0 + cc 2 1)) + 1)
((0 + (0 + 0 + cc 2 1)) + 1)



20 - 1 5 10

1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1
1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 5
1 1 1 1 1 1 1 1 1 1 5 5
1 1 1 1 1 5 5 5
5 5 5 5

1 1 1 1 1 1 1 1 1 1 10
10 10
5 5 10
1 1 1 1 1 5 10

10

1 1 1 1 1 1 1 1 1 1
10
5 5
1 1 1 1 1 5


cc 10 2


// 10 with 1 5 10

// 1 1 1 1 1 1 1 1 1 1
// 1 1 1 1 1 5
// 5 5

// 10