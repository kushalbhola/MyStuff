import random
import tweepy

CONSUMER_KEY = "FLYx277iVgehtE8WmWgxdeVaC"
CONSUMER_SECRET = "Bh3XItiMdnkFgntAerg2Yxv7S90zIuudUEjuR6Pz1keSf1eBB1"
ADMIN_KEY = "353313864-VJxcSvSOL43rpPAKVaowuYKPcCqC96T57beqfjDi"
ADMIN_SECRET = "2VvfUvGj295qW9lKjSQnZpVErvXO57ZpWOKnte3B8WfCe"
auth = tweepy.OAuthHandler(CONSUMER_KEY,CONSUMER_SECRET)
auth.set_access_token(ADMIN_KEY,ADMIN_SECRET)
api = tweepy.API(auth)
def memify(text):
    new=[]
    b = "..ok boomer"
    for i in range(len(text) - len(b)):
        c=text[i]
        r = random.randint(0,1)
        if r:
            new.append(c.upper())
        else:
            new.append(c)
    return ''.join(new + [b])

print(memify("my name is kushal bhola"))
tweets = api.home_timeline()
trump_tweets = api.user_timeline(screen_name="realDonaldTrump")
#   for tweet in tweets:
    #print(tweet.text + "\n")
for t in trump_tweets:
    if(t.text[0:2] != 'RT'):
        api.update_status('@realDonaldTrump hmmmm....',trump_tweets[0].id)

    print(t.text+"\n")