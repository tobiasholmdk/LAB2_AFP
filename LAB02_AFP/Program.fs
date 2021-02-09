// Queen Attack Exercise in F#

// Tobias Holm
// 08-02-2021

open System

let create (col, row) =
    col >= 0 && col < 7 && row >= 0 && row < 7

let canAttack (col1, row1) (col2, row2) =
    row1 = row2
    || col1 = col2
    || Math.Abs(int row1 - row2) = Math.Abs(int col1 - col2)

[<EntryPoint>]
let main argv =
    // Methods for testing
    Console.WriteLine("Create (2,2) : {0}", create (2, 2))
    Console.WriteLine("Create (-2,-2) : {0}", create (-2, -2))
    Console.WriteLine("Create (8,2) : {0}", create (8, 2))
    Console.WriteLine("Create (7,7) : {0}", create (7, 7))
    Console.WriteLine("Create (3,8) : {0}", create (3, 8))

    Console.WriteLine("canAttack(2,4) (6,6): {0}", canAttack (2, 4) (6, 6))
    Console.WriteLine("canAttack(2,4) (2,6): {0}", canAttack (2, 4) (2, 6))
    Console.WriteLine("canAttack(4,4) (2,4): {0}", canAttack (4, 4) (2, 4))
    Console.WriteLine("canAttack(2,2) (0,4): {0}", canAttack (2, 2) (0, 4))
    Console.WriteLine("canAttack(2,2) (3,1): {0}", canAttack (2, 2) (3, 1))

    0 // return an integer exit code