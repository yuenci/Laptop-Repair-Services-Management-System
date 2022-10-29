'''

<img src="https://github.com/yuenci/Laptop-Repair-Services-Management-System/blob/master/image/mainPage.png" alt="Logo" width="700">



'''


import os

res = []

with open('data.txt', 'w') as f:
    for picName in os.listdir('.'):
        if picName.endswith('.png'):
            url = f'<img src="https://github.com/yuenci/Laptop-Repair-Services-Management-System/blob/master/image/{picName}" alt="screenShot" width="700">'
            res.append(url)

with open('data.txt', 'w') as f:
    f.write("\n".join(res))

print("Done")


