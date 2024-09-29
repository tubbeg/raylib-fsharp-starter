open Raylib_cs

printfn "Running Raylib"

let cboolToBool (c : CBool) : bool =
    CBool.op_Implicit c

let windowRayLib ()  =
    let rec wraylib isClose  =
        match isClose with
        | true -> ()
        | _ ->
            Raylib.BeginDrawing()
            Raylib.ClearBackground(Color.White)
            Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Black)
            Raylib.EndDrawing()
            Raylib.WindowShouldClose() |> cboolToBool |> wraylib
    wraylib false


let runRayLib () =
    Raylib.InitWindow(800, 480, "Hello World")
    Raylib.BeginDrawing()
    windowRayLib()
    Raylib.EndDrawing()


runRayLib ()
printfn "Done!"