// Change height & ages to test

// John
var johnHeight = 176;
var johnAge = 30;
var johnScore = johnHeight + (johnAge * 5);

// Mike
var mikeHeight = 176;
var mikeAge = 30;
var mikeScore = mikeHeight + (mikeAge * 5);

// Tony
var tonyHeight = 176;
var tonyAge = 30;
var tonyScore = tonyHeight + (tonyAge * 5);

// Scoring
if (johnScore > mikeScore && johnScore > tonyScore) {
    console.log('John wins with a score of ' + johnScore + '!');
} else if (mikeScore > johnScore && mikeScore > tonyScore ) {
    console.log('Mike wins with a score of ' + mikeScore + '!');
} else if (tonyScore > johnScore && tonyScore > mikeScore) {
    console.log('Tony wins with a score of ' + tonyScore + '!');
} else if (tonyScore > johnScore && tonyScore === mikeScore) {
    console.log("It's tie between Tony & Mike with a score of " + tonyScore + '!');
} else if (tonyScore > mikeScore && tonyScore === johnScore) {
    console.log("It's tie between Tony & John with a score of " + tonyScore + '!');
} else if (johnScore > tonyScore && johnScore === mikeScore) {
    console.log("It's tie between John & Mike with a score of " + johnScore + '!');
} else {
    console.log("It's a threeway tie!");
}