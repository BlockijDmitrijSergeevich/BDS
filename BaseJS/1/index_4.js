console.log(getDayDeclension(2, ['День', 'Дня', 'Дней']));
console.log(getDayDeclension(1, ['День', 'Дня', 'Дней']));
console.log(getDayDeclension(7, ['День', 'Дня', 'Дней']));

function getDayDeclension(n, text_forms) {
    n = Math.abs(n) % 100;
    var n1 = n % 10;
    if (n > 10 && n < 20) {
        return `${text_forms[2]}`;
    }
    if (n1 > 1 && n1 < 5) {
        return `${text_forms[1]}`;
    }
    if (n1 == 1) {
        return `${text_forms[0]}`;
    }
    
    return `${text_forms[2]}`;
}