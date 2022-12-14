using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Death : MonoBehaviour
{
   
    public Player_Movement movement;
    public SizeIncrease healthCount;
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    { // when player collides with hurdles,player dies
        if (other.gameObject.tag == "HazardCylinder")
        {
            anim.SetBool("IsRunning", false);
            anim.SetBool("IsFalling", true);
          
        }
    }
    void Dead()
    { // when player health reaches zero ,die the player
        if(healthCount.currentHealth == 0.0f)
        {
            anim.SetBool("IsRunning", false);
            anim.SetBool("IsFalling", true);
            movement.PlayerMovementSpeed = 0f;
        }
    }

    private void Update()
    {
        Dead();
    }
}

