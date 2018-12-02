module Parsers

open FParsec

let runParser parser input =
    match run parser input with
        | Success(result, _, _)   -> result
        | Failure(errorMsg, _, _) -> 
            printfn "Failure: %s" errorMsg
            []

let parseListOfInts input separator =
    let parser = (sepBy pint32 (pchar(separator)))
    runParser parser input

let parseListOfStrings input separator =
    let str : Parser<_,_> = many1Chars (noneOf [separator])
    let sep = pchar separator
    let parser = sepBy str sep
    runParser parser input

let parseStringOfChars input = 
    let parser = many anyChar
    runParser parser input