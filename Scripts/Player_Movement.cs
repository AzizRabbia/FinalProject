using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{ 
    public UI ui;//ref from UI script
    public AudioSource colorsound;
    public AudioSource deathsound;
    public AudioSource final;
    public int PlayerState;
    public Rigidbody player;
    public float PlayerMovementSpeed;
    public float LeftRightSpeed;
    public ColorChanger cc;


    private void Awake()
    {
        PlayerMovementSpeed = 0f;
        LeftRightSpeed = 0.03f;
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }
    
    void LeftRightMovement()
    {  //Player Movement using left and right arrow keys
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(LeftRightSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(LeftRightSpeed, 0, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    { // if player collide with color light, change its color and state and play sound
        if (other.gameObject.tag == "GreenLight")
        {
            cc.ChangetoGreenColor();
            PlayerState = 1;
            colorsound.Play();
            Debug.Log(PlayerState);
        }

        if (other.gameObject.tag == "RedLight")
        {
            cc.ChangetoRedColor();
            PlayerState = 2;
            colorsound.Play();
            Debug.Log(PlayerState);
        }

        if (other.gameObject.tag == "YellowLight")
        {
            cc.ChangetoYellowColor();
            PlayerState = 3;
            colorsound.Play();
            Debug.Log(PlayerState);
        }
        //if player collide with hurdle,stop the player and player death animation
        if (other.gameObject.tag == "HazardCylinder")
        {
            PlayerMovementSpeed = 0f;
            deathsound.Play();
            LeftRightSpeed = 0;
        //Sets the player position backwards from cylinder so it doesnot collide with it again and produce death sound.
            player.transform.position -= new Vector3(0, 0, 0.5f);
            ui.GameOverHazardCylinder();
   
        }
        //if player collide with final ,stop player movement and play victory sound
        if (other.gameObject.tag == "Final")
        {
            PlayerMovementSpeed = 0f;
            final.Play();
            LeftRightSpeed = 0;
        //if loaded scene is level 1,display panel 4(next level),otherwise display panel 5(Restart whole game)
            if(SceneManager.GetActiveScene().buildIndex == 0)
            {
                ui.NextLevelPanel();
            }
            else
            { 
                ui.LevelTwoFinishPanel();
            }
            
        }
       
    }

    public void Movement()
    {
        transform.position += new Vector3(0, 0, PlayerMovementSpeed * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
       Movement(); 
       LeftRightMovement(); 
    }
}