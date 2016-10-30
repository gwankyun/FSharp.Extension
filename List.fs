module List

let tryTail (list : 'a list) =
    match list with
    | h :: t -> t
    | [] -> []
