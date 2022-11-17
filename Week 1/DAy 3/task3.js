
// print 1 - 10 

/* let count = 0;

for(let count =0; count <=10; count++) {

    console.log(count)
}   */


//let str = "bootcamp";
let str = "abba";
let reversestr = "";


// // for (let i=0;i<str.length; i++) {
// //     console.log(str)
// }


for (let i = str.length-1; i>=0; i--) {

   // console.log(str[i])

 reversestr = reversestr + str[i];


}

if (str == reversestr) {
    console.log("plaindrome");
}
else {
    console.log("not plaindrome");
}

// ====================================================================

function check() {

//let str1 = "a b b a";

let space = " ";
let count = 0;
let inputtext = document.getElementById("inp1")  // <input type="text" placeholder="Enter here" id="inp1">
let res1 = document.getElementById("result");


let str1=inputtext.value;



for (let i = 0; i<=str1.length; i ++) {
 
    if (str1[i] == space){
        count++;
    }
}

//console.log(count);

res1.innerHTML = count;
}