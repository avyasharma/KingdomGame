using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWinScript : MonoBehaviour
{

    Classes classes;
    CharacterStats character;
    public int winPicker;

    // Start is called before the first frame update
    void Start()
    {
      classes = GameObject.Find("GameManager").GetComponent<Classes>();
      character = GameObject.Find("Character 1").GetComponent<CharacterStats>();
      winPicker = Random.Range(1, 2);
      if(winPicker == 1){
        levelUpScreen(character.getCharacterName());
      }
      else{
        enemyWin(character.getCharacterName());
      }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void levelUpScreen(string cName){
      string print = character.endOfCombat();
      Debug.Log(print);
    }

    public void enemyWin(string cName){
      Debug.Log(cName + " has fallen!");
    }
}
