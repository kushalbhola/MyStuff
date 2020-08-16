def main():
    input = ["cool","lock","cook"]
    output = commonChars(input)
    print(output)
def commonChars(A):
        '''
        Algo:
        1. create a dictionary with frequency of all words all char
        2. return only char whose frequency = number of words
        '''
        hash = {}
        output = []
        for a in A:
            hash = createDict(hash, a)
        for key, value in hash.items():
            if(value % len(A) == 0):
                g = int(value/len(A))
                for k in range(g):
                    output.append(key)
        return output
    
def createDict(hash, a):
    for x in a:
        if x in hash:
            hash[x] += 1
        else:
            hash[x] = 1
    return hash    

if __name__ == '__main__':
    main()











