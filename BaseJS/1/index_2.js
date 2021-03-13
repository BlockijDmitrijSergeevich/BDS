console.log(addMinutes(12, 25, 30));
console.log(addMinutes(23, 40, 83));

function addMinutes(hours, min, interval) {
    const newMin = (min + interval) % 60;
    const newHours = (hours + Math.floor((min + interval) / 60)) % 24;
    return `${newHours}:${newMin}`;
}
