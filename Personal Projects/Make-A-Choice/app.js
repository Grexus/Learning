let items = [];
let userInput = document.getElementsByClassName("input")[0];

userInput.addEventListener('keydown', function(e){
    if (e.keyCode === 13) { // checks if 'enter' key was pressed
        getInput();
    }
})

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