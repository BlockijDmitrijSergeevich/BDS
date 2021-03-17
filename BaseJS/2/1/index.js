console.log(getWords('Прохожу курс в компании #senla по #javascript'));

function getWords(params) {
    let words = [];
    let pattern = /\#[a-z]*/g;
    words = params.match(pattern);
    return words;
}