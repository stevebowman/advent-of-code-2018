// Learn more about F# at http://fsharp.org

open System
open Utils
open Day1

[<EntryPoint>]
let main argv =

    printfn "Advent Of Code 2018"

    while true do 

        printfn "\nWhich day would you like to run? (q to quit):"

        match Console.ReadLine().Trim() with
        | "1" ->
            let day1Part1Input = readFile "Input/Day1Part1.txt"
            timeAndPrintResult day1Part1 day1Part1Input "Day 1 Part 1"
            timeAndPrintResult day1Part2 day1Part1Input "Day 1 Part 2"
    
        | "q" | "Q" -> exit 0

        | _ -> printfn "Day does not exist"

    0 
