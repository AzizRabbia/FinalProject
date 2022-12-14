using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public SkinnedMeshRenderer color;

    // Start is called before the first frame update
    void Start()
    {
        color = GetComponent<SkinnedMeshRenderer>();
    }
    //change the color of player
    public void ChangetoRedColor()
    {
        color.material.SetColor("_Color", Color.red);
    }

    public void ChangetoYellowColor()
    {
        color.material.SetColor("_Color", Color.yellow);
    }

    public void ChangetoGreenColor()
    {
        color.material.SetColor("_Color", Color.green);
    }

}
