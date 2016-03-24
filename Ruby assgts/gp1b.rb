#------------------------------------------------------------------------------
# gp1b.rb
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


class String
   def set_leftmost_bits!(n)
     n.times do |i|
   		 self[i] = '1'
     end
   end
end

for subnet_bits in MIN_SUBNET_BITS_BORROWED..MAX_SUBNET_BITS_BORROWED

	cidr_bits 	= 	CLASS_C_BITS + subnet_bits
	subnets 	= 	2**MIN_SUBNET_BITS_BORROWED
	host_bits	= 	(IPv4_BITS - CLASS_C_BITS) - MAX_SUBNET_BITS_BORROWED
	hosts  		=	2**host_bits

	puts SINGLE_HEADER

	printf("Given Network: %3d.%3d.%3d.%3d/%2d, " + 
		"these subnets are possible:\n", 
		OCTET1, OCTET2, OCTET3, OCTET4, CLASS_C_BITS)

	puts DOUBLE_HEADER
	
	for i in 0...8
		printf("Subnet bits taken from host octet:%1d, CIDR:/%2d, ", 
			i, (cidr_bits - 2 + i))
		printf("Subnets:2^%d=%3d, Hosts:2^%d=%3d\n",   	
			i, subnet_bits**i, (host_bits + 2 - i), 
			subnet_bits**(host_bits + 2 - i))
	end
	
	puts DOUBLE_HEADER

end


#Output of gp1b.rb

Microsoft Windows [Version 6.3.9600]
(c) 2013 Microsoft Corporation. All rights reserved.

C:\Users\Ada>ruby gp1b.rb
--------------------------------------------------------------------------------

Given Network: 192.168.100.  0/24, these subnets are possible:
================================================================================

Subnet bits taken from host octet:0, CIDR:/24, Subnets:2^0=  1, Hosts:2^8=256
Subnet bits taken from host octet:1, CIDR:/25, Subnets:2^1=  2, Hosts:2^7=128
Subnet bits taken from host octet:2, CIDR:/26, Subnets:2^2=  4, Hosts:2^6= 64
Subnet bits taken from host octet:3, CIDR:/27, Subnets:2^3=  8, Hosts:2^5= 32
Subnet bits taken from host octet:4, CIDR:/28, Subnets:2^4= 16, Hosts:2^4= 16
Subnet bits taken from host octet:5, CIDR:/29, Subnets:2^5= 32, Hosts:2^3=  8
Subnet bits taken from host octet:6, CIDR:/30, Subnets:2^6= 64, Hosts:2^2=  4
Subnet bits taken from host octet:7, CIDR:/31, Subnets:2^7=128, Hosts:2^1=  2
================================================================================


C:\Users\Ada>