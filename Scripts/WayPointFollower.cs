using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{
    public GameObject[] Waypoints;
    private int currentWaypointIndex = 0;
    private float speed = 2f;

  // Update is called once per frame
    void Update()
    {  // calculate distance btw waypoints and hurdle
        if (Vector3.Distance(Waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= Waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        //taking current and targeted position of way points 
        transform.position = Vector3.MoveTowards(transform.position, Waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
        transform.Rotate(0, 0, 300f * Time.deltaTime);

    }
}
