def main():
    words =  ["apple","app"]
    order = "abcdefghijklmnopqrstuvwxyz"
    output = isAlienSorted(words, order)
    print(output)
def isAlienSorted(words, order):
    '''
    Algo: 
    1. Create dictionary of order 
    2. look at 2 words at a time
    3. Inspect each letter of 2 words
    4. hash[first[i]]  <= hash[second[i]] >> then it will be sorted
    '''
    #Create dict
    hash ={}
    for o in range(len(order)):
        if(order[o] not in hash):
            hash[order[o]] = o

    if(len(words) == 0): return False
    if(len(words) == 1): return True

    wordsArray = []
    for w in words:
        wordsArray.append(w)

    i = 1
    for w in range(1, len(wordsArray)):
        first = wordsArray[w-1]
        second = wordsArray[w]
        for f in range(len(first)):
            if(f < len(first)):
                a = first[f]
            else: a = -1
            if(f < len(second)):
                b = second[f]
            else: b = -1
            #if (a != None and b == -1):
            #    return False
            if(a != -1 and b != -1 and hash[a] < hash[b]):
                break
            elif (a == b):
                continue
            else: 
                return False
    return True


if __name__ == '__main__':
    main()












