﻿module EvenNumbers

let private isEven x = 
    x % 2 = 0
     
let getFrom arr =    
    Seq.where(fun x -> isEven x) arr  

