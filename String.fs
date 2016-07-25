namespace Extension
open System
open System.Text.RegularExpressions

module String =
    type System.String with
        member this.TryParseUInt64() =
            let x = ref 0UL
            match UInt64.TryParse(this, x) with
            | true -> Some !x
            | false -> None
        member this.TryParseUInt32() =
            let x = ref 0u
            match UInt32.TryParse(this, x) with
            | true -> Some !x
            | false -> None
        member this.TryParseUInt16() =
            let x = ref 0us
            match UInt16.TryParse(this, x) with
            | true -> Some !x
            | false -> None
        member this.TryParseInt64() =
            let x = ref 0L
            match Int64.TryParse(this, x) with
            | true -> Some !x
            | false -> None
        member this.TryParseInt32() =
            let x = ref 0
            match Int32.TryParse(this, x) with
            | true -> Some !x
            | false -> None
        member this.TryParseInt16() =
            let x = ref 0s
            match Int16.TryParse(this, x) with
            | true -> Some !x
            | false -> None
        member this.TryParseDouble() =
            let x = ref 0.0
            match Double.TryParse(this, x) with
            | true -> Some !x
            | false -> None
        member this.Reverse () =
            let mutable s = ""
            for i in this do
                s <- s.Insert(0, string i)
            s

    let rev (str: string) =
        str.Reverse()

    let toUpper (str: string) =
        str |> String.map Char.ToUpper

    let toLower (str: string) =
        str |> String.map Char.ToLower

    let tryParseUInt64 (str: string) =
        str.TryParseInt64()

    let tryParseUInt32 (str: string) =
        str.TryParseInt32()

    let tryParseUInt16 (str: string) =
        str.TryParseInt16()

    let tryParseInt64 (str: string) =
        str.TryParseInt64()

    let tryParseInt32 (str: string) =
        str.TryParseInt32()

    let tryParseInt16 (str: string) =
        str.TryParseInt16()

    let tryParseDouble (str: string) =
        str.TryParseDouble()

    let toSeq (str: string): char seq =
        str.ToCharArray() |> Seq.ofArray

    let find (predicate: char -> bool) (str: string): char =
        (str |> String.filter predicate).[0]

    let join (separator : string) (values : Collections.Generic.IEnumerable<string>) =
        String.Join(separator, values)