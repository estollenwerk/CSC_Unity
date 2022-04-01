using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    Vector3 goUp, goDown, goLeft, goRight, goJump;
    public float speed = 2.0f;
    private Rigidbody rb;

    
    void Start() 
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        goUp = new Vector3(0f, 1f, 0f);
    }

    
    void Update()
    {
        
        
        if (Input.GetKeyDown("up"))
        {
            print("up key was pressed");
			rb.velocity = Vector3.forward * speed;
            
        }
        else if (Input.GetKeyDown("down"))
        {
            print("down key was pressed");
			rb.velocity = Vector3.back * speed;
            
        }
        else if (Input.GetKeyDown("left"))
        {
            print("left key was pressed");
			rb.velocity = Vector3.left * speed;
            
        }
        else if (Input.GetKeyDown("right"))
        {
            print("right key was pressed");
			rb.velocity = Vector3.right * speed;
            
        }
        else if (Input.GetKeyDown("space"))
        {
            rb.velocity = goUp * speed;
        }
    }
}
