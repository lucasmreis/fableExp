#r "node_modules/fable-compiler/bin/Fable.Core.dll"
#r "node_modules/fable-import/Fable.Import.dll"

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import

type Aaa =
    | A
    | B of int

let aaa = A

