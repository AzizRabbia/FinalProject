using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animations : MonoBehaviour
{
   
    public Animator anim;
    public Rigidbody player;

    public Player_Movement Speed;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Running()
    {
        if (Speed.PlayerMovementSpeed == 11.5f)
        {
            anim.SetBool("IsBreathing", false);
            anim.SetBool("IsRunning", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Final")
        {
            anim.SetBool("IsRunning", false);
            anim.SetBool("Win", true);
            Debug.Log("Win");
           
        }
    }


    // Update is called once per frame
    void Update()
    {
        Running();
        
    }
}
