//factorial example without patterns
let rec fact n =
    if n = 0 then 1
    else n * fact(n-1)

//factorial with pattern matching
let rec factPM n =
    match n with
    | 0 -> 1
    | _ -> n * factPM(n-1)

//Reverse without Patterns
let rec reverse L =
    if L = [] then []
    else reverse L.Tail@[L.Head];;

//reverse with patterns
let rec reversePM L =
    match L with
    | [] -> []
    | h::t -> reversePM(t) @ [h]

//guard example
let f x y =
    match (x,y) with
    | (a,b) when (a=b) -> "="
    | (a,b) -> "!="

//fib

let rec fib n =
    match n with
    | 0 | 1 -> 1
    | n -> fib (n-1) + fib (n-2)

//Patterns using In

let rec halve L =
    match L with
    | [] -> ([], [])
    | h::[] -> ([h], [])
    | a::b::cs -> 
        (a::fst (halve cs), b::snd (halve cs))

//halve with in
let rec halveIn L =
    match L with 
    | [] -> ([], [])
    | a::[] -> ([a], [])
    | a::b::cs ->
        let (x,y) = halveIn (cs)
        in
        (a::x, b::y)

//merge sort -> merges two sorted lists
let rec merge (L: int list * int list) =
    match L with
    | ([], ys) -> ys
    | (xs, []) -> xs
    | (x::xs, y::ys) when x < y ->
        x::merge (xs, y::ys)
    | (x::xs, y::ys) -> y::merge (x::xs, ys)