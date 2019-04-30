var express = require("express");
var app = express();

app.get("/", function(req, res){
    res.send("Hi there, welcome to my assignment :)");
})

app.get("/speak/:animal", function(req, res){
    let animal = req.params.animal.toLowerCase();
    switch (animal){
        case "pig":
            res.send("Oink");
            break;
        case "cow":
            res.send("Moo");
            break;
        case "dog":
            res.send("Woof");
            break;
        default:
            res.send("Animal not found");
    }
})

app.get("/repeat/:text/:number", function(req, res){
    let text = req.params.text;
    let repeatVal = Number(req.params.number);
    let returnText = "";

    for (i = 0; i < repeatVal; i++) {
        returnText += text + " ";
    }
    res.send(returnText);
})

app.get("*", function(req, res){
    res.send("Sorry, page not found... What are you doing with your life?");
})

app.listen(3000, function(){
    console.log("Server Running on localhost:3000")
})