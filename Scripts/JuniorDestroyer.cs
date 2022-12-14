using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuniorDestroyer : MonoBehaviour
{
    public GameObject junior;
    private void OnTriggerEnter(Collider other)
    { // when player collide with juniors ,destroy them
        if(other.gameObject.tag == "Player")
        {
            junior.gameObject.SetActive(false);
        }        
    }
}
