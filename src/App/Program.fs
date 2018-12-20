open System
open System.Collections
open Library

[<EntryPoint>]
let main argv =

    let run program =
        match program with
        | "day01a" -> Year2018.day01a "World!"
        | p -> printfn "Problem %s not found!" p

    run (Array.head argv)
    0
