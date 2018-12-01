module Day1Tests

open NUnit.Framework
open Day1

[<TestFixture>]
type ``Day 1 Part 1``() =

    [<TestCase("+1\n-2\n+3\n+1", 3)>]
    [<TestCase("+1\n+1\n+1", 3)>]
    [<TestCase("+1\n+1\n-2", 0)>]
    [<TestCase("-1\n-2\n-3", -6)>]
    member this.``can parse sample input``(input, expected) =
        let result = day1Part1 input
        Assert.AreEqual(expected, result) 