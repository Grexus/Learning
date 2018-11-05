var tut1 = new Vue({
    el: '.declarative-rendering',
    data: {
        message1: 'Hello Vue!',
        message2: 'This page is loaded on ' + new Date().toLocaleString()
    }
})

var tut2 = new Vue({
    el: '.conditionals-loops',
    data: {
        seen: true,
        array: [
            { text: 'Learn JavaScript' },
            { text: 'Learn VueJS' },
            { text: 'Profit $$$' }
        ]
    },
    methods: {
        alterSeen: function(){
            if(tut2.seen){
                tut2.seen = false;
            } else {
                tut2.seen = true;
            }
        }
    }
})

var tut3 = new Vue({
    el: '.user-input',
    data: {
        message3: 'Hello VueJS',
        message4: 'Initial Message4',
        itemInput: '',
        itemArray: []
    },
})

var tut4 = new Vue({
    el: '.experiment',
    data: {
        array: []
    },
    methods: {
        addToArray: function(){
            let input = document.getElementsByClassName('input')[0];
            tut4.array.push(input.value);
            input.value = "";
        }
    }
})