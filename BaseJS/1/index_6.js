getMultiplicationTable(178);

function getMultiplicationTable(number) {
    for (let i = 1; i <= 10; i++) {
        element = number * i;
        console.log("%d * %d = %d",number,i, element);
    }
}