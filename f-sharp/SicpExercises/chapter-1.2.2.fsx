// Chapter 1.2.2 notes

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

    cc amount 5

countChange 100