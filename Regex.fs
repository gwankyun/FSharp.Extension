namespace Extension.RegularExpressions

open System.Text.RegularExpressions
open System

module Regex = 
    type Regex with
        
        static member tryMatches (input : string, pattren : string, ?options : RegexOptions, ?matchTimeout : TimeSpan) = 
            match (options, matchTimeout) with
            | (Some(o), Some(m)) -> 
                match Regex.IsMatch(input, pattren, o, m) with
                | true -> Some(Regex.Matches(input, pattren, o, m))
                | false -> None
            | (Some(o), None) -> 
                match Regex.IsMatch(input, pattren, o) with
                | true -> Some(Regex.Matches(input, pattren, o))
                | false -> None
            | (None, Some(m)) -> 
                match Regex.IsMatch(input, pattren, RegexOptions.None, m) with
                | true -> Some(Regex.Matches(input, pattren, RegexOptions.None, m))
                | false -> None
            | (None, None) -> 
                match Regex.IsMatch(input, pattren) with
                | true -> Some(Regex.Matches(input, pattren))
                | false -> None
        
        static member tryMatch (input : string, pattren : string, ?options : RegexOptions, ?matchTimeout : TimeSpan) = 
            match (options, matchTimeout) with
            | (Some(o), Some(m)) -> 
                match Regex.IsMatch(input, pattren, o, m) with
                | true -> Some(Regex.Match(input, pattren, o, m))
                | false -> None
            | (Some(o), None) -> 
                match Regex.IsMatch(input, pattren, o) with
                | true -> Some(Regex.Match(input, pattren, o))
                | false -> None
            | (None, Some(m)) -> 
                match Regex.IsMatch(input, pattren, RegexOptions.None, m) with
                | true -> Some(Regex.Match(input, pattren, RegexOptions.None, m))
                | false -> None
            | (None, None) -> 
                match Regex.IsMatch(input, pattren) with
                | true -> Some(Regex.Match(input, pattren))
                | false -> None
