def tri_recursion2(k):
	if(k>0):
		a = tri_recursion2(k-1)
		result = k + a
		print(result)
	else:
		result = 0
	return result




print("\n\nRecursion Example Results")
tri_recursion2(6)