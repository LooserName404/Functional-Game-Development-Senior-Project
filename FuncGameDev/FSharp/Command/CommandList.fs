module Commands

let mutable commands : (int -> obj) list = []

let addCommand x = 
    commands <- x::commands

let executeAllCommands commands = 
    // Looping through list to execute commands and ignoring subsequent output list
    List.map (fun x -> printfn "Executing element %d" x) commands |> ignore