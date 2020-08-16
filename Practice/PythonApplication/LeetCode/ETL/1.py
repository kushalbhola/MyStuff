#https://github.com/dimgold/ETL_with_Python/blob/master/ETL_with_Python.ipynb

import sys
def main():
    input = "[beer:0, spirit:0, wine:0]"
    output = converToDict(input)
    print(output)
def converToDict(input):
    if (input[0] == '[' and input[-1] == ']'):
        input = input[1:-1]
        input = input.split(',')
        output = {}
        for i in input:
            key, value = i.split(':')
            if key not in output:
                output[i.split(':')[0]] = int(value)
        test = 100
if __name__ == '__main__':
    main()

