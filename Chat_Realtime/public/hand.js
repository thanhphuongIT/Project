var socket = io("http://localhost:3000")
//SOCKET.ON
var username;
        //request
socket.on("request-name", function(data){
    username = data;
});
        //replay
socket.on("reply-name",function(data){
    username = data;
});
socket.on("sent-request-to-reply",function(data){
    $("#boxContent").append("<div id="+data.user+">"+data.user+":"+data.nd+"</div>");
});
socket.on("sent-reply",function(data){
    $("#lisRequest").append("<h4>" + data.userreply+":"+data.nd);
});
socket.on("sent-reply-image",function(data){
    alert(1);
    $("#lisRequest").append("<img src='"+data.nd+"' width='100px' height='100px' />");
});
// ready
$(document).ready(function(){
    $("#loginform").show();
    $("#request-form").hide();
    $("#reply-form").hide();
    //request
    $("#btnrequest").click(function(){
        $("#request-form").show();
        $("#loginform").hide();
        socket.emit("user-request", $("#txtUsername").val());
    });
    $("#btnsentRequest").click(function(){
            socket.emit("sent-request",
            {
                user: username,
                nd: $("#txtRequest").val()
            });
    });
    //replay
    $("#btnreply").click(function(){
        $("#reply-form").show();
        $("#loginform").hide();
        socket.emit("user-reply", $("#txtUsername").val());
    });
    var userchatnow;
    $("#boxContent").on('click','div',function () {
        $("#listMessages").html(document.getElementById(this.id).innerHTML);
        userchatnow=this.id;
    });
    $("#btnSentMessage").click(function(){
        socket.emit("sent-reply",
        {
            user: userchatnow,
            userreply: username,
            nd: $("#txtMessage").val()
        });
    });
    $("#btnsentimage").click(function(){
        socket.emit("sent-reply-image",
        {
            user: userchatnow,
            userreply: username,
            nd: $("#txtMessage").val()
        });
    });
});