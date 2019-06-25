//recursive map
let rec map (f: int -> int) (L: int list) =
    match L with
    | [] -> []
    | h::t -> (f h)::map f t

// map parameter f:int->int is function with int parameter
//and returns an int
//There are no int-specific operations in map, but map is not
//generic, only allows int->int */
