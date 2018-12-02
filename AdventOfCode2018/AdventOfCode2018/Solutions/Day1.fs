module Day1

open FParsec
open Utils

let parseDay1Part1 input =
    let listOfIntsParser = (sepBy pint32 (pchar('\n')))
    match run listOfIntsParser input with
        | Success(result, _, _)   -> result
        | Failure(errorMsg, _, _) -> 
            printfn "Failure: %s" errorMsg
            []

let day1Part1 input = parseDay1Part1 input |> List.sum

let day1Part2 input =

    // Create an infinite sequence to work on by repeating the input, then generate a 
    // sequence of the running sum values.
    let data = repeat (parseDay1Part1 input)
    let sums = Seq.scan (fun sum current -> sum + current) 0 data

    // TODO - horrible brute force solution needs rewriting:

    let mutable repeatFound = false
    let mutable alreadySeen = []
    let mutable index = 0
    let mutable repeatValue = 0

    while repeatFound = false do
        let current = Seq.item index sums
        if List.contains current alreadySeen then 
            repeatValue <- current
            repeatFound <- true
        else
            alreadySeen <- current :: alreadySeen
            index <- index + 1

    repeatValue


