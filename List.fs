module List

let tryTail (list : 'a list) =
    match list with
    | h :: t -> t
    | [] -> []

let tryZipList (list : 'a list list) =
    let rec go data result =
        match List.exists (List.isEmpty >> not) list with
        | true ->
            let head = List.map List.tryHead data
            let tail = List.map tryTail data
            go tail (head :: result)
        | false -> result
    go list []
