namespace FSharp.Extension

module Tuple = 
    let first (k, _) = k
    let second (_, v) = v
