function check() {

let a = document.getElementById("inp1"); //    <input type="number" placeholder="Enter number" id="inp1">

let avalue = a.value;

avalue = parseInt(avalue);

let res = document.getElementById("result");
 if (a % 2 == 0) {

    res.innerHTML = "Number is even";

}

else {

    res.innerHTML = "Number is odd";
}

}