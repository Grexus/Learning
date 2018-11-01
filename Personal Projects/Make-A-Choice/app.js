let items = [];
let userInput = document.getElementsByClassName("input")[0];
let isDecided = false;

// Event listener on user input to run 'getInput' function
userInput.addEventListener('keydown', function(e){
    if (e.keyCode === 13) { // checks if 'enter' key was pressed
        getInput();
    }
})

// Get and Print input
function getInput(){
    let itemList = document.getElementsByClassName('inputs')[0];
    let item = document.createElement('div');

    // Push user input into 'items' array
    items.push(userInput.value);

    // Print new item
    item.classList.add('item');
    item.innerHTML = items[items.length - 1]; // last item in array
    itemList.appendChild(item);
    
    // Empty input field
    userInput.value = "";
}

// Decide 
function decide(arr){
    if(items.length > 0 && !isDecided){
        let decisionValue = Math.floor(Math.random() * items.length) + 1;
        let decisionContainer = document.getElementsByClassName('choice')[0];
        let decision = document.createElement('span');

        decision.classList.add('final-decision');

        decision.innerText = arr[decisionValue - 1];

        decisionContainer.appendChild(decision);

        isDecided = true;
    }
}

// Reset - WIP
function reset(){
    items = [];
    isDecided = false;
}