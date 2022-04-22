let titlePara = document.title;
let posterPara = "Kevin Hodges";
let staffpostPara = "Receptionist";
let viewsPara = "9999";
let likesPara = "9999";
let timePara = "2021/12/28 13:52:09";
let urlPara = document.title;

function refresh() {
    location.reload();
}


function insertTitle(titleStr) {
    var title = document.getElementById("title");
    title.innerHTML = `<h1>${titleStr}</h1>`;
}
insertTitle(titlePara);

function insertPoster(posterStr, staffStr) {
    var poster = document.getElementById("poster");
    poster.innerHTML = `
    <div id='poster'>
        <div id='nameIcon'>
            <span id='first'>${posterStr[0]}<span>
        </div>
        <div id='nameAndstaff'>
            <h4 id='name'>${posterStr}</h4>
            <p id='staff'>${staffStr}</p>
        </div>
    </div>
    `;
}
insertPoster(posterPara, staffpostPara);

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
    <div id='qrcode'></div>
    <div></div>
    <div></div>
    <div id='chakan'>
    </div>
    <div id='love'>
    </div>`;
}
insertInfo(viewsPara, likesPara);

function insertTime(timeStr) {
    var time = document.getElementById("time");
    time.innerHTML = `${timeStr.substring(0, 19)}`;
}
insertTime(timePara);



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



var ifClick = false;
let BtnLove = document.getElementById("love");
BtnLove.onclick = function () {
    if (ifClick == false) {
        addLike();
        BtnLove.style.background = "#F53F3F";
        bound.add1ToLikes();
        alert("Thanks for participation!")
        BtnLove.disabled = "ture";
        ifClick = true;
    }
}

var likeNum = document.getElementById("likeNum");
function addLike() {
    likesPara++;
    likeNum.innerHTML = likesPara;
}
function generaterbg() {
    //create background
    var bg = document.createElement("div");
    bg.innerText = "";
    bg.id = 'bg';
    bg.style.position = "absolute";
    bg.background = "rgb(187, 191, 196)";
    document.body.appendChild(bg);
}
generaterbg()

function gernerateQR(platform) {
    let sw = document.documentElement.scrollWidth;
    let sh = document.documentElement.scrollHeight;

    let cw = document.documentElement.clientWidth;
    let ch = document.documentElement.clientHeight;

    if (document.getElementById("fwin")) {
        document.getElementById("fwin").remove();
        document.getElementById("bg").remove();
    } else {
        //use background
        document.getElementById("bg").className = "bg"
        document.getElementById("bg").style.cssText = `height:${sh}px`;
        //alert("hi")

        // create qrcode contaioner
        var div = document.createElement("div");
        div.innerText = "";
        div.id = 'fwin';
        div.style.position = "absolute";
        let qrcode = document.getElementById("qrcode");
        //document.body.appendChild(div);
        qrcode.appendChild(div);

        div.style.left = (cw - 200) / 2 + "px";
        div.style.top = (ch - 200) / 2 + window.pageYOffset + "px";
    }
    var qrcode = new QRCode(document.getElementById("fwin"), {
        width: 200,
        height: 200
    });

    qrcode.makeCode(urlPara + platform);
}
var qrcode = document.getElementById("qrcode");
qrcode.onclick = function showHW(e) {
    e.stopPropagation();
    document.getElementById("fwin").remove();
    document.getElementById("bg").className = "";
    document.getElementById("bg").style.cssText = `0px`;
}
var bg = document.getElementById("bg");
bg.onclick = function () {
    document.getElementById("bg").className = "";
    document.getElementById("fwin").remove();
    document.getElementById("bg").style.cssText = `0px`;
}



var facebook = document.getElementById("icon1");
facebook.onclick = function showHW() {
    gernerateQR("facebook");
}
var ins = document.getElementById("icon2");
ins.onclick = function showHW() {
    gernerateQR("ins");
}
var twitter = document.getElementById("icon3");
twitter.onclick = function showHW() {
    gernerateQR("twitter");
}
var whatsapp = document.getElementById("icon4");
whatsapp.onclick = function showHW() {
    gernerateQR("whatsapp");
}


// var qrcode1 = document.getElementById("fwin");
// qrcode1.onclick = function hideqr() {
//     console.log("hi");
// }


