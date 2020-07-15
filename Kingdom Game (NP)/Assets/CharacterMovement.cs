using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Collider2D coll;

    // Start is called before the first frame update
    void Start()
    {
      coll = gameObject.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
