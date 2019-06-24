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

