import urllib.request as urllib2
import json
 
def GetToken(username, password):
    data = {
            "agent": {
                    "name": "Minecraft",
                    "version": 1
            },
            "username": username,
            "password": password
    }
 
    try:
        req = urllib2.Request(url='https://authserver.mojang.com/authenticate', data=json.dumps(data).encode(), headers={"Content-Type": "application/json"})
        code = json.loads(urllib2.urlopen(req).read().decode())
    except:
        return False, False, False
        print("Failed")
 
    username = code['selectedProfile']['name']
    access_token = code['accessToken']
    profile_id = code['selectedProfile']['id']
 
    print(username+",Token:"+access_token)
 
    return (access_token, profile_id, username)
    

GetToken("XiaochangMC","MangoLiu2190")