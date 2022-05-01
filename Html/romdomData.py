'''
dataset1 = [
    { x: 12, y: 53 },
    { x: 11, y: 63 },
    { x: 10, y: 83 },
    { x: 9, y: 23 },
    { x: 8, y: 52 },
    { x: 7, y: 33 },
    { x: 6, y: 17 },
    { x: 5, y: 28 },
    { x: 4, y: 20 },
    { x: 3, y: 30 },
    { x: 2, y: 40 },
    { x: 1, y: 50 }
];
'''
import random

para = []
for i in range(1, 9):
    name = f"dataset{i}"
    para.append(name)
    para.append("=[")

    for i in range(12):
        data = f"{{x:{12-i},y:{random.randint(10,100)}}},"
        para.append(data)
    para.append("];")

    result = " ".join(para)
    print(result)
    para = []
