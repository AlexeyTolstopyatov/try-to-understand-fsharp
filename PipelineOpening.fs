module PipelineOpening

// Возводит число во вторую степень
let getsq (x: int): int = 
    x * x

// Создает новую коллекцию чисел
// Возведенных во вторую степень и ссумирует их
// Возвращает сумму всех чисел в коллекции
let squares =   
    [1..10]             // Массив элементов (от 1 до 10)
    |> List.map(getsq)  // Возведение в квадрат каждого элемента массива
    |> List.sum         // Сумма всех элементов массива.

printf ("%d") (squares)

// Усложнение задачи.

// *** LINQ vs F# ***
//  LINQ	      F#
//  Where	    filter
//  Select	    map
//  GroupBy	    groupBy
//  SelectMany	collect
//  Aggregate	fold или reduce
//  Sum	        sum

// Возвращает сумму всех квадратов в списке с 1 до значения колличества
// 
let getss (count: int): int =
    [1..count]                  // Массив (от 1 до count)
    |> List.map (getsq)         // возведение в квадрат с помощью getsq
    |> List.append [count + 1]  // Добавление нового элемента в список
    |> List.sum                 // Сумма всех элементов в списке

