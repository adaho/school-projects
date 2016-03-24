#------------------------------------------------------------------------------
# gp1a.rb
#
##  Team Name:  Neutralities
##  Class Days: Tue/Thur
##  Class Time: 4:30PM
##  Team name:  Neutralities
##  Member 1:   Boyi Wu
##  Member 2:   Ayodele Kalejaiye
##  Member 3:   Jocelyn Ventura
##  Member 4:   Ada Ho
##  Member 5:   Kevin Gladnick
#
# Best viewed with TABS set to four spaces in your favorite editor
# 10/8/2015 - Mazzola
#------------------------------------------------------------------------------

IPv4_BITS					=	32		## Number of bits in an IPv4 Address
CLASS_C_BITS				=	24		## Number of bits in an Class C address
MASK_OCTET					=	255		## Decimal value of an all 1's octet
			
OCTET1						=	192		# an Octet in 192.169.100.0
OCTET2						=	168		# an Octet in 192.169.100.0
OCTET3						=	100		# an Octet in 192.169.100.0
OCTET4 						=	0		# an Octet in 192.169.100.0

MIN_SUBNET_BITS_BORROWED 	=	2		## Min bits to borrow from final octet
MAX_SUBNET_BITS_BORROWED 	=	2		## Max bits to borrow from final octet

HEADER_LENGTH				=	80
SINGLE_HEADER				=	"-" * HEADER_LENGTH
DOUBLE_HEADER				=	"=" * HEADER_LENGTH

#------------------------------------------------------------------------------
# String.set_leftmost_bits!(n)
# Extends the functionality of the String class to have a new method. When 
# called it sets the leftmost n characters to a "1" character, for example:
#
# "00000000".set_leftmost_bits(4) ==> "11110000"
#
# self is a name for the String in question, 
# The method has a ! at the end since we are modifying the string itself
#------------------------------------------------------------------------------
class String
   def set_leftmost_bits!(n)
     n.times do |i|
   		 self[i] = '1'
     end
   end
end

#------------------------------------------------------------------------------
# Loops from MIN_SUBNET_BITS_BORROWED to MAX_SUBNET_BITS_BORROWED
# When they both have the same value (e.g. 4), only that subnet is calculated
# When they have different values (e.g. 2..6), each resulting subnet is
# calcuated in turn from the min to the max value
#------------------------------------------------------------------------------

for subnet_bits in MIN_SUBNET_BITS_BORROWED..MAX_SUBNET_BITS_BORROWED

	##-------------------------------------------------------------------------
	## Calculate some important variables
	## cidr_bits - the number of total number of bits in the CIDR (the n in /n)
	## subnets 	- how many subnets created based upon the the bits borrowed
	## host_bits - the number of bits left for the host addresses
	## hosts     - the total number of host addresses (include all 0's and 1's)
	##
	## note: x**y means x raised to the power of y in ruby, dont use x^y
	##-------------------------------------------------------------------------

	cidr_bits 	= 	CLASS_C_BITS + subnet_bits
	subnets 	= 	2**MIN_SUBNET_BITS_BORROWED
	host_bits	= 	(IPv4_BITS - CLASS_C_BITS) - MAX_SUBNET_BITS_BORROWED
	hosts  		=	2**host_bits

	#--------------------------------------------------------------------------
	# Display information the starting class C network and how it will be 
	# subnetted. Include the number of host bits borrowed, the resulting
	# CIDR, the calculation/count of subnets, the calculation/count of hosts,
	# and the subnet mask for the subnets
	#--------------------------------------------------------------------------

	puts SINGLE_HEADER

	printf("Given Network: %3d.%3d.%3d.%3d/%2d, " + 
		"these subnets are possible using %d host bits\n\n", 
		OCTET1, OCTET2, OCTET3, OCTET4, CLASS_C_BITS, subnet_bits)

	printf("Subnet bits taken from host octet:%1d, CIDR:/%2d, ", 
		subnet_bits, cidr_bits)
	printf("Subnets:2^%d=%3d, Hosts:2^%d=%3d\n",   	
		subnet_bits, subnets, host_bits, hosts)

	puts DOUBLE_HEADER

	##-------------------------------------------------------------------------
	## Calculate the last octet subnet mask by setting the borrowed bits to "1"
	##-------------------------------------------------------------------------
	last_octet_mask_str = "00000000"
	last_octet_mask_str.set_leftmost_bits!(subnet_bits)
	last_mask_octet_int = last_octet_mask_str.to_i(2)

	printf(" Subnet Mask : %3d.%3d.%3d.%3d/%2d ~ %08b.%08b.%08b.%08b\n",
		MASK_OCTET, MASK_OCTET, MASK_OCTET, last_mask_octet_int, cidr_bits,
		MASK_OCTET, MASK_OCTET, MASK_OCTET, last_mask_octet_int)

	##-------------------------------------------------------------------------
	## For each subnet, display the network number, the first and last host
	## address, and the broadcast address
	##-------------------------------------------------------------------------

	for subnet_num in 0...subnets

		network_octet    = (subnet_num * hosts)
		first_host_octet = (subnet_num * hosts) + 1
		last_host_octet  = (subnet_num * hosts) + hosts - 2
		broadcast_octet  = (subnet_num * hosts) + hosts - 1

		printf("\n Subnet Num: %s\n", subnet_num + 1)
		printf("   Network   : %3d.%3d.%3d.%3d/%2d ~ %08b.%08b.%08b.%08b\n",
			OCTET1, OCTET2, OCTET3, network_octet, cidr_bits,
			OCTET1, OCTET2, OCTET3, network_octet)

		printf("   First host: %3d.%3d.%3d.%3d/%2d ~ %08b.%08b.%08b.%08b\n",
			OCTET1, OCTET2, OCTET3, first_host_octet, cidr_bits,
			OCTET1, OCTET2, OCTET3, first_host_octet)

		printf("   Last host : %3d.%3d.%3d.%3d/%2d ~ %08b.%08b.%08b.%08b\n",
			OCTET1, OCTET2, OCTET3, last_host_octet, cidr_bits,
			OCTET1, OCTET2, OCTET3, last_host_octet)

		printf("   Broadcast : %3d.%3d.%3d.%3d/%2d ~ %08b.%08b.%08b.%08b\n",
			OCTET1, OCTET2, OCTET3, broadcast_octet, cidr_bits,
			OCTET1, OCTET2, OCTET3, broadcast_octet)
	end

	puts DOUBLE_HEADER

end

=begin
To test part 1, compare your output to the following:
--------------------------------------------------------------------------------
Given Network: 192.168.100.  0/24, these subnets are possible using 2 host bits

Subnet bits taken from host octet:2, CIDR:/26, Subnets:2^2=  4, Hosts:2^6= 64
================================================================================
 Subnet Mask : 255.255.255.192/26 ~ 11111111.11111111.11111111.11000000

 Subnet Num: 1
   Network   : 192.168.100.  0/26 ~ 11000000.10101000.01100100.00000000
   First host: 192.168.100.  1/26 ~ 11000000.10101000.01100100.00000001
   Last host : 192.168.100. 62/26 ~ 11000000.10101000.01100100.00111110
   Broadcast : 192.168.100. 63/26 ~ 11000000.10101000.01100100.00111111

 Subnet Num: 2
   Network   : 192.168.100. 64/26 ~ 11000000.10101000.01100100.01000000
   First host: 192.168.100. 65/26 ~ 11000000.10101000.01100100.01000001
   Last host : 192.168.100.126/26 ~ 11000000.10101000.01100100.01111110
   Broadcast : 192.168.100.127/26 ~ 11000000.10101000.01100100.01111111

 Subnet Num: 3
   Network   : 192.168.100.128/26 ~ 11000000.10101000.01100100.10000000
   First host: 192.168.100.129/26 ~ 11000000.10101000.01100100.10000001
   Last host : 192.168.100.190/26 ~ 11000000.10101000.01100100.10111110
   Broadcast : 192.168.100.191/26 ~ 11000000.10101000.01100100.10111111

 Subnet Num: 4
   Network   : 192.168.100.192/26 ~ 11000000.10101000.01100100.11000000
   First host: 192.168.100.193/26 ~ 11000000.10101000.01100100.11000001
   Last host : 192.168.100.254/26 ~ 11000000.10101000.01100100.11111110
   Broadcast : 192.168.100.255/26 ~ 11000000.10101000.01100100.11111111
================================================================================

=end


#Output of gp1a.rb

Microsoft Windows [Version 6.3.9600]
(c) 2013 Microsoft Corporation. All rights reserved.

C:\Users\Ada>ruby gp1a.rb
--------------------------------------------------------------------------------

Given Network: 192.168.100.  0/24, these subnets are possible using 2 host bits

Subnet bits taken from host octet:2, CIDR:/26, Subnets:2^2=  4, Hosts:2^6= 64
================================================================================

 Subnet Mask : 255.255.255.192/26 ~ 11111111.11111111.11111111.11000000

 Subnet Num: 1
   Network   : 192.168.100.  0/26 ~ 11000000.10101000.01100100.00000000
   First host: 192.168.100.  1/26 ~ 11000000.10101000.01100100.00000001
   Last host : 192.168.100. 62/26 ~ 11000000.10101000.01100100.00111110
   Broadcast : 192.168.100. 63/26 ~ 11000000.10101000.01100100.00111111

 Subnet Num: 2
   Network   : 192.168.100. 64/26 ~ 11000000.10101000.01100100.01000000
   First host: 192.168.100. 65/26 ~ 11000000.10101000.01100100.01000001
   Last host : 192.168.100.126/26 ~ 11000000.10101000.01100100.01111110
   Broadcast : 192.168.100.127/26 ~ 11000000.10101000.01100100.01111111

 Subnet Num: 3
   Network   : 192.168.100.128/26 ~ 11000000.10101000.01100100.10000000
   First host: 192.168.100.129/26 ~ 11000000.10101000.01100100.10000001
   Last host : 192.168.100.190/26 ~ 11000000.10101000.01100100.10111110
   Broadcast : 192.168.100.191/26 ~ 11000000.10101000.01100100.10111111

 Subnet Num: 4
   Network   : 192.168.100.192/26 ~ 11000000.10101000.01100100.11000000
   First host: 192.168.100.193/26 ~ 11000000.10101000.01100100.11000001
   Last host : 192.168.100.254/26 ~ 11000000.10101000.01100100.11111110
   Broadcast : 192.168.100.255/26 ~ 11000000.10101000.01100100.11111111
================================================================================


C:\Users\Ada>





