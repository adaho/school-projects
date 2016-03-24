# ip2a.rb
# Written By: Ada Ho
# My class: T/Th 4:30pm
# On date: 10/1/2015
#
# This is a simple program that demonstrates getting an integer from the user 
# and presenting that number in different bases.

prompt = "Enter a number, and I will show it in different bases:"
puts prompt

while line = gets
	printf("user entered: %s", line)
	printf("Value in decimal: %d\n", line.to_i)
	printf("Value in octal	: %o\n", line.to_i)
	printf("Value in hex	: %x\n", line.to_i)
	printf("Value in binary	: %b\n", line.to_i)
	puts prompt
end


# results of running ip2a.rb

Microsoft Windows [Version 6.3.9600]
(c) 2013 Microsoft Corporation. All rights reserved.

C:\Users\Ada>ruby ip2a.rb
Enter a number, and I will show it in different bases:
0
user entered: 0
Value in decimal: 0
Value in octal  : 0
Value in hex    : 0
Value in binary : 0
Enter a number, and I will show it in different bases:
3.1415
user entered: 3.1415
Value in decimal: 3
Value in octal  : 3
Value in hex    : 3
Value in binary : 11
Enter a number, and I will show it in different bases:
8
user entered: 8
Value in decimal: 8
Value in octal  : 10
Value in hex    : 8
Value in binary : 1000
Enter a number, and I will show it in different bases:
16
user entered: 16
Value in decimal: 16
Value in octal  : 20
Value in hex    : 10
Value in binary : 10000
Enter a number, and I will show it in different bases:
33
user entered: 33
Value in decimal: 33
Value in octal  : 41
Value in hex    : 21
Value in binary : 100001
Enter a number, and I will show it in different bases: