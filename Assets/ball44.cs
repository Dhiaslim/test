using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball44 : MonoBehaviour {
    public float speed = 30;

    // Start is called before the first frame update
    void Start()
    {
        // Initial Velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
}
