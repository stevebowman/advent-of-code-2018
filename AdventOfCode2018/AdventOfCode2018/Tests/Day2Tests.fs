module Day2Tests

open NUnit.Framework
open Utils
open Day2

[<TestFixture>]
type ``Day 2 Part 1``() =

    [<Test>]
    member this.``can process sample input``() =

        let input = "abcdef\nbababc\nabbcde\nabcccd\naabcdd\nabcdee\nababab"
        let result = day2Part1 input
        Assert.AreEqual(12, result) 

    [<Test>]
    member this.``can process puzzle input``() =
        let day2Input = readFile "Input/Day2.txt"
        let result = day2Part1 day2Input
        Assert.AreEqual(5704, result)