using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveracket : MonoBehaviour
{   //This is the speed of the racket mouvement
    public float speed = 30;

 void FixedUpdate()
    {
        //This is our GetAxisRaw input 
        float v = Input.GetAxisRaw("Vertical") * speed;
        //Just calling the Rigidbody2D component to change its Velocity value
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v);
    }
}
