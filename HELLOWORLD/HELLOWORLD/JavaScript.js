//alert("Hello World");  // 这是单行注释  弹框函数
/* 这是多行注释 */
/*
var datenow = new Date();
alert(datenow.toString());
alert(datenow.toLocaleString());
*/

function showtime()
{
    var datenow = new Date()
    alert(datenow.toLocaleString());
    return false;  //返回执行的结果
}

function varTest()
{
    var a;
    a = null;
    alert(typeof (a));  //返回a 变量的类型
    alert(a);
    a = "100";
    alert(typeof (a));

    alert(parseInt(a) + 1);   // 将字符串转换成 int 类型 

}

function equalTest() {

    var a;
    var b = null;
    if (a === b)
    {
        alert("ok");
        
}
    else {
        alert("ng");

    }
}


function varJust(s) {

   
    if (typeof (s) != undefined) {

        if (s != null) {

            alert("OK")
        }
        else {

            alert("ng");
        }
    }
    else {

        alert("ng");
    }

}
document.getElementById('nimingTest_bt').onclick = function () { alert("100"); };  //匿名方法

// 流式加载 ，先加载 javascript 代码  会报错 因为找不到 nimingTest_bt  这个按钮   


