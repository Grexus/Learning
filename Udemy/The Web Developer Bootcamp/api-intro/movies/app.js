var express = require("express")
var request = require("request")

var app = express()
app.set("view engine", "ejs")

app.get("/results", function(req, res){
    let url = "http://www.omdbapi.com/?s="
    let search = req.query.input
    let apiKey = "&apikey=thewdb"

    request(url + search + apiKey, function(error, response, body){
        if(!error && response.statusCode == 200) {
            var data = JSON.parse(body)
            res.render("results", {data: data})
        }
    })
})

app.get("/search", function(req, res){
    res.render("search")
})

app.listen(3000, function(){
    console.log("Server Running on localhost:3000")
})