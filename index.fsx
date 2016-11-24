#r "node_modules/fable-core/Fable.Core.dll"

open Fable.Core.JsInterop
open Fable.Import.Browser

let aaa =
    createObj [
        "a" ==> 123
        "b" ==> "abcdef"
        "c" ==> createObj [
            "d" ==> 456
            "e" ==> "ghijkl"
        ]
]

let bbb = aaa


