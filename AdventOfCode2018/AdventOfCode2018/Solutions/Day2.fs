module Day2

open Parsers

// Do a count of each letter in the string, get just the counts and see if what we
// are looking for is in there.
let hasCount target string =
    Seq.toList string
    |> List.countBy (fun a -> a) 
    |> List.map snd
    |> List.contains target 

let day2Part1 input =
    let data = parseListOfStrings input '\n'
    let twos = List.fold (fun acc elem -> acc + System.Convert.ToInt32(hasCount 2 elem)) 0 data
    let threes = List.fold (fun acc elem -> acc + System.Convert.ToInt32(hasCount 3 elem)) 0 data
    twos * threes
