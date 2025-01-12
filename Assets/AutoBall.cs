using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBall : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        NotifyVelocity();
    }

    void NotifyVelocity() {
        //Debug.Log(rb2d.velocity.magnitude);


        if (rb2d.velocity.magnitude < 1.1f) {
            //Debug.Log("Stop");
            rb2d.velocity = Vector2.zero * 0f;
         
        }
        
    }
}
