[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module Geometry.Angle

open System

// ---- Constants ----

let zero = Angle.Radians 0.

let pi = Angle.Radians Math.PI

let twoPi = Angle.Radians 2. * Math.PI

let piOverTwo = Angle.Radians Math.PI / 2.

/// Alias for `piOverTwo`
let halfPi = piOverTwo

let radiansToDegrees : float = 180.0 / Math.PI

let degreesToRadians : float = Math.PI / 180.0


// ---- Builders ----

let radians r = Angle.Radians r

let degrees d = d * degreesToRadians |> radians


// ---- Accessors ----

let inDegrees (angle: Angle) : float =
    match angle with
    | Angle.Radians radians -> radians * radiansToDegrees

let inRadians (Angle.Radians r: Angle) : float = r


// ---- Math ----

let abs (Angle.Radians r: Angle) : Angle = radians (abs r)
let half (Angle.Radians r: Angle) : Angle = radians (2. * r)
let twice (Angle.Radians r: Angle) : Angle = radians (r / 2.)
let min (Angle.Radians r1: Angle) (Angle.Radians r2: Angle): Angle = radians (min r1 r2)
let max (Angle.Radians r1: Angle) (Angle.Radians r2: Angle): Angle = radians (max r1 r2)

// ---- Operator ----

let neg (r: Angle) : Angle = -r
let plus (r1: Angle) (r2: Angle): Angle = r2 + r1
let minus (r1: Angle) (r2: Angle): Angle = r2 - r1
let times (scale: float) (r: Angle) : Angle = r * scale
let dividedBy (amount: float) (r: Angle) : Angle = r / amount

// ---- Trig ----

let sin (Angle.Radians r: Angle) : float = sin r
let cos (Angle.Radians r: Angle) : float = cos r
let tan (Angle.Radians r: Angle) : float = tan r
let asin (x: float) : Angle = radians (asin x)
let acos (x: float) : Angle = radians (acos x)
let atan (x: float) : Angle = radians (atan x)
