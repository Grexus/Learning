var app = new Vue ({
    el: ".app",
    data: {
        itemArray: [],
        finalDecision: '',
        isDecided: false
    },
    methods: {
        addToArray: function() {
            if(!this.isDecided){
                this.itemArray.push(this.$refs.userInput.value);
                this.$refs.userInput.value = '';
            }
        },
        decide: function(arr){
            if(!this.isDecided){
                let randomNumber = Math.floor(Math.random() * arr.length);
                this.finalDecision = arr[randomNumber];
                this.isDecided = true;
            }
        },
        removeItem: function(){}
    }
})