# ip2b.rb
# Written By: Ada Ho
# My class: T/Th 4:30pm
# On date: 10/1/2015
#
# This is a simple program that demonstrates how to calculate the year end 
# value of savings by using a loop function

swYEV = 0.00
printf("Annual Contribution: ")

while YEV = gets
	swYEV = 1.1 * (swYEV + YEV.to_f)
	printf("Year End Value: %.2f\n", swYEV)	
end


# results of running ip2b.rb for Sparky

Microsoft Windows [Version 6.3.9600]
(c) 2013 Microsoft Corporation. All rights reserved.

C:\Users\Ada>ruby ip2b.rb
Annual Contribution: 5000
Year End Value: 5500.00
5000
ip2b.rb:15: warning: already initialized constant YEV
ip2b.rb:15: warning: previous definition of YEV was here
Year End Value: 11550.00
5000
Year End Value: 18205.00
5000
Year End Value: 25525.50
5000
Year End Value: 33578.05
5000
Year End Value: 42435.86
5000
Year End Value: 52179.44
5000
Year End Value: 62897.38
5000
Year End Value: 74687.12
5000
Year End Value: 87655.84
0
Year End Value: 96421.42
0
Year End Value: 106063.56
0
Year End Value: 116669.92
0
Year End Value: 128336.91
0
Year End Value: 141170.60
0
Year End Value: 155287.66
0
Year End Value: 170816.43
0
Year End Value: 187898.07
0
Year End Value: 206687.87
0
Year End Value: 227356.66
0
Year End Value: 250092.33
0
Year End Value: 275101.56
0
Year End Value: 302611.72
0
Year End Value: 332872.89
0
Year End Value: 366160.18
0
Year End Value: 402776.20
0
Year End Value: 443053.81
0
Year End Value: 487359.20
0
Year End Value: 536095.12
0
Year End Value: 589704.63
0
Year End Value: 648675.09
0
Year End Value: 713542.60
0
Year End Value: 784896.86
0
Year End Value: 863386.55
0
Year End Value: 949725.20
0
Year End Value: 1044697.72
0
Year End Value: 1149167.49
0
Year End Value: 1264084.24
0
Year End Value: 1390492.66
0
Year End Value: 1529541.93
0
Year End Value: 1682496.12
0
Year End Value: 1850745.74
0
Year End Value: 2035820.31
0
Year End Value: 2239402.34
0
Year End Value: 2463342.58


# results of running ip2b.rb for Wilbur

Microsoft Windows [Version 6.3.9600]
(c) 2013 Microsoft Corporation. All rights reserved.

C:\Users\Ada>ruby ip2b.rb
Annual Contribution: 5000
Year End Value: 5500.00
5000
ip2b.rb:15: warning: already initialized constant YEV
ip2b.rb:15: warning: previous definition of YEV was here
Year End Value: 11550.00
5000
Year End Value: 18205.00
5000
Year End Value: 25525.50
5000
Year End Value: 33578.05
5000
Year End Value: 42435.86
5000
Year End Value: 52179.44
5000
Year End Value: 62897.38
5000
Year End Value: 74687.12
5000
Year End Value: 87655.84
5000
Year End Value: 101921.42
5000
Year End Value: 117613.56
5000
Year End Value: 134874.92
5000
Year End Value: 153862.41
5000
Year End Value: 174748.65
5000
Year End Value: 197723.51
5000
Year End Value: 222995.87
5000
Year End Value: 250795.45
5000
Year End Value: 281375.00
5000
Year End Value: 315012.50
5000
Year End Value: 352013.75
5000
Year End Value: 392715.12
5000
Year End Value: 437486.63
5000
Year End Value: 486735.30
5000
Year End Value: 540908.83
5000
Year End Value: 600499.71
5000
Year End Value: 666049.68
5000
Year End Value: 738154.65
5000
Year End Value: 817470.11
5000
Year End Value: 904717.12
5000
Year End Value: 1000688.84
5000
Year End Value: 1106257.72
5000
Year End Value: 1222383.49
5000
Year End Value: 1350121.84
5000
Year End Value: 1490634.03

# Sparky: $2,463,342.58		Wilbur: $1,490,634.03

# Sparky made the better investment because he started saving money early on,
# and was generating compound interest for 45 years, while Wilbur only started
# rolling in compound interest for 35 years.