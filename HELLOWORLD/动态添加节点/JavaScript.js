onload = function () {
    document.getElementById("btn2").onclick = function () {
        var img = document.createElement('img');
        img.src = 'image/bird1.png';
        document.getElementById('id1').appendChild(img);

    }
    document.getElementById('btn1').onclick = function () {

        var btn22 = document.createElement('input');   // 动态创建节点   
        btn22.type = "button";
        btn22.value = "btn22";
        document.getElementById('id1').appendChild(btn22);
    }

    document.getElementById('btn3').onclick = function () {

        var a = document.createElement('a');
        a.href = 'HtmlPage11.html';
        a.innerHTML = "this is 超链接";
        document.getElementById('id1').appendChild(a);
    }


    document.getElementById('btn4').onclick = function () {

        var childs = document.getElementById('id1').childNodes;
        for (var i = childs.length-1; i > 0; i--) {

            document.getElementById('id1').removeChild(childs[i]);
        }
    }

}