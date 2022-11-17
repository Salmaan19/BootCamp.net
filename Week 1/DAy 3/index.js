function count(){

let inpt1 = document.getElementById("inp1");
let inpt2 = document.getElementById("inp2");
let result = document.getElementById("result");

let inp1value=inpt1.value;
let inp2value=inpt2.value;

inp1value = parseInt(inp1value);
inp2value = parseInt(inp2value);





if(inp1value > inp2value) {
    result.innerHTML = "Number 1 is greater";
} 

else if (inp1value < inp2value ){
    result.innerHTML = "Number 2 is greater";
}

else {
     result.innerHTML = "Both numbers are same";
}
}