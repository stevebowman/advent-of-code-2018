module Day1

open Parsers
open Utils

let parseDay1Input input = parseListOfInts input '\n'

let day1Part1 input = input |> parseDay1Input |> List.sum

let day1Part2 input =

    // Using a standard .NET list is much faster than creating a mutable F# list
    // and then appending to it each time.
    let alreadySeenSums = new System.Collections.Generic.List<int>()

    let isAlreadySeen value =
        if alreadySeenSums.Contains(value) then 
            Some(value)
        else
            alreadySeenSums.Add(value)
            None

    // Create an infinite sequence to work on by repeating the input, then generate a 
    // sequence of the running sum values. Get the first duplicate sum value from that list.
    input
    |> parseDay1Input
    |> repeat
    |> Seq.scan (fun sum current -> sum + current) 0 
    |> Seq.tryPick isAlreadySeen
    |> Option.get 
   