function chk() {
  
    let a = document.getElementById("inp1");
    let b = document.getElementById("inp2");
    let res = document.getElementById("result");
    
    let avalue = a.value;
    let bvalue = b.value;
   

    avalue = parseInt(avalue);
    bvalue = parseInt(bvalue);
    

    var arr = ["f1","f2","f3","f4","f5","f6"];
    for(let i = avalue; i<=bvalue; i++) {

       res.innerHTML += arr[i] + " ";

    }

   
}