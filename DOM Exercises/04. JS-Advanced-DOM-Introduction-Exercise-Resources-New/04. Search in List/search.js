
function search() {
   // TODO
   //let arrTowns = Array.from(document.querySelectorAll('#towns', 'li')[0].textContent);

   //document.getElementById("towns").getElementsByTagName("li")[0].outerText

   let result = [];
   let towns = document.getElementById("towns").getElementsByTagName("li");
   let searchedWord = document.getElementById("searchText").value;

   for (let i = 0; i < towns.length; i++) {

      let town = towns[i].outerText;

      if(town.includes(searchedWord)){
         result.push(town);
      }
   }

   document.getElementById("result").textContent = result.length;
}