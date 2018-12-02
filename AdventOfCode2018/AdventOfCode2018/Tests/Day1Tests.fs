module Day1Tests

open NUnit.Framework
open Utils
open Day1

[<TestFixture>]
type ``Day 1 Part 1``() =

    [<TestCase("+1\n-2\n+3\n+1", 3)>]
    [<TestCase("+1\n+1\n+1", 3)>]
    [<TestCase("+1\n+1\n-2", 0)>]
    [<TestCase("-1\n-2\n-3", -6)>]
    member this.``can process sample input``(input, expected) =
        let result = day1Part1 input
        Assert.AreEqual(expected, result) 
    
    [<Test>]
    member this.``can process puzzle input``() =
        let day1Input = readFile "Input/Day1.txt"
        let result = day1Part1 day1Input
        Assert.AreEqual(466, result)

[<TestFixture>]
type ``Day 1 Part 2``() =

    [<TestCase("+1\n-2\n+3\n+1", 2)>]
    [<TestCase("+1\n-1", 0)>]
    [<TestCase("+3\n+3\n+4\n-2\n-4", 10)>]
    [<TestCase("-6\n+3\n+8\n+5\n-6", 5)>]
    [<TestCase("+7\n+7\n-2\n-7\n-4", 14)>]
    member this.``can process sample input``(input, expected) =
        let result = day1Part2 input
        Assert.AreEqual(expected, result) 

    [<Test>]
    member this.``can process puzzle input``() =
        let day1Input = readFile "Input/Day1.txt"
        let result = day1Part2 day1Input
        Assert.AreEqual(750, result)