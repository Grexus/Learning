var dice = document.getElementsByClassName("dice");

// Starting Settings
init();

// Clicking "Roll" button
document.getElementById("roll").addEventListener("click", function(){

    // Roll, Update & Show Dice
    rollDice();
    updateDice();
    showDice();

    // Show Score Buttons
    showScoreButtons();
})

// Clicking "score & roll again" button
document.getElementById("score-roll").addEventListener("click", function(){

    // Roll & update dice
    rollDice();
    updateDice();
})

// Clicking "score & pass" button
document.getElementById("score-pass").addEventListener("click", function(){
    
    // Hide & reset dice
    hideDice();
    resetDice();

    // Show "roll" button
    showRollButton();
})

// Toggle "selected" on click for all dice 
for (i = 0; i < dice.length; i++) {
    dice[i].addEventListener("click", function(){
        for (i = 0; i < dice.length; i++) {
            this.classList.toggle("selected");
        }
    })
}

// Hide Score Buttons
function showRollButton() {
    document.getElementById("score-roll").style.display = "none";
    document.getElementById("score-pass").style.display = "none";
    document.getElementById("roll").style.display = "flex";
}

function showScoreButtons() {
    document.getElementById("roll").style.display = "none";
    document.getElementById("score-roll").style.display = "flex";
    document.getElementById("score-pass").style.display = "flex";
}

// Hide Dice
function hideDice() {
    for (i = 0; i < dice.length; i++) {
        dice[i].style.visibility = "hidden";
    }
}

// Show Dice
function showDice() {
    for (i = 0; i < dice.length; i++) {
        dice[i].style.visibility = "visible";
    }
}

// Roll Dice
function rollDice() {
    for (i = 0; i < dice.length; i++) {
        dice[i].value = Math.floor((Math.random() * 6) + 1);
    }
}

// Update Dice Visuals
function updateDice() {
    for (i = 0; i < dice.length; i++) {
        dice[i].src = "/Farkle/resources/images/dice-" + dice[i].value + ".png";
    }
}

// Reset Dice
function resetDice() {
    for (i = 0; i < dice.length; i++) {
        dice[i].value = 0;
    }
}

// Starting Settings
function init() {
    hideDice();
    showRollButton();
}