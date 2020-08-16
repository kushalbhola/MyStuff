def main():
    input = 121
    output = isPalindrome(input)
def isPalindrome(x: int) -> bool:
    num = str(x)
    if (len(num)) == 0:
        return False
    start = 0
    end =len(num)-1
    while(end > start):
        if(num[start] != num[end]):
            return False
        else:
            start += 1
            end -=1
    return True
if __name__ == '__main__':
    main()
