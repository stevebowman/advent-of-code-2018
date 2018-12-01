// Learn more about F# at http://fsharp.org

open System
open Utils
open Day1

[<EntryPoint>]
let main argv =
    printfn "Advent Of Code 2018"

    timeAndPrintResult day1Part1 10 "Day 1 Part 1"

    Console.ReadKey() |> ignore

    0 
