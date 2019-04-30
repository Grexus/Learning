var esjLint = require("ejs-lint")
var express = require("express");
var app = express();

app.get("/", function(req, res){
    res.send("Hi there!")
})

app.get("/bye", function(req, res){
    res.send("Good Bye!")
})

app.get("/dog", function(req, res){
    res.send("Meow")
})

app.get("/:name/comments", function(req, res){
    let pageName = req.params.name.toUpperCase();
    res.send("Welcome to comments section of " + pageName);
})

app.get("*", function(req, res){
    res.send("You are a star!")
})

app.listen(3000, function(){
    console.log("Server Running on localhost:3000")
})