function toJsonObj (input) {
    let myHero = [];

    for (let i = 0; i <input.length; i++) {
        let [name, level, items] = input[i].split(" / ")
        level = Number(level);
        items = items ? items.split(", ") : []

        myHero.push({name, level, items})
    }

    return JSON.stringify(myHero);
  
}

let input = ['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara'];

console.log(toJsonObj(input));
