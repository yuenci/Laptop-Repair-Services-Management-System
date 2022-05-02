args = [
    'dataset1 ',
    'dataset2 ',
    'dataset3 ',
    'dataset4 ',
    'dataset5 ',
    'dataset6 ',
    'dataset7 ',
    'dataset8 ',
    'monthOrders ',
    'monthFinised ',
    'monthCustomers ',
    'topServiceVolumeLabel ',
    'topServiceVolumeData ',
    'topRepairVolumeLabel ',
    'topRepairVolumeData ',
    'averageService ',
    'averageRepair ',
    'order_quantity ',
    'order_quantity_per ',
    'order_quantity_month ',
    'new_customers ',
    'new_customers_per ',
    'new_customers_month ',
    'service_score ',
    'service_score_per ',
    'service_score_month ',
    'completion_speed ',
    'completion_speed_per ',
    'completion_speed_month ',
    'serverTypeRatio ',
    'starRatio ',
    'speedRatio '
]

# type = "private string "
# for ele in args:
#     print(type + ele + ' = "";')

for index in range(32):
    print(f'data[{index}] = "{args[index]}" + "=" + {args[index]} + ";";')
