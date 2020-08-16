import csv
import reader
file = open('C:/kushal/F/kushal Stuff/PythonInterview/app-store-apple-data-set-10k-apps/AppleStore.csv')
read_file = reader(file)
data_file = list(read_file)
print(len(data_file))