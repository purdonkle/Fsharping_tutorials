// Learn more about F# at http://fsharp.org

open System

let parseUnits = function
    | 0 -> ""
    | 1 -> "one"
    | 2 -> "two"
    | 3 -> "three"
    | 4 -> "four"
    | 5 -> "five"
    | 6 -> "six"
    | 7 -> "seven"
    | 8 -> "eight"
    | 9 -> "nine"
    | _ -> failwith "I expected a single digit"

let tensName n = 
    n % 

let parseTens n = 
    let tens = (n % 100) / 10
    let units = n % 10
    match tens with
    | 0 -> parseUnits units
    | 1 ->
        match units with
        | 0 -> "ten"
        | 1 -> "eleven"
        | 2 -> "twelve"
        | 3 -> "thirteen"
        | 4 -> "fourteen"
        | 5 -> "fifteen"
        | 6 -> "sixteen"
        | 7 -> "seventeen"
        | 8 -> "eightteen" 
        | 9 -> "nineteen"
        | _ ->
            failwith "Units cannot be > 9"
    | n -> 
        sprintf "%s %s" (tensName n) (parseUnits units)      

[<EntryPoint>]
let main argv =
    printfn "%f" 45.0 
    0 // return an integer exit code
