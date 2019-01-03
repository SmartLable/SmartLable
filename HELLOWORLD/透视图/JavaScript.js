onload = function () {

    var body = document.getElementsByTagName('body')[0];
    var Width = 495, height = 495, left = 10, top = 10;
    while (true) {
        var div = document.createElement('div');
        div.style.position = 'absolute';
        div.style.height = height +'px';
        div.style.width = Width + 'px';
        div.style.left = left + 'px';
        div.style.top = top + 'px';
        div.style.border = '1px solid blue';
        body.appendChild(div);
        left += 5;
        top += 5;
        Width -= 10;
        height -= 10;
        if (Width <=0) {
            break;
        }

    }




    
}