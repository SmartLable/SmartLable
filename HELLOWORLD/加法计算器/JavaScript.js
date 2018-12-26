onload = function () {

    document.getElementById('add').onclick = function () {

        var num1 = parseInt(document.getElementById('num1').value);
        var num2 = parseInt(document.getElementById('num2').value);
        var result = num1 + num2;
        document.getElementById('num3').value = result;

    }
}