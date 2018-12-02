module Day2Tests

open NUnit.Framework
open Day2

[<TestFixture>]
type ``Day 2 Part 1``() =

    [<Test>]
    member this.``can process sample input``() =

        let input = "abcdef\nbababc\nabbcde\nabcccd\naabcdd\nabcdee\nababab"
        let result = day2Part1 input
        Assert.AreEqual(12, result) 