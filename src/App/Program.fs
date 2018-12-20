open System
open System.Collections
open Library.Year2018
open Library.Utils

[<EntryPoint>]
let main argv =

    let run program =
        match program with
        | "day01a" -> printfn "%i" (day01a (readInput "input/2018/day01"))
        | p -> printfn "Problem %s not found!" p

    run (Array.head argv)
    0
