namespace FSharp.Extension

open System

module Char = 
    let isLeft (c : char) = "qwertasdfgzxcvb".Contains(string c)
    let isRight (c : char) = "yuiophjkl;nm,./".Contains(string c)
    let isControl (c : char) = Char.IsControl(c)
    let isDigit (c : char) = Char.IsDigit(c)
    let isHighSurrogate (c : char) = Char.IsHighSurrogate(c)
    let isLetter (c : char) = Char.IsLetter(c)
    let isLetterOrDigit (c : char) = Char.IsLetterOrDigit(c)
    let isLower (c : char) = Char.IsLower(c)
    let isLowSurrogate (c : char) = Char.IsLowSurrogate(c)
    let isNumber (c : char) = Char.IsNumber(c)
    let isPunctuation (c : char) = Char.IsPunctuation(c)
    let isSeparator (c : char) = Char.IsSeparator(c)
    let isSurrogate (c : char) = Char.IsSurrogate(c)
    let isSymbol (c : char) = Char.IsSymbol(c)
    let isUpper (c : char) = Char.IsUpper(c)
    let isWhiteSpace (c : char) = Char.IsWhiteSpace(c)
    let toLower (c : char) = Char.ToLower(c)
    let toUpper (c : char) = Char.ToUpper(c)
