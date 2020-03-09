// Learn more about F# at http://fsharp.org
// A simple program showing the power of functions and functio passing in f#

open System

let inchToMillimeter v = v * 25.4
let feetToInches f = f * 12.0
let yardToFoot y = y * 3.0
let mileToYard m = m * 1760.0

let divBy1000 = (*) 0.001

let millimeterToMeter m = divBy1000 m
let meterToKilometer = millimeterToMeter
let millimeterToKilometer = divBy1000 >> divBy1000

let inchToMeter = 
    inchToMillimeter >> millimeterToMeter
let footToMeter = 
    feetToInches >> inchToMeter
let yardToMeter =
    yardToFoot >> footToMeter
let yardToKilometer =
    yardToMeter >> meterToKilometer
let mileToKilometer = 
    mileToYard >> yardToKilometer

[<EntryPoint>]
let main argv =
    printfn "%f" (mileToKilometer 1024.0)
    0 // return an integer exit code
