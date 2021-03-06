/*
GAME RULES:

- The game has 2 players, playing in rounds
- In each turn, a player rolls a dice as many times as he whishes. Each result get added to his ROUND score
- BUT, if the player rolls a 1, all his ROUND score gets lost. After that, it's the next player's turn
- The player can choose to 'Hold', which means that his ROUND score gets added to his GLOBAL score. After that, it's the next player's turn
- The first player to reach 100 points on GLOBAL score wins the game

*/

var scores, roundScore, activePlayer, dice, gameActive, lastDice, winningScore;

init();

console.log("Fuck you");

document.querySelector(".btn-roll").addEventListener("click", function() {
    
    if (gameActive) {

        // Get Random Number between '1' & '6'
        var dice1 = Math.floor(Math.random() * 6) + 1;
        var dice2 = Math.floor(Math.random() * 6) + 1;

        // Display Result
        var diceDOM1 = document.querySelector("#dice-1"); 
        diceDOM1.style.display = "block";
        diceDOM1.src = 'dice-' + dice1 + ".png";

        var diceDOM2 = document.querySelector("#dice-2"); 
        diceDOM2.style.display = "block";
        diceDOM2.src = 'dice-' + dice2 + ".png";

        // If player rolls two 6's in a row
        if (dice1 === 6 && dice2 === 6) {

            // Player Loses Score
            scores[activePlayer] = 0;
            document.querySelector('#score-' + activePlayer).textContent = '0';
            nextPlayer();
        
        // If player does not roll a 1
        } else if (dice1 !== 1 && dice2 !== 1) {

            // Add score
            roundScore += dice1 += dice2;
            document.querySelector("#current-" + activePlayer).innerHTML = roundScore;

        } else {

            // Next Player
            nextPlayer();
        }

        lastDice = dice2;
    }
});

document.querySelector(".btn-hold").addEventListener("click", function() {
    if (gameActive){

        // Add CURRENT score to GLOBAL score
        scores[activePlayer] += roundScore;

        // Update UI
        document.querySelector("#score-" + activePlayer).innerHTML = scores[activePlayer];


        var input = document.querySelector('.new-winning-score').value;
        var winningScore;

        if(input) {
            winningScore = input;
        } else {
            winningScore = 100;
        }

        // Check if player won the game
        if (scores[activePlayer] >= winningScore) {
            document.querySelector("#name-" + activePlayer).innerHTML = "Winner!";
            document.querySelector(".dice").style.display = "none";
            document.querySelector(".player-" + activePlayer + "-panel").classList.add("winner");
            document.querySelector(".player-" + activePlayer + "-panel").classList.remove("active");
            gameActive = false;
        } else {
            nextPlayer();  
        }
    }
});



document.querySelector(".btn-new").addEventListener("click", init);

function init() {
    scores = [0,0];
    activePlayer = 0;
    roundScore = 0;
    gameActive = true;
    rolls = [];
    document.querySelector("#dice-1").style.display = "none";
    document.querySelector("#dice-2").style.display = "none";
    document.getElementById("score-0").innerHTML = 0;
    document.getElementById("score-1").innerHTML = 0;
    document.getElementById("current-0").innerHTML = 0;
    document.getElementById("current-1").innerHTML = 0;
    document.getElementById("name-0").innerHTML = "Player 1";
    document.getElementById("name-1").innerHTML = "Player 2";
    document.querySelector(".player-0-panel").classList.remove("winner");
    document.querySelector(".player-1-panel").classList.remove("winner");
    document.querySelector(".player-0-panel").classList.remove("active");
    document.querySelector(".player-1-panel").classList.remove("active");
    document.querySelector(".player-0-panel").classList.add("active");
}

function nextPlayer() {
    activePlayer === 0 ? activePlayer = 1 : activePlayer = 0;
    roundScore = 0;
    document.getElementById("current-0").innerHTML = 0;
    document.getElementById("current-1").innerHTML = 0;
    document.querySelector(".player-0-panel").classList.toggle('active');
    document.querySelector(".player-1-panel").classList.toggle('active');
    document.querySelector("#dice-1").style.display = "none";
    document.querySelector("#dice-2").style.display = "none";
}