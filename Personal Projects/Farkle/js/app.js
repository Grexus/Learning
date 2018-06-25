var dice = document.getElementsByClassName("dice");
var selectedDice = document.getElementsByClassName("selected");
var activePlayer;
var scoreSelected;
var scoreRound;
var scoreTotal;

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

    // Remove Selection
    removeSelection();

    // Roll & update dice
    rollDice();
    updateDice();
})

// Clicking "score & pass" button
document.getElementById("score-pass").addEventListener("click", function(){
    
    // Remove Selection
    removeSelection();

    // Hide & reset dice
    hideDice();
    resetDice();

    // Switch active player
    switchActivePlayer();

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

// Game Logic
for (i = 0; i < selectedDice.length; i++) {
    if (selectedDice[0].value === 1) {
        score = 100;
        alert("Scored 100!");
        // document.getElementById("player-" + activePlayer).querySelector(".selected-score").querySelector("score-value").innerHTML = score;
    }
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
        dice[i].src = "/resources/images/dice-" + dice[i].value + ".png";
    }
}

// Reset Dice
function resetDice() {
    for (i = 0; i < dice.length; i++) {
        dice[i].value = 0;
    }
}

// Remove Selection
function removeSelection() {
    for (i = 0; i < dice.length; i++) {
        dice[i].classList.remove("selected");
    }
}

// Switch Active Player
function switchActivePlayer() {
    if (activePlayer === 1) {
        activePlayer = 2;
        document.getElementById("player-2").classList.add("active");
        document.getElementById("player-1").classList.remove("active");
    } else {
        activePlayer = 1;
        document.getElementById("player-1").classList.add("active");
        document.getElementById("player-2").classList.remove("active");
    }
}

// Starting Settings
function init() {
    activePlayer = 1;
    document.getElementById("player-1").classList.add("active");
    document.getElementById("player-2").classList.remove("active");
    hideDice();
    showRollButton();
}