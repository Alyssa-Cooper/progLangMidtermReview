//a function is tail recursive when there is nothing to do 
//after the function returns except return its value

let rec tailFactorial a n =
    match n with 
    | 1 -> a
    | n ->tailFactorial (a*n) (n-1)

//tail recusion accumulates results before recursion

//convert to tail recursion

let rec sum L =
    match L with
    | [] -> 0
    | h::t -> h+(sum t)

let rec sumTailRecursion a L =
    match L with
    | [] -> 0
    | h::t -> sumTailRecursion (a+h) t

let rec rdc L =
    match L with
    | h::[] -> []
    | h::t -> h::rdc t
   
let rec rdcTail a L =
    match L with
    | h::[] -> []
    | h::t -> rdcTail (h::a) t