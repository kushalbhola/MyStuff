def tri_recursion2(k):
	if(k>0):
		a = tri_recursion2(k-1)
		result = k + a
		print(result)
	else:
		result = 0
	return result




#print("\n\nRecursion Example Results")
#tri_recursion2(6)
import json

with open('google-resp.json') as json_file:
  data = json.load(json_file)
  s = ''
  for row in data['reports']:
      for elem in row['data']['rows']:
          for d in elem['dimensions']:
              for r in d:
                  s += r
  print(s)