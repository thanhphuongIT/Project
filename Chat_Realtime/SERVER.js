// add lib express
var express= require("express");
const { Socket } = require("dgram");
const { emit } = require("process");
var app = express();
app.use(express.static("public"));
app.set("view engine", "ejs");
app.set("views","./views");

// setup server and socket
var server = require("http").Server(app);
var io= require("socket.io")(server);
server.listen(3000);
// Listen
var Userrequest=[];
var Userreply=[];

io.on("connection", function(socket){
    console.log("CO NGUOI KET NOI " + socket.id);
    //request
    socket.on("user-request", function(data){
        Userrequest.push({
            id: socket.id,
            username: data
        });
        socket.emit("request-name", data);
    });
    socket.on("sent-request",function(data){
        console.log(data.user + ":" + data.nd);
        Userreply.forEach(element => {
            socket.to(element.id).emit("sent-request-to-reply",data);
        });
    });
    //relply
    socket.on("user-reply", function(data){
        Userreply.push({
            id: socket.id,
            username: data
        });
        socket.emit("reply-name", data);
        console.log(data);
    });
    socket.on("sent-reply",function(data){
        Userrequest.forEach(element => {
            if(element.username == data.user)
            socket.to(element.id).emit("sent-reply",data);
        });
    });
    socket.on("sent-reply-image",function(data){
        Userrequest.forEach(element => {
            if(element.username == data.user)
            socket.to(element.id).emit("sent-reply-image",data);          
        });
    });
});

//render page
app.get("/", function(reg, res){
 res.render("Home");
});
