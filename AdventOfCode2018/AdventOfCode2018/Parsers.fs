module Parsers

open FParsec

let parseListOfInts input separator =
    let listOfIntsParser = (sepBy pint32 (pchar(separator)))
    match run listOfIntsParser input with
        | Success(result, _, _)   -> result
        | Failure(errorMsg, _, _) -> 
            printfn "Failure: %s" errorMsg
            []