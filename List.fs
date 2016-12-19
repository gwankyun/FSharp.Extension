namespace FSharp.Extension

module List = 
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
    
    let tryZip (list1 : 'a list) (list2 : 'a list) = 
        [ list1; list2 ]
        |> tryZipList
        |> List.map (fun x -> (x.[0], x.[1]))
    
    let tryZip3 (list1 : 'a list) (list2 : 'a list) (list3 : 'a list) = 
        [ list1; list2; list3 ]
        |> tryZipList
        |> List.map (fun x -> (x.[0], x.[1], x.[2]))
    
    let append (list1 : 'a list) (list2 : 'a list) = 
        [ list1; list2 ]
        |> List.map List.rev
        |> List.rev
        |> List.fold (List.fold (fun s1 t1 -> t1 :: s1)) List.empty
