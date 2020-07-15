using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CursorMovement : MonoBehaviour
{
    public float horizDistance;
    public float vertDistance;
    public float horizStart;
    public float vertStart;
    public float horizSelectedPos;
    public float vertSelectedPos;
    public bool playerSelected;

    private Collider2D coll;
    private Collider2D unit;
    private Collider2D enemySpace;

    //public bool isSelectedPositionBeingSet = false;
    [SerializeField]
    private int movementNum;

    CharacterStats character;

    [SerializeField]
    private string characterSelectedName = "";

    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("Character 1").GetComponent<CharacterStats>();
        transform.position = new Vector3(horizStart, vertStart, 0f);
        playerSelected = false;

        coll = gameObject.GetComponent<Collider2D>();
        unit = GameObject.FindGameObjectWithTag("Unit").GetComponent<Collider2D>();
        enemySpace = GameObject.FindGameObjectWithTag("Enemy Space").GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (character.turnOver == false) {
          if(coll.IsTouching(unit) && Input.GetButton("select")){
            playerSelected = true;
            characterSelectedName = character.getCharacterName();
            movementNum = character.getMovement(characterSelectedName);
            Debug.Log(character.ToString());
            Debug.Log("Movemnt Num is currently: " + character.getMovement(characterSelectedName));
            character.selected();
            setSelectedPosition();
          }

          if(playerSelected == true && Input.GetButton("Cancel")){
            playerSelected = false;
            characterSelectedName = null;
            movementNum = 0;
            character.notSelected();
          }

          if(coll.IsTouching(enemySpace) && Input.GetButton("select") && playerSelected == true){
            playerSelected = false;
            characterSelectedName = null;
            movementNum = 0;
            character.notSelected();
            character.turnNowOver();
            character.transformPosition(transform.position.x, transform.position.y);
            SceneManager.LoadScene("Combat Test");

          }

          /*if(playerSelected == true){
            (Mathf.Abs(transform.position.x - horizSelectedPos)) + (Mathf.Abs(transform.position.y - vertSelectedPos)) <= 4;
          } */

          if(Input.GetButton("right")){
            if((playerSelected == true) && ((Mathf.Abs(transform.position.x - horizSelectedPos)) + (Mathf.Abs(transform.position.y - vertSelectedPos)) >= movementNum) && (transform.position.x >= horizSelectedPos)){

            }
            else{
              transform.position += new Vector3(horizDistance, 0f, 0f);
            }
          }

          if(Input.GetButton("left")){
            if((playerSelected == true) && ((Mathf.Abs(transform.position.x - horizSelectedPos)) + (Mathf.Abs(transform.position.y - vertSelectedPos)) >= movementNum) && (transform.position.x <= horizSelectedPos)){

            }
            else{
              transform.position += new Vector3(-1 * horizDistance, 0f, 0f);
            }
          }

          if(Input.GetButton("up")){
            if((playerSelected == true) && ((Mathf.Abs(transform.position.x - horizSelectedPos)) + (Mathf.Abs(transform.position.y - vertSelectedPos)) >= movementNum) && (transform.position.y >= vertSelectedPos)){

            }
            else{
              transform.position += new Vector3(0f, vertDistance, 0f);
            }
          }

          if(Input.GetButton("down")){
            if((playerSelected == true) && ((Mathf.Abs(transform.position.x - horizSelectedPos)) + (Mathf.Abs(transform.position.y - vertSelectedPos)) >= movementNum) && (transform.position.y <= vertSelectedPos)){

            }
            else{
              transform.position += new Vector3(0f, -1 * vertDistance, 0f);
            }
          }
        }
    }

      public void setSelectedPosition(){
          horizSelectedPos = transform.position.x;
          vertSelectedPos = transform.position.y;
      }

}
