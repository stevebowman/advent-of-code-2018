module Utils

open System.Diagnostics

let printResult result time title = 
    printf "%s Result: %A \n" title result 
    printf "%s Elapsed Time: %i ms \n" title time 

let timeThis f input =
    let stopWatch = Stopwatch.StartNew()
    let result = f input
    stopWatch.Stop()
    result, stopWatch.ElapsedMilliseconds

let timeAndPrintResult f input title = 
    let result, time = timeThis f input
    (result, time, title) |||> printResult

let readFile fileName =
    System.IO.File.ReadAllText(fileName)

// Infinitely repeat a sequence.
let rec repeat items = 
  seq { yield! items  
        yield! repeat items }