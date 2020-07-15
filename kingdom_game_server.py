# This is the Admin Code for the Kingdom Game
import firebase_admin
from firebase_admin import credentials
from firebase_admin import db

# This is for initializing the application and credentials with the private encryption skinnymonkey
# Replace the file path in the function call below with the file path of the encryption key file [.json] as it appears on your computer
filePaths = ["/Users/avi/Desktop/KingdomGame/kingdom-game-b900c-firebase-adminsdk-1cb4e-fcad7fd15b.json", "/Users/skinnymonkey/Documents/KingdomGame/kingdom-game-b900c-firebase-adminsdk-1cb4e-1156792b58.json"]
cred = credentials.Certificate(filePaths[0])
default_app = firebase_admin.initialize_app(cred, {'databaseURL':'https://kingdom-game-b900c.firebaseio.com/'})

# This is just to establish Admin Privileges [don't worry about this guys]
restricted_ref = db.reference('restricted_access/secret_document')

#The following Code is Purely for the Sprite Says "Hello" Project
"""read_ref = db.reference('sprite_says_hello')

while True:
    word = str(input("Enter a word: "))
    if word == "kill":  # Use this to stop loop
        break
    else:
        new_str = "Hello " + word
        data_to_upload = {'Word': new_str}
        read_ref.set(data_to_upload)"""

#The following code is to load the classes into the database.
class_ref = db.reference('class_attributes')

class Assassin:
    def __init__(self, pos, username):
        self.pos = pos
        self.unit_level = 1
        self.unit_points = 0
        self.type_level = 1
        self.type_points = 0
        self.class_level = 0
        self.class_points = 0
        self.user_name = username
        self.type = "typeless"
        self.prereqs = "Base"
        self.weapon_types = "Dark, Bow, Shuriken"
        self.stats = {"PP": 2, "MP": 2, "PD": 2, "MD": 2, "HP": 2, "Sp": 4, "St": 3, "Mo": 5}

    def toDict(self):
        data_for_assassin = {"Unit Level": self.unit_level,
                          "Unit Points": self.unit_points,
                          "Type Level": self.type_level,
                          "Type Points": self.type_points,
                          "Class Level": self.class_level,
                          "Class Points": self.class_points,
                          "Position": self.pos,
                          "Username": self.user_name,
                          "Type": self.type,
                          "Pre-reqs": self.prereqs,
                          "Weapon_types": self.weapon_types,
                          "Stats": self.stats
                          }
        return data_for_assassin

class Crusader:
    def __init__(self, pos, username):
        self.pos = pos
        self.unit_level = 1
        self.unit_points = 0
        self.type_level = 1
        self.type_points = 0
        self.class_level = 0
        self.class_points = 0
        self.user_name = username
        self.type = "typeless"
        self.prereqs = "Base"
        self.weapon_types = "Light, Axe, Gauntlet"
        self.stats = {"PP": 2, "MP": 2, "PD": 2, "MD": 2, "HP": 2, "Sp": 3, "St": 5, "Mo": 4}

    def toDict(self):
        data_for_crusader = {"Unit Level": self.unit_level,
                          "Unit Points": self.unit_points,
                          "Type Level": self.type_level,
                          "Type Points": self.type_points,
                          "Class Level": self.class_level,
                          "Class Points": self.class_points,
                          "Position": self.pos,
                          "Username": self.user_name,
                          "Type": self.type,
                          "Pre-reqs": self.prereqs,
                          "Weapon_types": self.weapon_types,
                          "Stats": self.stats
                          }
        return data_for_crusader

class Messenger:
    def __init__(self, pos, username):
        self.pos = pos
        self.unit_level = 1
        self.unit_points = 0
        self.type_level = 1
        self.type_points = 0
        self.class_level = 0
        self.class_points = 0
        self.user_name = username
        self.type = "Fire, Lance"
        self.prereqs = "None"
        self.weapon_types = "Fire, Lance, Bow"
        self.stats = {"PP": 2, "MP": 2, "PD": 2, "MD": 2, "HP": 2, "Sp": 4, "St": 3, "Mo": 5}

    def toDict(self):
        data_for_messenger = {"Unit Level": self.unit_level,
                          "Unit Points": self.unit_points,
                          "Type Level": self.type_level,
                          "Type Points": self.type_points,
                          "Class Level": self.class_level,
                          "Class Points": self.class_points,
                          "Position": self.pos,
                          "Username": self.user_name,
                          "Type": self.type,
                          "Pre-reqs": self.prereqs,
                          "Weapon_types": self.weapon_types,
                          "Stats": self.stats
                          }
        return data_for_messenger

class Samurai:
    def __init__(self, pos, username):
        self.pos = pos
        self.unit_level = 1
        self.unit_points = 0
        self.type_level = 1
        self.type_points = 0
        self.class_level = 0
        self.class_points = 0
        self.user_name = username
        self.type = "Sword"
        self.prereqs = "None"
        self.weapon_types = "Sword, Shuriken"
        self.stats = {"PP": 2, "MP": 2, "PD": 2, "MD": 2, "HP": 2, "Sp": 4, "St": 5, "Mo": 4}

    def toDict(self):
        data_for_samurai = {"Unit Level": self.unit_level,
                          "Unit Points": self.unit_points,
                          "Type Level": self.type_level,
                          "Type Points": self.type_points,
                          "Class Level": self.class_level,
                          "Class Points": self.class_points,
                          "Position": self.pos,
                          "Username": self.user_name,
                          "Type": self.type,
                          "Pre-reqs": self.prereqs,
                          "Weapon_types": self.weapon_types,
                          "Stats": self.stats
                          }
        return data_for_samurai

class DramaticHero:
    def __init__(self, pos, username):
        self.pos = pos
        self.unit_level = 1
        self.unit_points = 0
        self.type_level = 1
        self.type_points = 0
        self.class_level = 0
        self.class_points = 0
        self.user_name = username
        self.type = "Wind"
        self.prereqs = "None"
        self.weapon_types = "Wind, Gauntlet"
        self.stats = {"PP": 2, "MP": 2, "PD": 2, "MD": 2, "HP": 2, "Sp": 5, "St": 7, "Mo": 6}

    def toDict(self):
        data_for_hero = {"Unit Level": self.unit_level,
                          "Unit Points": self.unit_points,
                          "Type Level": self.type_level,
                          "Type Points": self.type_points,
                          "Class Level": self.class_level,
                          "Class Points": self.class_points,
                          "Position": self.pos,
                          "Username": self.user_name,
                          "Type": self.type,
                          "Pre-reqs": self.prereqs,
                          "Weapon_types": self.weapon_types,
                          "Stats": self.stats
                          }
        return data_for_hero

class Mistifier:
    def __init__(self, pos, username):
        self.pos = pos
        self.unit_level = 1
        self.unit_points = 0
        self.type_level = 1
        self.type_points = 0
        self.class_level = 0
        self.class_points = 0
        self.user_name = username
        self.type = "Water, Wind"
        self.prereqs = "Elemental"
        self.weapon_types = "Water, Wind, Bow, Shuriken"
        self.stats = {"PP": 2, "MP": 2, "PD": 2, "MD": 2, "HP": 2, "Sp": 4, "St": 3, "Mo": 5}

    def toDict(self):
        data_for_mistifier = {"Unit Level": self.unit_level,
                          "Unit Points": self.unit_points,
                          "Type Level": self.type_level,
                          "Type Points": self.type_points,
                          "Class Level": self.class_level,
                          "Class Points": self.class_points,
                          "Position": self.pos,
                          "Username": self.user_name,
                          "Type": self.type,
                          "Pre-reqs": self.prereqs,
                          "Weapon_types": self.weapon_types,
                          "Stats": self.stats
                          }
        return data_for_mistifier

#The following reference is for the updates from the front end. THIS INVOLVES THE LISTENER. NEED TO TEST.
update_ref = db.reference('updates')

def listener(event):
    d = event.data["Update"].split(" ")
    if d[0] == "POS":
        #keep in mind that this is the tester code right now. This will be replaced with the given user's position changing. For now, I want to test this out
        #and make sure that the conditionals work.
        print(event.event_type)
        print(event.path)
        print(event.data["Update"])
    else:
        pass

def main():
    assassin = Assassin(0, "N/A")

    crusader = Crusader(0, "N/A")

    messenger = Messenger(0, "N/A")

    samurai = Samurai(0, "N/A")

    dramaticHero = DramaticHero(0, "N/A")

    mistifier = Mistifier(0, "N/A")

    class_ref.set({"Assassin": assassin.toDict(),
                   "Crusader": crusader.toDict(),
                   "Messenger": messenger.toDict(),
                   "Samurai": samurai.toDict(),
                   "Dramatic Hero": dramaticHero.toDict(),
                   "Mistifier": mistifier.toDict()
                   })

    update_ref.set({"Update": "POS sexy piece of shit"})
    firebase_admin.db.reference('updates').listen(listener)


main()
