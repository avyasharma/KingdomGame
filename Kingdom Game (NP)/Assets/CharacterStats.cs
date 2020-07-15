using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public string charName = "";

    public int unitLevel;
    public int unitExp;
    public int enemyLevel;

    public int physicalPower;
    public int magicPower;

    public int physicalDefense;
    public int magicDefense;
    public float HP;

    public string className = "";

    private string[] typeList;
    public string type1;
    public string type2;

    public List<string> useableTypes;
    //Will be of type weapons later down the line
    //Neutral, Up, Side, Down
    public string[] slots = new string[4];

    public int speed;
    public int strength;
    public int movement;

    public string abilityDescription = "";
    public float physicalPowerMultiplier = 1.0f;
    public float magicPowerMultiplier = 1.0f;

    public bool turnOver = false;

    [SerializeField]
    private bool isSelected;

    Classes characterClass;
    Types characterTypes;


    // Start is called before the first frame update
    void Start()
    {
      characterClass = new Classes(className);
      characterTypes = new Types(charName);
      typeList = characterClass.classTypes(className);
      type1 = typeList[0];
      type2 = typeList[1];
      useableTypes = characterClass.useableWeaponTypes(className);
      speed = characterClass.speedNum(className);
      strength = characterClass.strengthNum(className);
      movement = characterClass.movementNum(className);
      abilityDescription = characterClass.abilityDescription(className);
      physicalPowerMultiplier = characterClass.abilityPhysicalPowerMultiplier(className);
      magicPowerMultiplier = characterClass.abilityMagicPowerMultiplier(className);
      Debug.Log("POGCHAMP!");

    }

    /*public void getCharacterStats(){

    }*/

    // Update is called once per frame
    void Update()
    {
      for(int i = 0; i < 4; i++){
        if(useableTypes.Contains(slots[i]) == false){
          slots[i] = null;
        }
      }
    }

    public string getCharacterName(){
      return charName;
    }



    public void unitLevelUpCheck(string characterName){
      if(charName.Equals(characterName)){
        for(int i = 0; i < enemyLevel; i++){
          unitExp = unitExp + 1;
          if(unitExp >= unitLevel){
            unitLevel = unitLevel + 1;
            unitExp = 0;
          }
        }
      }
    }

    public string getUnitPointsAndLevel(string characterName){
      if(charName.Equals(characterName)){
        return "Unit Level: " + unitLevel + " Experience: " + unitExp;
      }

      return "Nothing Happened!";
    }

    public int getMovement(string cN){
      if(cN.Equals(charName)){
        Debug.Log("Movement Updated: " + movement);
        return movement;
      }
      return 0;
    }

    public void selected(){
      isSelected = true;
      Debug.Log("Selected Updated");
    }

    public void notSelected(){
      isSelected = false;
      Debug.Log("Selected Updated");
    }

    public void turnNowOver(){
      turnOver = true;
      Debug.Log("Turn Over");
    }

    public void transformPosition(float hPos, float vPos){
      transform.position = new Vector3(hPos, vPos, 0f);
    }

    public string endOfCombat(){
      unitLevelUpCheck(charName);
      characterClass.addClassPoints(className);
      for(int i = 0; i < 4; i++){
        characterTypes.typeLevelUpCheck(charName, slots[i]);
      }
      string typeCheckUp = "";
      for(int i = 0; i < 4; i++){
        if(slots[i] != null){
          typeCheckUp += (characterTypes.getTypePointsAndLevel(charName, slots[i]) + System.Environment.NewLine);
        }
      }
      Debug.Log(typeCheckUp);
      return (charName + ": " + System.Environment.NewLine + getUnitPointsAndLevel(charName) + System.Environment.NewLine + characterClass.getClassPointsAndLevel(className) + System.Environment.NewLine + typeCheckUp);
    }

    public virtual string ToString (){
      string str = "speed: " + speed + "strength: " + strength + "movement: " + movement + "Ability: " + abilityDescription;
      return str;
    }

}
