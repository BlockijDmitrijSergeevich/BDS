const maxHour = 24;
const maxMinut = 60;

isTimeValid(14, 43);
isTimeValid(32, 43);
function isTimeValid(hours, minutes) {
    if (Number.isInteger(hours) &&
        Number.isInteger(minutes)) {
        if (checkTime(hours, maxHour) &&
            checkTime(minutes, maxMinut)) {
                console.log("true");
                return true;
        }
    }
    else {
        console.log("false");
        return false;
    }
}

function checkTime(time, maxTime) {
    if (time >= 0 &&
        time < maxTime) {
        return true;
    }
    else {
        console.log("Value is not valid");
        return false;
    }
}