import os
import re
root = "C:\\Acclaris\\Checkouts\\enterprise2.0\\JavaSource"
regex = re.compile('<script.*?src="(.*?)"')
for path, subdirs, files in os.walk(root):
    for file in files:
        if regex.match(file):
            print(file)
        else:
            print("kat gaya")
