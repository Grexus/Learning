var express = require("express");
var app = express();

app.use(express.static("public"));
app.set("view engine", "ejs")

app.get("/", function(req, res){
    res.render("home");
})

app.get("/posts", function(req, res){
    let posts = [
        { 
            title: "Post 1",
            author: "Susie"
        },
        { 
            title: "Post 2",
            author: "Charlie"
        },
        { 
            title: "Post 3",
            author: "Jonathan"
        }
    ];

    res.render("posts", {posts: posts});
})

app.get("/fallinlovewith/:thing", function(req, res){
    var thing = req.params.thing;
    res.render("love", {thingVar: thing});
})

app.listen(3000, function(){
    console.log("Server Running on localhost:3000")
})