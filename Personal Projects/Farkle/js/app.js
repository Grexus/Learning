var dice = document.getElementsByClassName("dice");
var selectedDice = document.getElementsByClassName("selected");
var activePlayer;
var scoreSelected;
var scoreRound;
var scoreTotal;
var shownDice;

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

    // Reduce number of shown dice based on how many were selected
    shownDice = shownDice - selectedDice.length;
    setShownDice();

    // Remove Selection
    removeSelection();

    // Update round score
    scoreRound = scoreRound + scoreSelected;
    updateRoundScore();

    // Reset selected score to 0 and update selected score
    scoreSelected = 0;
    updateSelectedScore();

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

// Apply "select" class on dice & calculate score
for (i = 0; i < dice.length; i++) {
    dice[i].addEventListener("click", function(){
        this.classList.toggle("selected");
        
        calcSelectedScore();
        updateSelectedScore();
    })    
}

// Hide Score Buttons
function showRollButton() {
    document.getElementById("score-roll").style.display = "none";
    document.getElementById("score-pass").style.display = "none";
    document.getElementById("roll").style.display = "flex";
}

// Show Score Buttons
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
        
        // Testing
        // dice[i].value = 5;
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

// Set number of shown dice
function setShownDice() {
    for (i = 0; i < shownDice - 1; i++) {
        cloneDice = document.getElementsByClassName("dice")[0].cloneNode(true);
        document.getElementById("dice-container").appendChild(cloneDice);
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

// Calculate Score
function calcSelectedScore() {
    // 6 Dice Selected
    if (selectedDice.length === 6) {
        if (selectedDice[0].value === 1 && selectedDice[1].value === 1  && selectedDice[2].value === 1 && selectedDice[3].value === 1 && selectedDice[4].value === 1 && selectedDice[5].value === 1) {
            score = 8000;
        } else if (selectedDice[0].value === 2 && selectedDice[1].value === 2  && selectedDice[2].value === 2 && selectedDice[3].value === 2 && selectedDice[4].value === 2 && selectedDice[5].value === 2) {
            score = 1600;
        } else if (selectedDice[0].value === 3 && selectedDice[1].value === 3  && selectedDice[2].value === 3 && selectedDice[3].value === 3 && selectedDice[4].value === 3 && selectedDice[5].value === 3) {
            score = 2400;
        } else if (selectedDice[0].value === 4 && selectedDice[1].value === 4  && selectedDice[2].value === 4 && selectedDice[3].value === 4 && selectedDice[4].value === 4 && selectedDice[5].value === 4) {
            score = 3200;
        } else if (selectedDice[0].value === 5 && selectedDice[1].value === 5  && selectedDice[2].value === 5 && selectedDice[3].value === 5 && selectedDice[4].value === 5 && selectedDice[5].value === 5) {
            score = 4000;
        } else if (selectedDice[0].value === 6 && selectedDice[1].value === 6  && selectedDice[2].value === 6 && selectedDice[3].value === 6 && selectedDice[4].value === 6 && selectedDice[5].value === 6) {
            score = 4800;
        }
    
    // 5 Dice Selected 
    } else if (selectedDice.length === 5) {
        if (selectedDice[0].value === 1 && selectedDice[1].value === 1  && selectedDice[2].value === 1 && selectedDice[3].value === 1  && selectedDice[4].value === 1) {
            score = 4000;
        } else if (selectedDice[0].value === 2 && selectedDice[1].value === 2  && selectedDice[2].value === 2 && selectedDice[3].value === 2 && selectedDice[4].value === 2) {
            score = 800;
        } else if (selectedDice[0].value === 3 && selectedDice[1].value === 3  && selectedDice[2].value === 3 && selectedDice[3].value === 3 && selectedDice[4].value === 3) {
            score = 1200;
        } else if (selectedDice[0].value === 4 && selectedDice[1].value === 4  && selectedDice[2].value === 4 && selectedDice[3].value === 4 && selectedDice[4].value === 4) {
            score = 1600;
        } else if (selectedDice[0].value === 5 && selectedDice[1].value === 5  && selectedDice[2].value === 5 && selectedDice[3].value === 5 && selectedDice[4].value === 5) {
            score = 2000;
        } else if (selectedDice[0].value === 6 && selectedDice[1].value === 6  && selectedDice[2].value === 6 && selectedDice[3].value === 6 && selectedDice[4].value === 6) {
            score = 2400;
        }
    
    // 4 Dice Selected
    } else if (selectedDice.length === 4) {
        if (selectedDice[0].value === 1 && selectedDice[1].value === 1  && selectedDice[2].value === 1 && selectedDice[3].value === 1) {
            score = 2000;
        } else if (selectedDice[0].value === 2 && selectedDice[1].value === 2  && selectedDice[2].value === 2 && selectedDice[3].value === 2) {
            score = 400;
        } else if (selectedDice[0].value === 3 && selectedDice[1].value === 3  && selectedDice[2].value === 3 && selectedDice[3].value === 3) {
            score = 600;
        } else if (selectedDice[0].value === 4 && selectedDice[1].value === 4  && selectedDice[2].value === 4 && selectedDice[3].value === 4) {
            score = 800;
        } else if (selectedDice[0].value === 5 && selectedDice[1].value === 5  && selectedDice[2].value === 5 && selectedDice[3].value === 5) {
            score = 1000;
        } else if (selectedDice[0].value === 6 && selectedDice[1].value === 6  && selectedDice[2].value === 6 && selectedDice[3].value === 6) {
            score = 1200;
        }

    // 3 Dice Selected
    } else if (selectedDice.length === 3) {
        if (selectedDice[0].value === 1 && selectedDice[1].value === 1  && selectedDice[2].value === 1) {
            score = 1000;
        } else if (selectedDice[0].value === 2 && selectedDice[1].value === 2  && selectedDice[2].value === 2) {
            score = 200;
        } else if (selectedDice[0].value === 3 && selectedDice[1].value === 3  && selectedDice[2].value === 3) {
            score = 300;
        } else if (selectedDice[0].value === 4 && selectedDice[1].value === 4  && selectedDice[2].value === 4) {
            score = 400;
        } else if (selectedDice[0].value === 5 && selectedDice[1].value === 5  && selectedDice[2].value === 5) {
            score = 500;
        } else if (selectedDice[0].value === 6 && selectedDice[1].value === 6  && selectedDice[2].value === 6) {
            score = 600;
        }

    // 2 Dice Selected
    } else if (selectedDice.length === 2) {
        if (selectedDice[0].value === 1 && selectedDice[1].value === 1) {
            score = 200;
        } else if (selectedDice[0].value === 5 && selectedDice[1].value === 5) {
            score = 100;
        }
    
    // 1 Dice Selected
    } else if (selectedDice.length === 1) {
        if (selectedDice[0].value === 1) {
            score = 100;
        } else if (selectedDice[0].value === 5) {
            score = 50;
        }
    } else {
        score = 0;
    }

    // a single 1 is worth 100 points;
    // a single 5 is worth 50 points;
    // three of a kind is worth 100 points multiplied by the given number, e.g. three 4s are worth 400 points;
    // three 1's are worth 1,000 points;
    // four or more of a kind is worth double the points of three of a kind, so four 4s are worth 800 points, five 4s are worth 1,600 points etc.

    scoreSelected = score;
}

// Update selected score
function updateSelectedScore() {
    document.getElementById("player-" + activePlayer).querySelector(".selected-score").querySelector(".score-value").innerHTML = scoreSelected;
}

// Update round score
function updateRoundScore() {
    document.getElementById("player-" + activePlayer).querySelector(".round-score").querySelector(".score-value").innerHTML = scoreRound;
}

// Starting Settings
function init() {
    activePlayer = 1;
    document.getElementById("player-1").classList.add("active");
    document.getElementById("player-2").classList.remove("active");
    scoreRound = 0;
    scoreSelected = 0;
    scoreTotal = 0;
    shownDice = 6;
    hideDice();
    showRollButton();
}