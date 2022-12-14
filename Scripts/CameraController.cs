using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float CameraZoomAngle;

    private void Awake()
    {
        CameraZoomAngle = 8f;
    }


    // Update is called once per frame
    void Update()
    {
        //to move camera behind the player
        transform.position = new Vector3(0, 7f, player.transform.position.z - CameraZoomAngle); 
    }
}
