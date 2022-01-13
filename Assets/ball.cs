using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 30;

    Vector2 speed;
    // Update is called once per frame
    void Start()
    {
        Vector2 speed = new Vector2(1,1);
        GetComponent<Rigidbody2D>().velocity = speed;
        // Initial Velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
}