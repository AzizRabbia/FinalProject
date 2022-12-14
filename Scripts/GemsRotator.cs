using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemsRotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    { // rotate the gems 
        transform.Rotate(0, 0, 250f * Time.deltaTime);
    }
}
