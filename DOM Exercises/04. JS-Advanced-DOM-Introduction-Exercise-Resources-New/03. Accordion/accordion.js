function toggle() {
    let but = document.getElementsByClassName("button")[0];

    if (but.textContent == "More") {
        document.getElementById("extra").style.display = "block";
        //document.getElementsByClassName("button")[0].textContent = "Less";
        but.textContent = 'Less';
    } else {
        document.getElementById("extra").style.display = "none";
        //document.getElementsByClassName("button")[0].textContent = "More";
        but.textContent = "More";
    }
    
    
}

console.log(toggle())