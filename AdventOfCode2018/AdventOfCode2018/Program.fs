// Learn more about F# at http://fsharp.org

open System
open Utils
open Day1

[<EntryPoint>]
let main argv =
    printfn "Advent Of Code 2018"

    let day1Part1Input = readFile "Input/Day1Part1.txt"
    timeAndPrintResult day1Part1 day1Part1Input "Day 1 Part 1"
    timeAndPrintResult day1Part2 day1Part1Input "Day 1 Part 2"

    Console.ReadKey() |> ignore

    0 
