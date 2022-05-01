let goUp = '<svg width="24" height="24" viewBox="0 0 48 48" fill="none"><path d="M23.063 13.171a1.2 1.2 0 011.874 0l13.503 16.88c.629.785.07 1.949-.937 1.949H10.497c-1.006 0-1.566-1.164-.937-1.95l13.503-16.879z" fill="#f5222d"/></svg>';
let goDown = '<svg width="24" height="24" viewBox="0 0 48 48" fill="none"><path d="M24.937 34.829a1.2 1.2 0 01-1.874 0L9.56 17.949C8.93 17.165 9.49 16 10.497 16h27.006c1.007 0 1.566 1.164.937 1.95L24.937 34.829z" fill="#52c41a"/></svg>';

document.getElementById("number1").innerHTML = "RM" + totalIncome;
document.getElementById("number2").innerHTML = paymentsNum;
document.getElementById("number3").innerHTML = "RM" + ATV;
document.getElementById("number4").innerHTML = "RM" + HRE;

document.getElementById("summary1").innerHTML = "Average daily income: " + "RM" + totalIncome_AD;
document.getElementById("summary2").innerHTML = "Average daily payments: " + paymentsNum_AD;
document.getElementById("summary3").innerHTML = "Average daily ATV: " + "RM" + ATV_AD;
document.getElementById("summary4").innerHTML = "Average daily HRE: " + "RM" + HRE_AD;

document.getElementById("text1").innerHTML = `Week on week:  ${toPercent(weekOn)}  ` + getIcon(weekOn);
document.getElementById("text2").innerHTML = `Day on day:  ${toPercent(dayOn)}  ` + getIcon(dayOn);

document.getElementById("name1").innerHTML = top_saler[0];
document.getElementById("sale1").innerHTML = "RM" + top_saler_value[0];
document.getElementById("name2").innerHTML = top_saler[1];
document.getElementById("sale2").innerHTML = "RM" + top_saler_value[1];
document.getElementById("name3").innerHTML = top_saler[2];
document.getElementById("sale3").innerHTML = "RM" + top_saler_value[2];
document.getElementById("name4").innerHTML = top_saler[3];
document.getElementById("sale4").innerHTML = "RM" + top_saler_value[3];
document.getElementById("name5").innerHTML = top_saler[4];
document.getElementById("sale5").innerHTML = "RM" + top_saler_value[4];
document.getElementById("name6").innerHTML = top_saler[5];
document.getElementById("sale6").innerHTML = "RM" + top_saler_value[5];
document.getElementById("name7").innerHTML = top_saler[6];
document.getElementById("sale7").innerHTML = "RM" + top_saler_value[6];


function toPercent(point) {
    if (point == 0) {
        return 0;
    }
    var str = Number(point * 100).toFixed();
    str += "%";
    return str;
}

function getIcon(value) {
    if (value < 0) {
        return goDown;

    } else if (value > 0) {
        return goUp;
    }
}

function refresh() {
    location.reload();
}

var currentMonth = new Date().getMonth();
monthList = [];
monthName = {
    0: 'Jan',
    1: 'Feb',
    2: 'Mar',
    3: 'Apr',
    4: 'May',
    5: 'Jun',
    6: 'Jul',
    7: 'Aug',
    8: 'Sept',
    9: 'Oct',
    10: 'Nov',
    11: 'Dec'
};
for (i = 0; i < 12; i++) {
    index = currentMonth - i;

    if (index < 0) {
        index = 12 + index;
    }

    monthList.unshift(monthName[index])
}

var ctxPay = document.getElementById("myLineChart1").getContext('2d');
var myChartPay = new Chart(ctxPay, {
    type: 'line',
    data: {
        //labels: ["Red", "Blue", "Yellow", "Green", "Purple", "Orange", "seven"],
        labels: monthList,
        datasets: [
            {
                label: 'Payments',
                fill: true,
                lineTension: 0.4,
                pointRadius: 0,
                borderColor: "#d91ad9",
                backgroundColor: "rgba(217, 26, 217, 0.2)",
                //pointRadius: 6,
                data: paymentsNum_month,
                borderWidth: 1
            }
        ]
    },
    options: {
        responsive: true,
        maintainAspectRatio: false,
        pointDotRadius: 0,
        interaction: {
            mode: 'index',
            intersect: false,
        },
        plugins: {
            legend: {
                display: false,
            },
            title: {
                display: false
            }
        },
        scales: {
            x: {
                display: false,
                grid: {
                    color: "rgba(242, 243, 245,1)"
                },
                title: {
                    display: true,
                    text: 'Month'
                }
            },
            y: {
                display: false,
                min: 0,
                grid: {
                    color: "rgba(242, 243, 245,1)"
                }
            }
        },

    }
});


var ctxATV = document.getElementById("mybarChart1").getContext('2d');
var myBarChartATV = new Chart(ctxATV, {
    type: "bar",
    data: {
        labels: monthList,

        datasets: [{
            //borderRadius: 10,
            backgroundColor: ['rgba(64, 134, 255, 0.9)', 'rgba(64, 134, 255, 0.9)', 'rgba(64, 134, 255, 0.9)'],
            data: ATV_month,
        }],
    },
    options: {
        responsive: true,
        maintainAspectRatio: false,
        plugins: {
            legend: {
                display: false,
            },
            title: {
                display: false
            }
        },
        barThickness: 10,

        scales: {
            y: {
                display: false
            },
            x: {
                display: false
            },
        }

    }
});


var ctxHRE = document.getElementById("myLineChart2").getContext('2d');
var myChartHRE = new Chart(ctxHRE, {
    type: 'line',
    data: {
        //labels: ["Red", "Blue", "Yellow", "Green", "Purple", "Orange", "seven"],
        labels: monthList,
        datasets: [
            {
                label: 'Payments',
                fill: true,
                lineTension: 0.4,
                pointRadius: 0,
                borderColor: "#34c9ca",
                backgroundColor: "rgba(52, 201, 202, 0.2)",
                //pointRadius: 6,
                data: HRE_month,
                borderWidth: 1
            }
        ]
    },
    options: {
        responsive: true,
        maintainAspectRatio: false,
        pointDotRadius: 1,
        interaction: {
            mode: 'index',
            intersect: false,
        },
        plugins: {
            legend: {
                display: false,
            },
            title: {
                display: false
            }
        },
        scales: {
            x: {
                display: false,
                grid: {
                    color: "rgba(242, 243, 245,1)"
                },
                title: {
                    display: true,
                    text: 'Month'
                }
            },
            y: {
                display: false,
                min: 0,
                grid: {
                    color: "rgba(242, 243, 245,1)"
                }
            }
        },

    }
});


var ctxIncome = document.getElementById("incomeBarChart").getContext('2d');
var myBarChartIncome = new Chart(ctxIncome, {
    type: "bar",
    data: {
        labels: monthList,

        datasets: [{
            //borderRadius: 10,
            backgroundColor: ['rgba(64, 134, 255, 0.9)', 'rgba(64, 134, 255, 0.9)', 'rgba(64, 134, 255, 0.9)'],
            data: month_Income,
        }],
    },
    options: {
        responsive: true,
        maintainAspectRatio: false,

        plugins: {
            legend: {
                display: false,
            },
            title: {
                display: false
            }
        },
        barThickness: 20,

        scales: {
            y: {
                display: true,
                grid: {
                    color: "rgba(232, 232, 232,0.5)",
                }
            },
            x: {
                display: true,
                grid: {
                    display: false,
                }
            },
        }

    }
});

var ctxTime = document.getElementById('myLineChartTime').getContext('2d');
var myChartTime = new Chart(ctxTime, {
    type: 'line',
    data: {
        //labels: ["Red", "Blue", "Yellow", "Green", "Purple", "Orange", "seven"],
        labels: [1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24],
        datasets: [
            {
                label: 'Order quantity',
                fill: true,
                lineTension: 0.4,
                pointRadius: 1,
                borderColor: "#4080ff",
                backgroundColor: "rgba(22, 93, 255, 0.2)",
                //pointRadius: 6,
                data: time_value,
                borderWidth: 1
            }
        ]
    },
    options: {
        responsive: true,
        maintainAspectRatio: false,
        pointDotRadius: 1,
        interaction: {
            mode: 'index',
            intersect: false,
        },
        plugins: {
            legend: {
                display: false,
            },
            title: {
                display: true,
                text: 'Monthly income per hour'
            }
        },
        scales: {
            x: {
                display: true,
                grid: {
                    display: false,
                    //color: "rgba(242, 243, 245,1)"
                },
                title: {
                    display: true,
                    text: 'Hour'
                }
            },
            y: {
                display: true,
                min: 0,
                grid: {
                    color: "rgba(242, 243, 245,1)"
                }
            }
        },

    }
});

var ctxServerType = document.getElementById('myPieChartServerType').getContext('2d');
var myChartServerType = new Chart(ctxServerType, {
    type: "doughnut",
    data: {
        labels: ["Virus", "Run slow", "Screen", "Keyboard", "Battery", "OS", "Data", "Internet"],
        datasets: [
            {
                data: server_type_income,
                backgroundColor: [
                    "#00B42A",
                    "#14C9C9",
                    "#FADC19",
                    "#FF7D00",
                    "#F53F3F"
                ]
            }
        ]
    },
    options: {
        maintainAspectRatio: false,
        responsive: true,
        plugins: {
            legend: {
                position: "right"
            },
            title: {
                display: true,
                text: 'Ratio of service type to income'
            }
        }
    }
});


var ctxMethod = document.getElementById('myPieChartMethod').getContext('2d');
var myChartMethod = new Chart(ctxMethod, {
    type: "doughnut",
    data: {
        labels: ['Credit Card', 'Paypal', 'Cash', 'Check'],
        datasets: [
            {
                data: payment_method,
                backgroundColor: [
                    "#00B42A",
                    "#14C9C9",
                    "#FADC19",
                    "#FF7D00"
                ]
            }
        ]
    },
    options: {
        maintainAspectRatio: false,
        responsive: true,
        plugins: {
            legend: {
                position: "right"
            },
            title: {
                display: true,
                text: 'Payment method ratio'
            }
        },

    }
});
