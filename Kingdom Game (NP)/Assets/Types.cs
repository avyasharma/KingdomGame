using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Types : MonoBehaviour
{

    public string characterName;

    public int swordTypePoints;
    public int lanceTypePoints;
    public int axeTypePoints;
    public int bowTypePoints;
    public int gauntletTypePoints;
    public int shurikenTypePoints;
    public int fireTypePoints;
    public int waterTypePoints;
    public int windTypePoints;
    public int plasmaTypePoints;
    public int lightTypePoints;
    public int darkTypePoints;
    public int dragonTypePoints;

    public int swordTypeLevel = 1;
    public int lanceTypeLevel = 1;
    public int axeTypeLevel = 1;
    public int bowTypeLevel = 1;
    public int gauntletTypeLevel = 1;
    public int shurikenTypeLevel = 1;
    public int fireTypeLevel = 1;
    public int waterTypeLevel = 1;
    public int windTypeLevel = 1;
    public int plasmaTypeLevel = 1;
    public int lightTypeLevel = 1;
    public int darkTypeLevel = 1;
    public int dragonTypeLevel = 1;

    public int level2Reqirement;
    public int level3Reqirement;
    public int level4Reqirement;
    public int levelMaxReqirement;


    public Types(string cName){
      characterName = cName;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void typeLevelUpCheck(string charName, string type){
      if(charName.Equals(characterName)){
        if(type.Equals("Sword")){
          if(swordTypeLevel < 5){
            swordTypePoints = swordTypePoints + 1;
            if(swordTypePoints == levelMaxReqirement){
              swordTypeLevel = 5;
            }
            else if(swordTypePoints == level4Reqirement){
              swordTypeLevel = 4;
            }
            else if(swordTypePoints == level3Reqirement){
              swordTypeLevel = 3;
            }
            else if(swordTypePoints == level2Reqirement){
              swordTypeLevel = 2;
            }
          }
        }

        if(type.Equals("Lance")){
          if(lanceTypeLevel < 5){
            lanceTypePoints = lanceTypePoints + 1;
            if(lanceTypePoints == levelMaxReqirement){
              lanceTypeLevel = 5;
            }
            else if(lanceTypePoints == level4Reqirement){
              lanceTypeLevel = 4;
            }
            else if(lanceTypePoints == level3Reqirement){
              lanceTypeLevel = 3;
            }
            else if(lanceTypePoints == level2Reqirement){
              lanceTypeLevel = 2;
            }
          }
        }

        if(type.Equals("Axe")){
          if(axeTypeLevel < 5){
            axeTypePoints = axeTypePoints + 1;
            if(axeTypePoints == levelMaxReqirement){
              axeTypeLevel = 5;
            }
            else if(axeTypePoints == level4Reqirement){
              axeTypeLevel = 4;
            }
            else if(axeTypePoints == level3Reqirement){
              axeTypeLevel = 3;
            }
            else if(axeTypePoints == level2Reqirement){
              axeTypeLevel = 2;
            }
          }
        }

        if(type.Equals("Bow")){
          if(bowTypeLevel < 5){
            bowTypePoints = bowTypePoints + 1;
            if(bowTypePoints == levelMaxReqirement){
              bowTypeLevel = 5;
            }
            else if(bowTypePoints == level4Reqirement){
              bowTypeLevel = 4;
            }
            else if(bowTypePoints == level3Reqirement){
              bowTypeLevel = 3;
            }
            else if(bowTypePoints == level2Reqirement){
              bowTypeLevel = 2;
            }
          }
        }

        if(type.Equals("Gauntlet")){
          if(gauntletTypeLevel < 5){
            gauntletTypePoints = gauntletTypePoints + 1;
            if(gauntletTypePoints == levelMaxReqirement){
              gauntletTypeLevel = 5;
            }
            else if(gauntletTypePoints == level4Reqirement){
              gauntletTypeLevel = 4;
            }
            else if(gauntletTypePoints == level3Reqirement){
              gauntletTypeLevel = 3;
            }
            else if(gauntletTypePoints == level2Reqirement){
              gauntletTypeLevel = 2;
            }
          }
        }

        if(type.Equals("Shuriken")){
          if(shurikenTypeLevel < 5){
            shurikenTypePoints = shurikenTypePoints + 1;
            if(shurikenTypePoints == levelMaxReqirement){
              shurikenTypeLevel = 5;
            }
            else if(shurikenTypePoints == level4Reqirement){
              shurikenTypeLevel = 4;
            }
            else if(shurikenTypePoints == level3Reqirement){
              shurikenTypeLevel = 3;
            }
            else if(shurikenTypePoints == level2Reqirement){
              shurikenTypeLevel = 2;
            }
          }
        }

        if(type.Equals("Fire")){
          if(fireTypeLevel < 5){
            fireTypePoints = fireTypePoints + 1;
            if(fireTypePoints == levelMaxReqirement){
              fireTypeLevel = 5;
            }
            else if(fireTypePoints == level4Reqirement){
              fireTypeLevel = 4;
            }
            else if(fireTypePoints == level3Reqirement){
              fireTypeLevel = 3;
            }
            else if(fireTypePoints == level2Reqirement){
              fireTypeLevel = 2;
            }
          }
        }

        if(type.Equals("Water")){
          if(waterTypeLevel < 5){
            waterTypePoints = waterTypePoints + 1;
            if(waterTypePoints == levelMaxReqirement){
              waterTypeLevel = 5;
            }
            else if(waterTypePoints == level4Reqirement){
              waterTypeLevel = 4;
            }
            else if(waterTypePoints == level3Reqirement){
              waterTypeLevel = 3;
            }
            else if(waterTypePoints == level2Reqirement){
              waterTypeLevel = 2;
            }
          }
        }

        if(type.Equals("Wind")){
          if(windTypeLevel < 5){
            windTypePoints = windTypePoints + 1;
            if(windTypePoints == levelMaxReqirement){
              windTypeLevel = 5;
            }
            else if(windTypePoints == level4Reqirement){
              windTypeLevel = 4;
            }
            else if(windTypePoints == level3Reqirement){
              windTypeLevel = 3;
            }
            else if(windTypePoints == level2Reqirement){
              windTypeLevel = 2;
            }
          }
        }

        if(type.Equals("Plasma")){
          if(plasmaTypeLevel < 5){
            plasmaTypePoints = plasmaTypePoints + 1;
            if(plasmaTypePoints == levelMaxReqirement){
              plasmaTypeLevel = 5;
            }
            else if(plasmaTypePoints == level4Reqirement){
              plasmaTypeLevel = 4;
            }
            else if(plasmaTypePoints == level3Reqirement){
              plasmaTypeLevel = 3;
            }
            else if(plasmaTypePoints == level2Reqirement){
              plasmaTypeLevel = 2;
            }
          }
        }

        if(type.Equals("Light")){
          if(lightTypeLevel < 5){
            lightTypePoints = lightTypePoints + 1;
            if(lightTypePoints == levelMaxReqirement){
              lightTypeLevel = 5;
            }
            else if(lightTypePoints == level4Reqirement){
              lightTypeLevel = 4;
            }
            else if(lightTypePoints == level3Reqirement){
              lightTypeLevel = 3;
            }
            else if(lightTypePoints == level2Reqirement){
              lightTypeLevel = 2;
            }
          }
        }

        if(type.Equals("Dark")){
          if(darkTypeLevel < 5){
            darkTypePoints = darkTypePoints + 1;
            if(darkTypePoints == levelMaxReqirement){
              darkTypeLevel = 5;
            }
            else if(darkTypePoints == level4Reqirement){
              darkTypeLevel = 4;
            }
            else if(darkTypePoints == level3Reqirement){
              darkTypeLevel = 3;
            }
            else if(darkTypePoints == level2Reqirement){
              darkTypeLevel = 2;
            }
          }
        }

        if(type.Equals("Dragon")){
          if(dragonTypeLevel < 5){
            dragonTypePoints = dragonTypePoints + 1;
            if(dragonTypePoints == levelMaxReqirement){
              dragonTypeLevel = 5;
            }
            else if(dragonTypePoints == level4Reqirement){
              dragonTypeLevel = 4;
            }
            else if(dragonTypePoints == level3Reqirement){
              dragonTypeLevel = 3;
            }
            else if(dragonTypePoints == level2Reqirement){
              dragonTypeLevel = 2;
            }
          }
        }
      }
    }

    public string getTypePointsAndLevel(string charName, string type){
      if(characterName.Equals(charName)){
        if(type.Equals("Sword")){
          if(swordTypeLevel == 5){
            return "Sword Type is Maxed!";
          }
          else{
            return "Sword Type Level: " + swordTypeLevel + " Points: " + swordTypePoints;
          }
        }

        if(type.Equals("Lance")){
          if(lanceTypeLevel == 5){
            return "Lance Type is Maxed!";
          }
          else{
            return "Lance Type Level: " + lanceTypeLevel + " Points: " + lanceTypePoints;
          }
        }

        if(type.Equals("Axe")){
          if(axeTypeLevel == 5){
            return "Axe Type is Maxed!";
          }
          else{
            return "Axe Type Level: " + axeTypeLevel + " Points: " + axeTypePoints;
          }
        }

        if(type.Equals("Bow")){
          if(bowTypeLevel == 5){
            return "Bow Type is Maxed!";
          }
          else{
            return "Bow Type Level: " + bowTypeLevel + " Points: " + bowTypePoints;
          }
        }

        if(type.Equals("Gauntlet")){
          if(gauntletTypeLevel == 5){
            return "Gauntlet Type is Maxed!";
          }
          else{
            return "Gauntlet Type Level: " + gauntletTypeLevel + " Points: " + gauntletTypePoints;
          }
        }

        if(type.Equals("Shuriken")){
          if(shurikenTypeLevel == 5){
            return "Shuriken Type is Maxed!";
          }
          else{
            return "Shuriken Type Level: " + shurikenTypeLevel + " Points: " + shurikenTypePoints;
          }
        }

        if(type.Equals("Fire")){
          if(fireTypeLevel == 5){
            return "Fire Type is Maxed!";
          }
          else{
            return "Fire Type Level: " + fireTypeLevel + " Points: " + fireTypePoints;
          }
        }

        if(type.Equals("Water")){
          if(waterTypeLevel == 5){
            return "Water Type is Maxed!";
          }
          else{
            return "Water Type Level: " + waterTypeLevel + " Points: " + waterTypePoints;
          }
        }

        if(type.Equals("Wind")){
          if(windTypeLevel == 5){
            return "Wind Type is Maxed!";
          }
          else{
            return "Wind Type Level: " + windTypeLevel + " Points: " + windTypePoints;
          }
        }

        if(type.Equals("Plasma")){
          if(plasmaTypeLevel == 5){
            return "Plasma Type is Maxed!";
          }
          else{
            return "Plasma Type Level: " + plasmaTypeLevel + " Points: " + plasmaTypePoints;
          }
        }

        if(type.Equals("Light")){
          if(lightTypeLevel == 5){
            return "Light Type is Maxed!";
          }
          else{
            return "Light Type Level: " + lightTypeLevel + " Points: " + lightTypePoints;
          }
        }

        if(type.Equals("Dark")){
          if(darkTypeLevel == 5){
            return "Dark Type is Maxed!";
          }
          else{
            return "Dark Type Level: " + darkTypeLevel + " Points: " + darkTypePoints;
          }
        }

        if(type.Equals("Dragon")){
          if(dragonTypeLevel == 5){
            return "Dragon Type is Maxed!";
          }
          else{
            return "Dragon Type Level: " + dragonTypeLevel + " Points: " + dragonTypePoints;
          }
        }
        return "No Type!";
      }
      return "No Type!";
    }
}
