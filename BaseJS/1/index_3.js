let month = [
    "Январь",
    "Февраль",
    "Март",
    "Апрель",
    "Май",
    "Июнь",
    "Июль",
    "Август",
    "Сентябрь",
    "Октябрь",
    "Ноябрь",
    "Декабрь",
];

function getSeason(params) {
    params++;
    if (params == 12 || params <= 2) {
        return 'Зима'
    }
    if (params > 2 || params <= 5) {
        return 'Весна'
    }
    if (params > 5 || params <= 8) {
        return 'Лето'
    }
    if (params >  8|| params <= 11) {
        return 'Осень'
    }
    return 'Error'
}

console.log(getSeason(1));
console.log(getSeason(7));