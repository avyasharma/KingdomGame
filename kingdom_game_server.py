# This is the Admin Code for the Kingdom Game
import firebase_admin
from firebase_admin import credentials
from firebase_admin import db

# This is for initializing the application and credentials with the private encryption skinnymonkey
# Replace the file path in the function call below with the file path of the encryption key file [.json] as it appears on your computer
cred = credentials.Certificate("/Users/skinnymonkey/Documents/KingdomGame/kingdom-game-b900c-firebase-adminsdk-1cb4e-1156792b58.json")
default_app = firebase_admin.initialize_app(cred, {'databaseURL':'https://kingdom-game-b900c.firebaseio.com/'})

# This is just to establish Admin Privileges [don't worry about this guys]
restricted_ref = db.reference('restricted_access/secret_document')

#The following Code is Purely for the Sprite Says "Hello" Project
read_ref = db.reference('sprite_says_hello')

while True:
    word = str(raw_input("Enter a word: "))
    if word == "kill":  # Use this to stop loop
        break
    else:
        new_str = "Hello " + word
        data_to_upload = {'Word': new_str}
        read_ref.set(data_to_upload)
