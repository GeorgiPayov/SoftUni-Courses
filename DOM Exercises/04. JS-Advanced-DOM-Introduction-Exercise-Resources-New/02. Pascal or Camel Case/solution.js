function solve() {
  //TODO...
  let inputText = document.getElementById('text').value
  let inputName = document.getElementById('naming-convention').value
  let result = document.getElementById('result')
  //result.textContent = input;
  //return result

  let arr = Array.from(inputText);
  let final = '';

  if (inputName == 'Camel Case') {
    for (var i = 0; i < arr.length; i++) {
      if (i == 0) {       
        final = arr[0].toLowerCase();
      } else if (arr[i] == ' ') {
        final += arr[i + 1].toUpperCase();
        i++;
      } else {
        final += arr[i].toLowerCase();
      }
    }
  } else if (inputName == 'Pascal Case') {
    for (var i = 0; i < arr.length; i++) {
      if (i == 0) {       
        final = arr[0].toUpperCase();
      } else if (arr[i] == ' ') {
        final += arr[i + 1].toUpperCase();
        i++;
      } else {
        final += arr[i].toLowerCase();
      }
    }    
  } else {
    final = "Error!";
  }
  result.textContent = final;

}

console.log(solve())