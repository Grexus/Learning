var express = require("express");
var bodyParser = require("body-parser");

var app = express();


app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());

app.use(express.static("public"));
app.set("view engine", "ejs");

var friends = ["Jon", "Joe", "Tammy", "Joan", "Bill"];

app.get("/", function(req, res){
    res.render("home");
})

app.post("/addFriend", function(req, res){
    let newFriend = req.body.newFriend;
    friends.push(newFriend);
    res.redirect("/friends");
})

app.get("/friends", function(req, res){
    res.render("friends", {friends: friends});
})

app.listen(3000, function(){
    console.log("Server Running on localhost:3000")
})