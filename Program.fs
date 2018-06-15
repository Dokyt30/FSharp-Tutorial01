open System

type Person = {
    Name:string
    Age: int
}

let a = { Name = "hoge"; Age = 30 }
let b = { Name = "hooog"; Age = 31 }
if a = b then
 System.Console.WriteLine("OK");
else 
 System.Console.WriteLine("Ooops");


let x = 42
if x = 42 then
  let x = x - 10
  System.Console.WriteLine(x)
System.Console.WriteLine(x);;

//let plus10 x =
// x + 10

let plus10 x = x + 10
let ans = plus10 20
System.Console.WriteLine(ans);;

let plus x y = x + y
let ans2 = plus 2 3
System.Console.WriteLine(ans2);;


let ans3 = plus ( plus 10 20) 3
System.Console.WriteLine(ans3);;

let f x = x + 2
let g = f
System.Console.WriteLine(g 10);;

let ans4 = (+) 2 3
System.Console.WriteLine(ans4);;

let plusop = (+)
let ans5 = plusop 2 3
System.Console.WriteLine(ans5);;

let gt x y = x < y

let gt2 x y =
 let i = x + 0
 i < y

let twice f x = f (f x)
let plus11 x = x + 11
let ans6 = twice plus11 3

System.Console.WriteLine(ans6);; // 23


let mul1024 xs = 
 let f x = x * 1024
 List.map f xs

let mul10142 xs =
    List.map (fun x -> x * 1024) xs 

let strs = [ 1; 2; 3 ]

let strs2 = mul10142 strs
System.Console.WriteLine(strs2);;

let people = [("ass bbb", 24); ("ccc ddd", 30)]

let f7 (x,y) = x + y
let ans7 = f7 (10,20)
System.Console.WriteLine(ans7);;

let f8 x = (x, x*3)
let g8 (x,y) = x*y
let ans8 = g8(f8 10)
System.Console.WriteLine(ans8);;
let ans9 = f8 10
let ans10 = g8 ans9
System.Console.WriteLine(ans10);;

let person11 = ("h", 24)
let xs11 = ["hhh";"ppp"]
let ps11 = [("hhs", 24); ("piie", 20)]
System.Console.WriteLine(ps11);;



[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code

