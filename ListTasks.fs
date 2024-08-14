// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp
// See the 'F# Tutorial' project for more help.

// Define a function to construct a message to print
open System

/// <summary>
/// Task #1 
/// Reverse char array
/// </summary>
/// <param name="arg"></param>
let backList (arg: 'a list) = 
    [for i in arg.Length..0 do yield arg.[i]]
        |> Seq.toList


/// <summary>
/// Task #2
/// Head/Tail replacement
/// </summary>
/// <param name="arg2"></param>
let tailHeadReplace (arg2: 'a list) = 
    [arg2.Tail]
        |> List.append [for i in 1..arg2.Length-1 -> [arg2.[i]]]
        |> List.append [[arg2.Head]]
    

/// <summary>
/// Task #3
/// Converting ??? some data to data-list
/// </summary>
/// <param name="arr"></param>
let toList (arr: 'a[]): 'a list = 
    arr |> Seq.toList  


/// <summary>
/// Task #4
/// Returns divide result of max value and sum of values in list
/// </summary>
/// <param name="lst"></param>
let nickFunc (lst: int list) =
    let max = lst |> List.max
    let len = lst |> List.length
    max / len


/// <summary>
/// Task #5
/// Returns list sorted 
/// </summary>
/// <param name="l"></param>
let listSort (l: int list) = 
    l |> List.sortBy(fun x -> abs(x))


[<EntryPoint>]
let main (argv:string[]) =
    0


