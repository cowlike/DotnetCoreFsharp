module Tests

open Xunit
open Swensen.Unquote
open Main

[<Fact>]
let ``My test`` () =
    Assert.True(true)

[<Fact>]
let ``Main test`` () =
    main [||] =! 0

[<Fact>]
let ``empty args returns World`` () =
    name [||] =! "World"

[<Fact>]
let ``non-empty args returns first element`` () =
    name [|"foo"|] =! "foo"
