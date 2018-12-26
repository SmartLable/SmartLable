var left = 0;
var dri = 1;
onload = function () {
    this.setInterval(fun, 100);
    document.getElementById('btn1').onclick = function () {
        alert(this.value);
    }//匿名函数 
};
// onload 加载事件，当页面所有元素加载完成后 触发该事件
function fun() {
    left += 10 * dri;
    if ((left + 200) >= window.innerWidth) {

        dri = -1;
    }
    if (left <= 0) {

        dri = 1;
    }
    var msg = document.getElementById('msg');
    msg.style.left = left + 'px';

}

