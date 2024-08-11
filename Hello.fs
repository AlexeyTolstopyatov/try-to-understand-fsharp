module Hello // Похоже, это что-то вроде пространства имен

open System

[<EntryPoint>]
let main =
    printfn "Say your name." 
    printf ">> My name is: "

    let name: string = Console.ReadLine()
    let mutable exit: bool = false 

    while exit do
        if name.Length > 0 then
            printfn "Hi, %s" name
            exit <- true
        else
            printfn "Your name is so short... "

    0 // ok??????