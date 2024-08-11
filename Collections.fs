module Collections

// Создать список со случайными значениями
open System

let rand: Random = System.Random()
let rints =
    [0..100] 
    |> List.map(rand.Next)
    |> Seq.truncate(10)
    

// Я офигел когда увидел, что возможно такое....
let rword (n: int): string = 
    string([ for _ in 1..n -> Random().Next(0, 10) + 97 ]) 

let people = seq {
    "Tom" ;
    "Sam";
    "Alex";
    "Brian"
}

let sortedPeople = Seq.sort(people)
for p in sortedPeople do printf $"{p} "

let str:string = rword(10)
