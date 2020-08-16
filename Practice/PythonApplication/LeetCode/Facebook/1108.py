
import sys
def main():
    input ="1.1.1.1"
    output = defangIPaddr(input)
    print(output)
def defangIPaddr(input):
    input = input.replace('.', '[.]')
    return input



if __name__ == '__main__':
    main()








