using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    public Rigidbody bricks;
    public AudioSource strike;
    
    private void Start()
    {
        bricks = GetComponent<Rigidbody>();  
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        { //when player collide with walls ,it strikes and force is applied to bricks
            bricks.AddForce(-30f, 40f, 50f);
            strike.Play();
        }
    }
}
