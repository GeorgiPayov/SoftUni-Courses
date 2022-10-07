function fromJSONToHTMLTable(input){
            //Write your code here

    let arr = JSON.parse(input);
    let result = [];
    let name, score;

    let header = "\t<tr>";
    for ( var property of Object.keys(arr[0]) ) {
      header += "<th>" + property + "</th>";
    }
    header += "</tr>\n";

    result += "<table>\n";
    result += header;

    for (let i = 0; i < arr.length; i++) {
      result += "\t<tr>";
      for ( var property of Object.values(arr[i]) ) {

        result += "<td>" + property + "</td>";
      }
      result += "</tr>\n"

    }
    result += "</table>";
    return result;
  }

fromJSONToHTMLTable([`[{"Name":"Pesho",
"Score":4,
" Grade":8},
{"Name":"Gosho",
"Score":5,
" Grade":8},
{"Name":"Angel",
"Score":5.50,
" Grade":10}]`
]);



