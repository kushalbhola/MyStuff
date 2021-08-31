import requests
import response
response = requests.get("http://api.open-notify.org/astros.json")
print(response.title())