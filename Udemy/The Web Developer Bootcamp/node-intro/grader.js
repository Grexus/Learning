function average (scores) {
    let totalScore = 0;

    scores.forEach(score => {
        totalScore += score; 
    });
    
    let avgScore = totalScore / scores.length;

    console.log('The average score is ' + Math.round(avgScore));
}

let scores = [90, 98, 89, 100, 86, 94];
average(scores);