using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public Player_Movement speed;
    public SizeIncrease health;
    public GemCollector gem;
    public Image healthBarSprite;
    public Image gemBarSprite;


    private void Start()
    {  // active health and gem bar 
        panel2.SetActive(true);
      // deactive restart button
        panel3.SetActive(false);
    }


    public void PlayGame()
    {
        panel1.SetActive(false);
        speed.PlayerMovementSpeed = 11.5f;
        panel2.SetActive(true);
    }

    //when player health equal to  zero,stop player speed and active panel 3(restart)
    public void GameOverHealth()
    {
        if(health.currentHealth == 0)
        {
            speed.LeftRightSpeed = 0;
            panel3.SetActive(true);

        }
        
    }
    //when player collide with hazard cylinder,game is over and panel3(RestartButton) is active
    public void GameOverHazardCylinder()
    {
        panel3.SetActive(true);
    }
    //restart the game
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Update()
    {
        //give percentage of gem and health bar in form of fill amount
        healthBarSprite.fillAmount = health.currentHealth / health.maxHealth;
        gemBarSprite.fillAmount = gem.currentgem / gem.maxgem;
        GameOverHealth();
    }
    //calls when user finishes level1
    public void NextLevelPanel()
    {
        panel4.SetActive(true);
    }

    //calls when user finishes level2
    public void LevelTwoFinishPanel()
    {
        panel5.SetActive(true);
    }
    //load  the level 2
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //load the level 1
    public void LoadLevelOneScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
