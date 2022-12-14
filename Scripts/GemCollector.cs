using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollector : MonoBehaviour
{
    public AudioSource gems;
    public GameObject gem;
    public float currentgem;
    public float maxgem;

    private void Start()
    { //activate the gem
        gem.gameObject.SetActive(true);
    }

    private void Awake()
    {
        currentgem = 0;
        maxgem = 32;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject. tag == "Gem")
        {
            currentgem = currentgem + 1;
            gems.Play();
            // when collide with one gem ,set it to false
            other.gameObject.SetActive(false);
        }

    }
}
