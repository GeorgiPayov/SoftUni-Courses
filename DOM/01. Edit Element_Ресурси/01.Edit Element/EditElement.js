function editElement(ref, el1, el2) {
    // TODO
    let full = document.getElementById('e1').textContent
    const ele1 = document.getElementById('e1')
    const ele2 = document.getElementById('e1')

    ele1.textContent = el1;
    ele2.textContent = el2;
    

    let result = full.replace(ele1, ele2)

    return result;
}

console.log(editElement());