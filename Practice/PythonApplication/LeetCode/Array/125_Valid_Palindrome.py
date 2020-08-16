import re
def main():
    input = "A man, a plan, a canal: Panama"
    output = isPalindrome(input)
def isPalindrome(s):
    s = re.sub('[^A-Za-z0-9]', '', s)
    s = s.lower()
    start = 0
    end = len(s)-1
    while(end > start):
        if(s[start] == s[end]):
            start += 1
            end -=1
        else:
            return False
    return True

if __name__ == '__main__':
    main()


