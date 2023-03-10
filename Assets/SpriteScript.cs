using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpPower;
    public LogicScript logic;
    public bool spriteActive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && spriteActive)
        {
            myRigidbody.velocity = Vector2.up * jumpPower;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        logic.hideInstructions();
        logic.endGame();
        spriteActive = false;
    }
}
