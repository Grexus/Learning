const express = require("express");
const mongoose = require("mongoose");
const bodyParser = require("body-parser");
const methodOverride = require("method-override");
const expressSanitizer = require("express-sanitizer");
const app = express();

// APP CONFIG
mongoose.connect("mongodb://localhost/restful_blog");
app.use(bodyParser.urlencoded({extended: true}));
app.use(expressSanitizer());
app.set("view engine", "ejs");
app.use(express.static("public"));
app.use(methodOverride("_method"));

// MONGOOSE/MODEL CONFIG
const blogSchema = new mongoose.Schema({
    title: String,
    image: String,
    body: String,
    created: { 
        type: Date, 
        default: Date.now 
    }
});

var Blog = mongoose.model("Blog", blogSchema);

// RESTFUL ROUTES
app.get("/", function(req, res){
    res.redirect("/blogs");
});

// Index Route
app.get("/blogs", function(req, res){
    Blog.find({}, function(err, blogs){
        if(err){
            console.log(err);
        } else {
            res.render("index", {blogs: blogs});
        }
    });
});

// New Route
app.get("/blogs/new", function(req, res){
    res.render("new");
})

// Create Route
app.post("/blogs", function(req, res){

    req.body.blog.body = req.sanitize(req.body.blog.body);

    Blog.create(req.body.blog, function(err, newBlog){
        if(err){
            // Refresh page
            res.render("new");
        } else {
            // Redirect to blogs page
            res.redirect("/blogs")
        }
    })
})

app.get("/blogs/:id", function(req, res){
    Blog.findById(req.params.id, function(err, foundBlog){
        if (err) {
            console.log(err);
            res.redirect("/blogs");
        } else {
            res.render("show", {blog: foundBlog});
        }
    })
})

// Edit Route
app.get("/blogs/:id/edit", function(req, res){
    Blog.findById(req.params.id, function(err, foundBlog){
        if(err) {
            res.redirect("/blogs");
        } else {
            res.render("edit", {blog: foundBlog});
        }
    })
})

// Update Route
app.put("/blogs/:id", function(req, res){

    req.body.blog.body = req.sanitize(req.body.blog.body);

    Blog.findByIdAndUpdate(req.params.id, req.body.blog, function(err, updatedBlog){
        if(err) {
            res,redirect("/blogs");
        } else {
            res.redirect("/blogs/" + req.params.id);
        }
    })
})

// Delete Route
app.delete("/blogs/:id", function(req, res){
    Blog.findByIdAndDelete(req.params.id, function(err){
        if(err) {
            res.redirect("/blogs");
        } else {
            res.redirect("/blogs");
        }
    })
})

app.listen(3001, function(){
    console.log("RESTful Blog running on localhost:3001");
})
