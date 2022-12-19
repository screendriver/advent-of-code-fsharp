open System.IO

let inputPath = Path.Combine [| __SOURCE_DIRECTORY__; "input.txt" |]
let allLines = File.ReadAllText inputPath

let elvesCalories = allLines.Split "\n\n"

let sumCalories (elveCalories: string) =
    elveCalories.Split "\n"
    |> Array.map (fun calorie -> calorie |> int)
    |> Array.sum

let highestTotalCalories = elvesCalories |> Array.map sumCalories |> Array.max

printf "Solution part 1: %i %s" highestTotalCalories System.Environment.NewLine

let highestTotalCaloriesTopThreeElves =
    elvesCalories
    |> Array.map sumCalories
    |> Array.sortDescending
    |> Array.take 3
    |> Array.sum

printf "Solution part 2: %i" highestTotalCaloriesTopThreeElves
