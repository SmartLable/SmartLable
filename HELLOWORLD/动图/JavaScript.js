onload = function () {

    var imgs = document.getElementsByTagName('img');   // 获得标签名
    var clickindex = -1;
    for (var index in imgs) {
        imgs[index].onmouseover = function () {
            var id = this.id;
            for (var i = 0; i < imgs.length; i++) {
                if (i <= id) {
                    imgs[i].src = "star2.png";
                }
                else {
                    imgs[i].src = "star1.png";

                }
            }
        }

        imgs[index].onmouseout = function () {
            var id1 = this.id;
            for (var j = clickindex+1; j <= id1; j++) {
                imgs[j].src = "star1.png";

            }
        }
        //注册点击事件  获取当前点击的ID号 
        imgs[index].onclick = function () {   
            clickindex = parseInt(this.id);

        }
      
    }


}