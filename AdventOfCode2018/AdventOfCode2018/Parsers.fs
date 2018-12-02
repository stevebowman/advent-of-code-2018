module Parsers

open FParsec
open Utils

let parseListOfInts input separator =
    let listOfIntsParser = (sepBy pint32 (pchar(separator)))
    match run listOfIntsParser input with
        | Success(result, _, _)   -> result
        | Failure(errorMsg, _, _) -> 
            printfn "Failure: %s" errorMsg
            []

let parseListOfStrings input separator =

    let str : Parser<_,_> = many1Chars (noneOf [separator])
    let sep = pchar separator
    let parser = sepBy str sep

    match run parser input with
        | Success(result, _, _)   -> result
        | Failure(errorMsg, _, _) -> 
            printfn "Failure: %s" errorMsg
            []

let parseStringOfChars input = 
    let parser = many anyChar
    match run parser input with
        | Success(result, _, _)   -> result
        | Failure(errorMsg, _, _) -> 
            printfn "Failure: %s" errorMsg
            []