function result (town, population, treasury) {

    let city = {
        name: town,
        population: population,
        treasury: treasury,
        taxRate: 10,

        collectTaxes() {
            this.treasury = treasury + population * this.taxRate;
        },

        applyGrowth(percent) {
            this.population = population + (population * (percent / 100));
        },

        applyRecession(percentage) {
            this.treasury = treasury - (treasury * (percentage / 100));
        }
    }

    
    
    return city;
}

const city = 
  result('Tortuga',
  7000,
  15000);
console.log(city);


