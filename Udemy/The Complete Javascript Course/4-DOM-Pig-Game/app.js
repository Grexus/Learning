/*
GAME RULES:

- The game has 2 players, playing in rounds
- In each turn, a player rolls a dice as many times as he whishes. Each result get added to his ROUND score
- BUT, if the player rolls a 1, all his ROUND score gets lost. After that, it's the next player's turn
- The player can choose to 'Hold', which means that his ROUND score gets added to his GLBAL score. After that, it's the next player's turn
- The first player to reach 100 points on GLOBAL score wins the game

*/
var scores, roundScore, activePlayer, dice;

scores = [0,0];
roundScore = 0;
activePlayer = 0;

dice = Math.floor(Math.random() * 6) + 1;

document.querySelector(".dice").style.display = "none";

document.getElementById("score-0").innerHTML = 0;
document.getElementById("score-1").innerHTML = 0;
document.getElementById("current-0").innerHTML = 0;
document.getElementById("current-1").innerHTML = 0;

document.querySelector(".btn-roll").addEventListener("click", function() {
    
    // Get Random Number
    var dice = Math.floor(Math.random() * 6) + 1;

    // Display Result
    var diceDOM = document.querySelector(".dice"); 
    diceDOM.style.display = "block";
    diceDOM.src = 'dice-' + dice + ".png";

    // Update score IF rolled number is NOT '1'
    if (dice !== 1) {

        // Add score
        roundScore += dice;
        document.querySelector("#current-" + activePlayer).innerHTML = roundScore;
    } else {

        // Next Player
        nextPlayer();
    }
});

document.querySelector(".btn-hold").addEventListener("click", function() {
    // Add CURRENT score to GLOBAL score
    scores[activePlayer] += roundScore;

    // Update UI
    document.querySelector("#score-" + activePlayer).innerHTML = scores[activePlayer];

    // Check if player won the game
    if (scores[activePlayer] >= 10) {
        document.querySelector("#name-" + activePlayer).innerHTML = "Winner!";
        document.querySelector(".dice").style.display = "none";
        document.querySelector(".player-" + activePlayer + "-panel").classList.add("winner");
        document.querySelector(".player-" + activePlayer + "-panel").classList.remove("active");
    } else {
        nextPlayer();  
    }
});

function nextPlayer() {
    activePlayer === 0 ? activePlayer = 1 : activePlayer = 0;
    roundScore = 0;
    document.getElementById("current-0").innerHTML = 0;
    document.getElementById("current-1").innerHTML = 0;
    document.querySelector(".player-0-panel").classList.toggle('active');
    document.querySelector(".player-1-panel").classList.toggle('active');
    document.querySelector(".dice").style.display = "none";
}