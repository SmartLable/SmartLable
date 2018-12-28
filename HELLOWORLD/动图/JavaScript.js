onload = function () {

    var imgs = document.getElementsByTagName('img');   // 获得标签名
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
            for (var j = 0; j <= id1; j++) {
                imgs[j].src = "star1.png";

            }
        }
      
    }


}