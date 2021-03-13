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
    return `${month[params - 1]}`;
}

console.log(getSeason(1));
console.log(getSeason(7));