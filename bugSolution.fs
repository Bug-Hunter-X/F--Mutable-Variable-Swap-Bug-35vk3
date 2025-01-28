let xRef = ref 10
let yRef = ref 20

let swap xRef yRef = 
    let temp = !xRef
    xRef := !yRef
    yRef := temp

swap xRef yRef
printf "%d %d" !xRef !yRef