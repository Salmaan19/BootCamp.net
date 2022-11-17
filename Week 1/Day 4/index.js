function check() {
let res = document.getElementById("aa");



let arr = ["f1","f2","f3","f4","f5","f6"]
let count= "";

for(let i =0; i<arr.length; i++) {

   
    count = count + arr[i] + " ";
    
   // console.log(arr[i])

    
}
res.innerHTML= count;

}

check();