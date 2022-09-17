function createLow(input) {

    let products = [];
    let priceTown = [];
    for (let i = 0; i<input.length; i++) {
        let [townName, product, price] = input[i].split(" | ");

        if (!products.includes(product)) {
            products.push(product);
        }

        priceTown[i] = [townName, product, price];
    }
    let result = [];
    let forPush = "";
    for (let i = 0; i < products.length; i++) {
        let lowwest = 1000000;
        for (let j = 0; j < priceTown.length; j++) {
            if (products[i] == priceTown[j][1])
            {
                priceTown[j][2] = Number(priceTown[j][2]);

                if (priceTown[j][2] < lowwest) {
                    lowwest = priceTown[j][2];
                    forPush = `${products[i]} -> ${priceTown[j][2]} (${priceTown[j][0]})`; 
                }
            }
            
        }
        result.push(forPush);
    }
    return result;
}

let input = ['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 3',
'Sample Town | Peach | 1',
'Sofia | Orange | 2',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10'];

console.log(createLow(input))
