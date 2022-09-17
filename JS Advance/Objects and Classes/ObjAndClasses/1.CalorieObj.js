function makeObj(input) {
    let obj = {}
    for (let i = 0; i < input.length; i++) {

        if (i % 2 == 0) {
            obj[input[i]] = 0;
            
        } else {
            obj[input[i-1]] = Number(input[i]);
        }
    }
    return obj;
}
let input = ['Yoghurt', '48', 'Rise', '138', 'Apple', '52'];
console.log(makeObj(input));

