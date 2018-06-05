// Coding Challenge 1

// John and a friend invented a simple game where the player with the highest value of his height (in centimeters) plus five times his age wins (what a silly game :)

// 1. Create variables for the heights and ages of two friends and assign them some values
// 2. Calculate their scores
// 3. Decide who wins and print the winner to the console. Include the score in the string that you output to the console. Don't forget that there can be a draw (both players with the same score).

// 4. EXTRA: Add a third player and now decide who wins. Hint: you will need the && operator to take the decision. If you can't solve this one, just watch the solution, it's no problem :)

// -------------------------------------------------------------------------------- //

// Solution

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
    console.log("John wins with a score of " + johnScore + "!");
} else if (mikeScore > johnScore && mikeScore > tonyScore ) {
    console.log("Mike wins with a score of " + mikeScore + "!");
} else if (tonyScore > johnScore && tonyScore > mikeScore) {
    console.log("Tony wins with a score of " + tonyScore + "!");
} else if (tonyScore > johnScore && tonyScore === mikeScore) {
    console.log("It's tie between Tony & Mike with a score of " + tonyScore + "!");
} else if (tonyScore > mikeScore && tonyScore === johnScore) {
    console.log("It's tie between Tony & John with a score of " + tonyScore + "!");
} else if (johnScore > tonyScore && johnScore === mikeScore) {
    console.log("It's tie between John & Mike with a score of " + johnScore + "!");
} else {
    console.log("It's a threeway tie!");
}