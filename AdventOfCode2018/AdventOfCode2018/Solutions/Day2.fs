module Day2

open Parsers

let parseDay2Input input = parseListOfStrings input '\n'

// Do a count of each letter in the string, get just the counts and see if what we
// are looking for is in there.
let hasCount target string =
    Seq.toList string
    |> List.countBy (fun a -> a) 
    |> List.map snd
    |> List.contains target 

let hasOnlyOneCharDifference string1 string2 =

    // Turn the 2 strings into arrays of characters
    let chars1 = parseStringOfChars string1
    let chars2 = parseStringOfChars string2

    // Get the individual character differences.
    let combined = List.zip chars1 chars2 
    let diffs = List.filter (fun (a, b) -> a <> b) combined

    // If we have exactly 1 difference then get the characters in common
    // and form them back into a string, and return it.
    if List.length diffs = 1 then 
        let inCommon = List.filter (fun (a, b) -> a = b) combined
        let inCommonString = new string [|for c in inCommon -> fst c|]
        Some(inCommonString)
    else 
        None

let day2Part1 input =
    let data = parseDay2Input input
    let twos = List.fold (fun acc elem -> acc + System.Convert.ToInt32(hasCount 2 elem)) 0 data
    let threes = List.fold (fun acc elem -> acc + System.Convert.ToInt32(hasCount 3 elem)) 0 data
    twos * threes

let day2Part2 input =
    let data = parseDay2Input input
    List.tryPick (fun x -> List.tryPick (fun y -> hasOnlyOneCharDifference x y) data) data |> Option.get
