module Char
open System

let isLeft (c : char) =
    "qwertasdfgzxcvb".Contains(string c)

let isRight (c : char) =
    "yuiophjkl;nm,./".Contains(string c)
