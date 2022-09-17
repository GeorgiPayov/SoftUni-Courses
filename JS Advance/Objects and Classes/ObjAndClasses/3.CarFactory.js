function createCar(inputObj) {
    smallEngine = { power: 90, volume: 1800 }
    normalEngine = { power: 120, volume: 2400 }
    monsterEngine = { power: 200, volume: 3500 }

    myCar = {
        model: inputObj.model,

    }

    if (inputObj.power <120) {
        myCar["engine"] = smallEngine;
    } else if (inputObj < 200) {
        myCar["engine"] = normalEngine;
    } else {
        myCar["engine"] = monsterEngine;
    }

    if (inputObj.carriage == "hatchback") {
        myCar["carriage"] = { type: "hatchback", color: inputObj.color }
    } else if (inputObj.carriage == "coupe") {
        myCar["carriage"] = { type: "coupe", color: inputObj.color }
    }

    if (inputObj.wheelsize % 2 == 1) {
        let wheelsAd = [inputObj.wheelsize, inputObj.wheelsize, inputObj.wheelsize, inputObj.wheelsize];
        myCar["wheels"] = wheelsAd;
    } else {
        inputObj.wheelsize -= 1;
        let wheelsAd = [inputObj.wheelsize, inputObj.wheelsize, inputObj.wheelsize, inputObj.wheelsize];
        myCar["wheels"] = wheelsAd;
    }

    return myCar;    
}

inputObj =  { model: 'Opel Vectra',
power: 110,
color: 'grey',
carriage: 'coupe',
wheelsize: 17 }

console.log(createCar(inputObj));