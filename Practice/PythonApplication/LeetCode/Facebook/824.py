def main():
    input = "I speak Goat Latin"
    output = toGoatLatin(input)
    print(output)
def toGoatLatin(S):
    vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U']
    strArr = S.split(' ')
    index = 1
    print(type(strArr))
    output = []
    for s in strArr:
        if (s[0] in vowels):
            print(type(s))
            s += "ma"
            for x in range(index):
                s += "a"
            index +=1
            output.append(s)
            output.append(" ")
        else:
            first = s[0]
            newString = s[1: len(s)]
            s = newString + first + "ma"
            for x in range(index):
                s += "a"
            index += 1
            output.append(s)
            output.append(" ")
    return ''.join(output).strip()

if __name__ == '__main__':
    main()










