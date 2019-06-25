_Hallmarks of imperative languages:_
- Assignment and side-effects
- Iteration
- Order of execution is critical

**Example of C (imperative)
    int fact(int n) {
        int sofar = 1;
        while (n>0) sofar *= n--;
        return sofar;
    }**

_Hallmarks of functional languages:_
-Single-valued variables
-Heavy use of recursion
-Functions are first-class citizens, can be used as     parameters, function results, etc.
-Minimal use of assignments and side-effects

_Hallmarks fo object-oriented languages:_
- (Usually) Imperative
- Constructs to help programmers use "objects" - little bundles of data that know how to do things to themselves

_Functional languages:_ a style using many small
side-effect-free functions

_Why F#?_
- high level, powerful
- functional - everything returns a result
- interactive
- minimal side effects
- object oriented
- pattern matching style
- C# and F# classes can be freely mixed

_Hallmarks of functional languages:_
- Single-valued variables
- Heavy use of recursion
- Functions are first-class citizens, can be used as parameters,function results, etc.
- Minimal use of assignments and side-effects

_Patterns_
- Not just for match, can use in L assignment 
- _ character matches anything but binds to nothing
- single variable matches and binds to anything
- tuples match tuple of right size that contents match sub-patterns
- list matches any list of right size whose contents match the sub-patterns
- :: patterns matches any non-empty list who head and tail match sub-patterns

_Currying_ transforms a function of multiple arguments into
chain of functions each taking one argument

> let srtorder order x y =
match order with
| "ascend" -> x <= y
| "descend" -> x >= y;;
> srtorder "ascend" 3 4;;
val it : bool = true

- Compute function at runtime
- Signatures of computed functions must be identical

staging functions

> let reduce f a L =
let rec red L =
match L with
| [] -> a
| h::t -> f h (red t)
in
red L;;
> let r = reduce sub 0;;
> r [1;2;3];; // returns 2