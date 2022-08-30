def checkIPValidity(addressIP):
	# Write your code here
	split_ip = addressIP.split(".")
	ip_len = len(split_ip)
	
	if ip_len != 4:
		return "INVALID"

	for i in split_ip:
		con_i = int(i)
		if (0 > con_i or con_i > 255):
			return "INVALID"
	return "VALID"