namespace Tests

open NUnit.Framework
open FsUnit
open Library.Year2018

[<Year2018>]
type Year2018 () =

    [<Test>]
    member this.day01 () =
        day01a ["+1"; "+1"; "-2"] |> should equal 0
