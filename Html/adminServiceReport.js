function refresh() {
    location.reload();
}

document.getElementById("num1").innerHTML = monthOrders;
document.getElementById("num2").innerHTML = monthFinised;
document.getElementById("num3").innerHTML = monthCustomers;
document.getElementById("aveServer").innerHTML = averageService;
document.getElementById("aveRepair").innerHTML = averageRepair;

document.getElementById("littleChart-num1").innerHTML = order_quantity;
document.getElementById("littleChart-num2").innerHTML = new_customers;
document.getElementById("littleChart-num3").innerHTML = service_score;
document.getElementById("littleChart-num4").innerHTML = completion_speed;

changeColor(document.getElementById("littleChart-percent1"), order_quantity_per);
changeColor(document.getElementById("littleChart-percent2"), new_customers_per);
changeColor(document.getElementById("littleChart-percent3"), service_score_per);
changeColor(document.getElementById("littleChart-percent4"), completion_speed_per);

function changeColor(obj, value) {
    if (value > 0) {
        obj.innerHTML = "+" + toPercent(value);
        obj.style.color = "red";
    } else if (value < 0) {
        obj.innerHTML = toPercent(value);
        obj.style.color = "green";
    }
}

function toPercent(point) {
    if (point == 0) {
        return 0;
    }
    var str = Number(point * 100).toFixed();
    str += "%";
    return str;
}

function refresh() {
    location.reload();
}

var monthList = [];

var currentMonth = new Date().getMonth();
//console.log(currentMonth)

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

function show() {
    var ctx = document.getElementById("myChart1").getContext('2d');
    var myChart = new Chart(ctx, {
        type: 'line',
        data: {
            //labels: ["Red", "Blue", "Yellow", "Green", "Purple", "Orange", "seven"],
            labels: monthList,
            datasets: [
                {
                    label: 'Virus',
                    fill: true,
                    lineTension: 0.4,
                    borderColor: "#F53F3F",
                    backgroundColor: "rgba(22, 93, 255, 0.2)",
                    //pointRadius: 6,
                    data: dataset1,
                    borderWidth: 1
                },
                {
                    label: 'Run slow',
                    fill: true,
                    lineTension: 0.4,
                    borderColor: "#FF7D00",
                    backgroundColor: "rgba(255, 125, 0, 0.2)",
                    //pointRadius: 6,
                    data: dataset2,
                    borderWidth: 1
                },
                {
                    label: 'Screen',
                    fill: true,
                    lineTension: 0.4,
                    borderColor: "#FADC19",
                    backgroundColor: "rgba(250, 220, 25, 0.2)",
                    //pointRadius: 6,
                    data: dataset3,
                    borderWidth: 1
                }, {
                    label: 'Keyboard',
                    fill: true,
                    lineTension: 0.4,
                    borderColor: "#00B42A",
                    backgroundColor: "rgba(0, 180, 42, 0.2)",
                    //pointRadius: 6,
                    data: dataset4,
                    borderWidth: 1
                }, {
                    label: 'Battry',
                    fill: true,
                    lineTension: 0.4,
                    borderColor: "#14C9C9",
                    backgroundColor: "rgba(20, 201, 201, 0.2)",
                    //pointRadius: 6,
                    data: dataset5,
                    borderWidth: 1
                }, {
                    label: 'OS',
                    fill: true,
                    lineTension: 0.4,
                    borderColor: "#165DFF",
                    backgroundColor: "rgba(22, 93, 255, 0.2)",
                    //pointRadius: 6,
                    data: dataset6,
                    borderWidth: 1
                }, {
                    label: 'Data',
                    fill: true,
                    lineTension: 0.4,
                    borderColor: "#D91AD9",
                    backgroundColor: "rgba(217, 26, 217, 0.2)",
                    //pointRadius: 6,
                    data: dataset7,
                    borderWidth: 1
                }, {
                    label: 'Internet',
                    fill: true,
                    lineTension: 0.4,
                    borderColor: "#86909C",
                    backgroundColor: "rgba(134, 144, 156, 0.2)",
                    //pointRadius: 6,
                    data: dataset8,
                    borderWidth: 1
                },

            ]
        },
        options: {
            responsive: true,
            interaction: {
                mode: 'index',
                intersect: false,
            },
            plugins: {
                legend: {
                    display: true,
                },
                title: {
                    display: true,
                    text: "Monthly service type quantity",
                }
            },
            scales: {
                x: {
                    grid: {
                        color: "rgba(242, 243, 245,1)"
                    },
                    title: {
                        display: true,
                        text: 'Month'
                    }
                },
                y: {
                    suggestedMax: 100,
                    min: 0,
                    grid: {
                        color: "rgba(242, 243, 245,1)"
                    }
                }
            }
        }
    });
}
show();

var ctx2 = document.getElementById("myChart2").getContext('2d');
var myBarChart2 = new Chart(ctx2, {
    type: "bar",
    data: {
        labels: topServiceVolumeLabel,

        datasets: [{
            borderRadius: 10,
            backgroundColor: ['rgba(64, 134, 255, 0.9)', 'rgba(64, 134, 255, 0.9)', 'rgba(64, 134, 255, 0.9)'],
            data: topServiceVolumeData,
        }],
    },
    options: {
        maintainAspectRatio: false,
        indexAxis: 'y',
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
                grid: {
                    display: false,
                }
            }
        }

    }
});

var ctx3 = document.getElementById("myChart3").getContext('2d');
var myBarChart3 = new Chart(ctx3, {
    type: "bar",
    data: {
        labels: topRepairVolumeLabel,
        datasets: [{
            borderRadius: 10,
            backgroundColor: ['rgba(64, 134, 255, 0.9)', 'rgba(64, 134, 255, 0.9)', 'rgba(64, 134, 255, 0.9)'],
            data: topRepairVolumeData,
        }],
    },
    options: {
        maintainAspectRatio: false,
        indexAxis: 'y',
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
                grid: {
                    display: false,
                }
            }
        }

    }
});

var ctxOrder = document.getElementById("myChartOrder").getContext('2d');
var myChartOrder = new Chart(ctxOrder, {
    type: 'line',
    data: {
        //labels: ["Red", "Blue", "Yellow", "Green", "Purple", "Orange", "seven"],
        labels: monthList,
        datasets: [
            {
                label: 'Order quantity',
                fill: false,
                lineTension: 0.4,
                pointRadius: 0,
                borderColor: "#4080ff",
                backgroundColor: "rgba(22, 93, 255, 0.2)",
                //pointRadius: 6,
                data: order_quantity_month,
                borderWidth: 1
            }
        ]
    },
    options: {
        responsive: true,
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


var ctxService = document.getElementById("myChartService").getContext('2d');
var myChartService = new Chart(ctxService, {
    type: 'line',
    data: {
        labels: monthList,
        datasets: [
            {
                label: 'Service score',
                fill: false,
                lineTension: 0.4,
                pointRadius: 0,
                borderColor: "#4080ff",
                backgroundColor: "rgba(22, 93, 255, 0.2)",
                //pointRadius: 6,
                data: service_score_month,
                borderWidth: 1
            }
        ]
    },
    options: {
        maintainAspectRatio: false,
        responsive: true,
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


var ctxCustomer = document.getElementById("myChartCustomer").getContext('2d');
var myBarChartCustomer = new Chart(ctxCustomer, {
    type: "bar",
    data: {
        labels: monthList,
        datasets: [{
            borderRadius: 10,
            backgroundColor: ['rgba(64, 134, 255, 0.9)', 'rgba(134, 223, 108, 0.9)'],
            data: new_customers_month,
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
        barThickness: 5,
        scales: {
            y: {
                display: false,
            },
            x: {
                display: false,
            }
        }

    }
});

var ctxSpeed = document.getElementById("myChartSpeed").getContext('2d');
var myBarChartSpeed = new Chart(ctxSpeed, {
    type: "bar",
    data: {
        labels: monthList,
        datasets: [{
            borderRadius: 10,
            backgroundColor: ['rgba(64, 134, 255, 0.9)', 'rgba(134, 223, 108, 0.9)'],
            data: new_customers_month,
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
        barThickness: 5,
        scales: {
            y: {
                display: false,
            },
            x: {
                display: false,
            }
        }

    }
});

var ctxPie1 = document.getElementById("pie1").getContext('2d');
var myChartPie1 = new Chart(ctxPie1, {
    type: "doughnut",
    data: {
        labels: ["Virus", "Run slow", "Screen", "Keyboard", "Battery", "OS", "Data", "Internet"],
        datasets: [
            {
                data: serverTypeRatio,
                backgroundColor: [
                    "#F53F3F",
                    "#FF7D00",
                    "#FADC19",
                    "#00B42A",
                    "#14C9C9",
                    "#165DFF",
                    "#D91AD9",
                    "#86909C",
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
                text: 'Service type proportion'
            }
        }
    }
});

var ctxPie2 = document.getElementById("pie2").getContext('2d');
var myChartPie2 = new Chart(ctxPie2, {
    type: "doughnut",
    data: {
        labels: ["Five-star", "Four-star", "Three-star", "Two-star", "One-star"],
        datasets: [
            {
                data: starRatio,
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
                text: 'Star proportion'
            }
        }
    }
});

var ctxPie3 = document.getElementById("pie3").getContext('2d');
var myChartPie3 = new Chart(ctxPie3, {
    type: "doughnut",
    data: {
        labels: ["One day", "Two or three days", "Four or five days", "Six or seven days", "More than one week"],
        datasets: [
            {
                data: speedRatio,
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
                text: 'Time proportion'
            }
        }
    }
});

