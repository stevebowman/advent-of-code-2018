module Day1

open Parsers
open Utils

let findRepeat sequence =

    // TODO - horrible brute force solution needs rewriting:

    let mutable repeatFound = false
    let mutable alreadySeen = []
    let mutable index = 0
    let mutable repeatValue = 0

    while repeatFound = false do
        let current = Seq.item index sequence
        if List.contains current alreadySeen then 
            repeatValue <- current
            repeatFound <- true
        else
            alreadySeen <- current :: alreadySeen
            index <- index + 1

    repeatValue

let parseDay1Input input = parseListOfInts input '\n'

let day1Part1 input = input |> parseDay1Input |> List.sum

let day1Part2 input =

    // Create an infinite sequence to work on by repeating the input, then generate a 
    // sequence of the running sum values.
    input
    |> parseDay1Input
    |> repeat
    |> Seq.scan (fun sum current -> sum + current) 0 
    |> findRepeat