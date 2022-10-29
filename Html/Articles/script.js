let titlePara = "[News]Within evidence those dinner form left recognize.";
let posterPara = "Kevin Hodges";
let staffpostPara = "Receptionist";
let viewsPara = "9877";
let likesPara = "9083";
let timePara = "2021/12/28 13:52:09";
let urlPara = "Art000186.html";

function refresh() {
    location.reload();
}


let botoomBtns = document.createElement("div");
botoomBtns.id = "botoomBtns";
botoomBtns.innerHTML = `
    <button id="menu">Back to article list</button>
    `;
if (document.getElementById("artical")) {
    document.getElementById("artical").append(botoomBtns);
}



var jsonData;
var theme;
let btns = document.getElementById("btns").children;
window.onload = function () {
    let btnColor;
    if (theme == "dark") {
        document.body.style.backgroundColor = "#121f2b";
        document.body.style.color = "white";
        btnColor = "white";
    }
    else if (theme == "light") {
        document.body.style.backgroundColor = "white";
        document.body.style.color = "black";
        btnColor = "black";
    }
    for (let index = 0; index < btns.length; index++) {
        const element = btns[index];
        element.style.color = btnColor;
    }
    menu.style.color = btnColor;
}

let scriptObj = document.createElement("script");
scriptObj.src = "noticeIndex.json?callback=getData";
document.body.append(scriptObj);

function getJson(data) {
    jsonData = data;
    //console.log(jsonData["0"]["theme"]);
    theme = jsonData["0"]["theme"];
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
    <div  class='iconAndWord icon' id='chakan'>
        <span class="iconfont icon-chakan"></span>
        <span class='word'>${viewInt}</span>
    </div>
    <div  class='iconAndWord icon' id='love'>
        <span class="iconfont icon-love"></span>
         <span class='word' id='likeNum'>${likeInt}</span>
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


let menu = document.getElementById("menu");




menu.onclick = function () {
    history.back()
};



