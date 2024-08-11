module Structures

[<Struct>]
type Contact = {
    Name: string;
    Surname: string;
    Phone: uint
}

// Как я понял, инициализировать экземпляр структуры
// надо как-то так

let mother: Contact = {
    Name = "Mommy"; 
    Surname = ""; 
    Phone = 10234u
}

// Первое впечатление: ЧТОЗАх... ЗДЕСЬ произошла...
// Второе впечатление: member используется для обозначений членов класса
[<Class>]
type ContactBook = 
    member this.objectOrientedMother: Contact = {
        Name = "";
        Surname = "";
        Phone = 108478233u
    }