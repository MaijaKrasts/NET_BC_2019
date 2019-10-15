// JavaScript source code
/*document.getElementById('ok').onClick = function () {
    var name = document.getElementById('name').value;
    var age = document.getElementById('age').value;

    var text = "Your name is " + name + " and you're " + age + " years old";

    document.getElementById("result").innerHTML = text;
    document.getElementById('ok').style.display = 'none';
}*/

$(function () {
    $('#ok').click(function () {
        var name = $("#name").val();
        var age = parseInt($("#age").val());
        age += 5;

        var text = "Your name is " + name + " and you're " + age + " years old";

        $("#result").html(text);
        $("#ok").hide();

    })
    $('#add').click(function () {

        var n1 = parseInt($("#num1").val());
        var n2 = parseInt($("#num2").val());

        var sum = n1 + n2;

        $("#result").html(sum);
    })

    $('#minus').click(function () {

        var n1 = parseInt($("#num1").val());
        var n2 = parseInt($("#num2").val());

        var div = n1 - n2;

        $("#result").html(div);
    })
})