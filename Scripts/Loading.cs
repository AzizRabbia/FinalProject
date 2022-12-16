using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    private float time;
    private float sec;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        sec = 5;
        //load game func execute after 5sec of delay
        Invoke("LoadGame", 5f);
    }
    public void LoadGame() 
    { //load level 1
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        if (time < 5)
        {
            time += Time.deltaTime;
            image.fillAmount = time / sec;
        }
    }
}
