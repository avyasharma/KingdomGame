using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour
{

    public string className = "";

    public int crusaderPoints = 0;
    public int elementalPoints = 0;
    public int maxClassPoints;

    public bool isCrusaderMaxed = false;
    public bool isElementalMaxed = false;

    public Classes(string cName){
      className = cName;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public string[] classTypes(string className){
      string[] types = new string[2];
      if(className.Equals("Crusader")){
        types[0] = "Typeless";
        types[1] = "Typeless";
        return types;
      }
      if(className.Equals("Elemental")){
        types[0] = "Typeless";
        types[1] = "Typeless";
        return types;
      }
      return types;
    }

    public List<string> useableWeaponTypes(string className){
      List<string> useableTypes = new List<string>();
      if(className.Equals("Crusader")){
        useableTypes.Add("Light");
        useableTypes.Add("Axe");
        useableTypes.Add("Gauntlet");
        return useableTypes;
      }
      if(className.Equals("Elemental")){
        useableTypes.Add("Fire");
        useableTypes.Add("Water");
        useableTypes.Add("Plasma");
        return useableTypes;
      }
      return useableTypes;
    }

    public int speedNum(string className){
      if(className.Equals("Crusader")){
        return 3;
      }
      if(className.Equals("Elemental")){
        return 4;
      }
      return 0;
    }

    public int strengthNum(string className){
      if(className.Equals("Crusader")){
        return 5;
      }
      if(className.Equals("Elemental")){
        return 4;
      }
      return 0;
    }

    public int movementNum(string className){
      if(className.Equals("Crusader")){
        return 4;
      }
      if(className.Equals("Elemental")){
        return 4;
      }
      return 0;
    }

    public string abilityDescription(string className){
      if(className.Equals("Crusader")){
        return "Physical attacks do 1.1x damage";
      }
      if(className.Equals("Elemental")){
        return "Magic attacks do 1.1x damage";
      }
      return "";
    }

    public float abilityPhysicalPowerMultiplier(string className){
      if(className.Equals("Crusader")){
        return 1.1f;
      }
      if(className.Equals("Elemental")){
        return 1.0f;
      }
      return 1;
    }

    public float abilityMagicPowerMultiplier(string className){
      if(className.Equals("Crusader")){
        return 1.0f;
      }
      if(className.Equals("Elemental")){
        return 1.1f;
      }
      return 0;
    }

    public void addClassPoints(string className){
      if(className.Equals("Crusader") && isCrusaderMaxed == false){
        crusaderPoints = crusaderPoints + 1;
        maxClassLevelCheck("Crusader");
      }
      if(className.Equals("Elemental") && isElementalMaxed == false){
        elementalPoints = elementalPoints + 1;
        maxClassLevelCheck("Elemental");
      }
    }

    public void maxClassLevelCheck(string className){
      if(className.Equals("Crusader") && crusaderPoints == maxClassPoints){
        isCrusaderMaxed = true;
      }
      if(className.Equals("Elemental") && elementalPoints == maxClassPoints){
        isElementalMaxed = true;
      }
    }

    public string getClassPointsAndLevel(string className){
      if(className.Equals("Crusader")){
        if(isCrusaderMaxed == true){
          return "Crusader Class is Maxed!";
        }
        else{
          return "Crusader Class Points: " + crusaderPoints + "/" + maxClassPoints;
        }
      }

      if(className.Equals("Elemental") && elementalPoints == maxClassPoints){
        if(isElementalMaxed == true){
          return "Elemental Class is Maxed!";
        }
        else{
          return "Elemental Class Points: " + elementalPoints + "/" + maxClassPoints;
        }
      }

      return "No Class!";
    }


}
