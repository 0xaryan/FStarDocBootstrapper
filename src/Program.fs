﻿namespace OxFStar

module Program =
    open System
    open OxFStar.CoreTypes
    open OxFStar.Parser

    [<EntryPoint>]
    let main argv =
        let html = (FStarDocHtml.Load Url).Html
        let result = ParseDoc html

        0 // return an integer exit code