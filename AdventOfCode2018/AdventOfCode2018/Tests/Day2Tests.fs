module Day2Tests

open NUnit.Framework
open Day2
open System.Text

[<TestFixture>]
type ``Day 2 Part 1``() =

    [<Test>]
    member this.``can process sample input``() =

        let input = new StringBuilder()
        input.AppendLine("abcdef") |> ignore
        input.AppendLine("bababc") |> ignore
        input.AppendLine("abbcde") |> ignore
        input.AppendLine("abcccd") |> ignore
        input.AppendLine("aabcdd") |> ignore
        input.AppendLine("abcdee") |> ignore
        input.AppendLine("ababab") |> ignore

        let result = day2Part1 (input.ToString())
        Assert.AreEqual(12, result) 