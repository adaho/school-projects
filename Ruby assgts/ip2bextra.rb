# ip2b.rb
# Written By: Ada Ho
# My class: T/Th 4:30pm
# On date: 10/1/2015
#
# This is a simple program that demonstrates how to calculate the year end 
# value of savings by using a loop function

swYEV = 0.00
printf("Annual Salary: ")

while salary = gets 
	swYEV = 1.1 * ((salary.to_f * 0.1) + swYEV)
	printf("Year End Value: %.2f\n", swYEV)
	salary = 1.03 * salary.to_f
	printf("Salary next year: %.2f\n", salary)
end


# result of running ip2bextra.rb

Microsoft Windows [Version 6.3.9600]
(c) 2013 Microsoft Corporation. All rights reserved.

C:\Users\Ada>ruby ip2bextra.rb
Annual Salary: 50000
Year End Value: 5500.00
Salary next year: 51500.00
51500
Year End Value: 11715.00
Salary next year: 53045.00
53045
Year End Value: 18721.45
Salary next year: 54636.35
54636.35
Year End Value: 26603.59
Salary next year: 56275.44
56275.44
Year End Value: 35454.25
Salary next year: 57963.70
57963.70
Year End Value: 45375.68
Salary next year: 59702.61
59702.61
Year End Value: 56480.54
Salary next year: 61493.69
61493.69
Year End Value: 68892.90
Salary next year: 63338.50
63338.50
Year End Value: 82749.42
Salary next year: 65238.65
65238.65
Year End Value: 98200.62
Salary next year: 67195.81
67195.81
Year End Value: 115412.22
Salary next year: 69211.68
69211.68
Year End Value: 134566.72
Salary next year: 71288.03
71288.03
Year End Value: 155865.08
Salary next year: 73426.67
73426.67
Year End Value: 179528.52
Salary next year: 75629.47
75629.47
Year End Value: 205800.62
Salary next year: 77898.35
77898.35
Year End Value: 234949.50
Salary next year: 80235.30
80235.30
Year End Value: 267270.33
Salary next year: 82642.36
82642.36
Year End Value: 303088.02
Salary next year: 85121.63
85121.63
Year End Value: 342760.20
Salary next year: 87675.28
87675.28
Year End Value: 386680.50
Salary next year: 90305.54
90305.54
Year End Value: 435282.16
Salary next year: 93014.71
93014.71
Year End Value: 489042.00
Salary next year: 95805.15
95805.15
Year End Value: 548484.76
Salary next year: 98679.30
98679.30
Year End Value: 614187.96
Salary next year: 101639.68
101639.68
Year End Value: 686787.13
Salary next year: 104688.87
104688.87
Year End Value: 766981.61
Salary next year: 107829.54
107829.54
Year End Value: 855541.02
Salary next year: 111064.43
111064.43
Year End Value: 953312.21
Salary next year: 114396.36
114396.36
Year End Value: 1061227.03
Salary next year: 117828.25
117828.25
Year End Value: 1180310.85
Salary next year: 121363.10
121363.10
Year End Value: 1311691.87
Salary next year: 125003.99
125003.99
Year End Value: 1456611.50
Salary next year: 128754.11
128754.11
Year End Value: 1616435.60
Salary next year: 132616.73
132616.73
Year End Value: 1792667.00
Salary next year: 136595.23
136595.23
Year End Value: 1986959.17
Salary next year: 140693.09
140693.09
Year End Value: 2201131.33
Salary next year: 144913.88
144913.88
Year End Value: 2437184.99
Salary next year: 149261.30
149261.30
Year End Value: 2697322.23
Salary next year: 153739.14
153739.14
Year End Value: 2983965.76
Salary next year: 158351.31
158351.31
Year End Value: 3299780.98
Salary next year: 163101.85
163101.85
Year End Value: 3647700.29
Salary next year: 167994.91
167994.91
Year End Value: 4030949.75
Salary next year: 173034.76
173034.76
Year End Value: 4453078.55
Salary next year: 178225.80
178225.80
Year End Value: 4917991.25
Salary next year: 183572.57
183572.57 
Year End Value: 5429983.35
Salary next year: 189079.75

# Sparky would have $5,429,983.35 to retire on at the end of 45 years. 
# Sparky's final salary would be $183,572.57 