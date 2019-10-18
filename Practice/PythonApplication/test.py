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