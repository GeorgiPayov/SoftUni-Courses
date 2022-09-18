function townPop (input) {

    let townPop = {};

    for (const line of input) {
        let [town, population] = line.split(' <-> ');
        population = Number(population);
        if(!townPop.hasOwnProperty(town)){
            townPop[town] = 0;
        }
        townPop[town] += population;
    }

    let result = Object.entries(townPop);

    for (const line of result) {
        console.log(`${line[0]} : ${line[1]}`);
    }
}