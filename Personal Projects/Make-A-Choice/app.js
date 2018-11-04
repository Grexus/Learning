let items = [];
let itemList = document.getElementsByClassName('items')[0];
let userInput = document.getElementsByClassName("input")[0];
let isDecided = false;

// Event listener on user input to run 'update' function
userInput.addEventListener('keydown', function(e){
    if (e.keyCode === 13) { // checks if 'enter' key was pressed
        update(items);
    }
})

// Update list
function update(arr){
    getInput();
    printArray(arr);
}

// Print Array
function printArray(arr){
    for (var i = 0; i < arr.length; i++){
        var item = document.createElement('span');
        item.classList.add("item");
        item.innerHTML = arr[i];
        itemList.appendChild(item);
    }
}

// Get and Print input
function getInput(){
    // Push user input into 'items' array
    items.push(userInput.value);
    
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