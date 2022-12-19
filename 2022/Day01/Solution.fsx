open System.IO

let inputPath = Path.Combine [| __SOURCE_DIRECTORY__; "input.txt" |]
let allLines = File.ReadAllText inputPath

let elvesCalories = allLines.Split "\n\n"

let sumCalories (elveCalories: string) =
    elveCalories.Split "\n"
    |> Array.map (fun calorie -> calorie |> int)
    |> Array.sum

let highestTotalCalories = elvesCalories |> Array.map sumCalories |> Array.max

printf "%i" highestTotalCalories
