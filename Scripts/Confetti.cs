using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confetti : MonoBehaviour
{
    public ParticleSystem psconfetti;
    private void OnTriggerEnter(Collider other)
    {   // when player reaches the final stage win the player and show confetti(celebration particles)
        if(other.gameObject.tag == "Player")
        {
            psconfetti.Play();
        }
    }
}
