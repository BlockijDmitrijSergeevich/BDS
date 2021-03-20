console.log(normalizeWords(['web', 'web', 'JavaScript', 'script', 'programming']));

function normalizeWords(params) {

    let mySet = new Set();
    params.forEach(element => {
        mySet.add(element.toLowerCase());
    });

    return [...mySet].join(', ');
}