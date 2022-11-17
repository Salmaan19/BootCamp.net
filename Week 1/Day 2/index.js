function con() {

    let inp1 = document.getElementById("inp1");
    let a = parseInt(inp1.value);

    if (a > 21) {

        console.log("you are allow to use laptop and mobile");
    }

    else if (a >= 18) {
        console.log("you are allow to use mobile only");
    }

}