module Main

let name args = 
    if Array.isEmpty args 
    then "World" 
    else args.[0]

[<EntryPoint>]
let main argv =
    printfn "Hello %s from F#!" <| name argv
    0
