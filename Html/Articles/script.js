/*
 * @Author: Innis
 * @Description: 
 * @Date: 2022-04-21 13:26:26
 * @LastEditTime: 2022-04-21 20:24:59
 * @FilePath: \Articles\script.js
 */
let type = "Message"
let titlePara = `[${type}] ` + "I like coding"
let posterPara = "Innis"
let staffpostPara = "Receptionist"
let viewsPara = 8005
let likesPara = 8346
let timePara = "2022-03-27 14:48:41.000"
let urlPara = "https://blog.csdn.net/YouZaiYouZaia/article/details/78705603";

function insertTitle(titleStr) {
    var title = document.getElementById("title");
    title.innerHTML = `<h1>${titleStr}</h1>`;
}
insertTitle(titlePara)

function insertPoster(posterStr, staffStr) {
    var poster = document.getElementById("poster");
    poster.innerHTML = `
    <div id='icon'>
        <span id='first'>${posterStr[0]}<span>
    </div>
    <h4 id='name'>${posterStr}</h4>
    <p id='staff'>${staffStr}</p>
    `;
}
insertPoster(posterPara, staffpostPara)

function insertInfo(viewInt, likeInt) {
    var info = document.getElementById("info");
    info.innerHTML = `
    <div id='share'>Share to:</div>
    <div class='icon' id='icon1'>
        <span class="iconfont icon-facebook-fill"></span>
    </div>
    <div class='icon' id='icon2'>
        <span class="iconfont icon-instagram-fill"></span>
    </div>
    <div class='icon' id='icon3'>
        <span class="iconfont icon-twitter"></span>
    </div>
    <div class='icon' id='icon4'>
        <span class="iconfont icon-whatsapp"></span>
    </div>
    <div></div>
    <div></div>
    <div></div>
    <div  class='iconAndWord icon' id='chakan'>
        <span class="iconfont icon-chakan"></span>
        <span class='word'>${viewInt}</span>
    </div>
    <div  class='iconAndWord icon' id='love'>
        <span class="iconfont icon-love"></span>
         <span class='word' id='likeNum'>${likeInt}</span>
    </div>`;
}
insertInfo(viewsPara, likesPara)

function insertTime(timeStr) {
    var time = document.getElementById("time");
    time.innerHTML = `${timeStr.substring(0, 19)}`;
}
insertTime(timePara)



var oPtxt = document.getElementById("artical");
var oBtn1 = document.getElementById("Btn1");
var oBtn2 = document.getElementById("Btn2");
var oBtn3 = document.getElementById("Btn3");
var num = 16;
oBtn1.onclick = function () {
    num++;
    oPtxt.style.fontSize = num + 'px';
};
oBtn2.onclick = function () {
    oPtxt.style.fontSize = 16 + 'px';
}
oBtn3.onclick = function () {
    num--;
    oPtxt.style.fontSize = num + 'px';

}

let BtnLove = document.getElementById("love");
BtnLove.onclick = function () {
    addLike();
    BtnLove.style.background = "#F53F3F";
    //console.log("Hi")
}

var likeNum = document.getElementById("likeNum");
function addLike() {
    likesPara++;
    likeNum.innerHTML = likesPara
}

function gernerateQR(platform) {
    let sw = document.documentElement.scrollWidth;
    let sh = document.documentElement.scrollHeight;

    let cw = document.documentElement.clientWidth;
    let ch = document.documentElement.clientHeight;

    if (document.getElementById("fwin")) {
        //console.log("exist1");
        document.getElementById("fwin").remove();

    } else {
        var div = document.createElement("div");
        div.innerText = "";
        div.id = 'fwin';
        div.style.position = "absolute";
        document.body.appendChild(div);

        div.style.left = (cw - 200) / 2 + "px"
        div.style.top = (ch - 200) / 2 + window.pageYOffset + "px"


    }
    var qrcode = new QRCode(document.getElementById("fwin"), {
        width: 200,
        height: 200
    });

    qrcode.makeCode(urlPara + platform);
}


var facebook = document.getElementById("icon1");
facebook.onclick = function showHW() {
    gernerateQR("facebook")
}
var ins = document.getElementById("icon2");
ins.onclick = function showHW() {
    gernerateQR("ins")
}
var twitter = document.getElementById("icon3");
twitter.onclick = function showHW() {
    gernerateQR("twitter")
}
var whatsapp = document.getElementById("icon4");
whatsapp.onclick = function showHW() {
    gernerateQR("whatsapp")
}


var qrcode1 = document.getElementById("fwin");
qrcode1.onclick = function hideqr() {
    console.log("hi")
    //qrcode.remove();
}

