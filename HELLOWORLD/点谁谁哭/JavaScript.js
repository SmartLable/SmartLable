onload = function () {
    var btn = document.getElementsByName('bt');
    for (var i = 0; i < btn.length; i++) {
        //动态注册事件  给每个按钮 注册事件  点击后 value 变成 呜呜
        btn[i].onclick = function () {
            if (this.value == "哈哈") {
                this.value = "呜呜";
            }
            else {
                this.value = "哈哈";
            }
           
        }
    }

}