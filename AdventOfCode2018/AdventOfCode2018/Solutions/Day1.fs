module Day1

open FParsec

let parseDay1Part1 input =
    let listOfIntsParser = (sepBy pint32 (pchar('\n')))
    match run listOfIntsParser input with
        | Success(result, _, _)   -> result
        | Failure(errorMsg, _, _) -> 
            printfn "Failure: %s" errorMsg
            []

let day1Part1 input = parseDay1Part1 input |> List.sum
