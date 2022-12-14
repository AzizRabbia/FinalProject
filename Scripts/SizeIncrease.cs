using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeIncrease : MonoBehaviour
{
    public AudioSource PlusSound;
    public AudioSource MinusSound;
    public GameObject player;
    public Player_Movement state;
    public Vector3 ScaleChange;
    public Vector3 WaterScaleChange;
    private float scaleSize=0.08f;
    private float waterscaleSize = 0.2f;
    public float maxHealth;
    public float currentHealth;

    private void Awake()
    {
        ScaleChange = new Vector3(scaleSize, scaleSize, scaleSize);
        WaterScaleChange = new Vector3(waterscaleSize,waterscaleSize,waterscaleSize);
        maxHealth = 10;
        currentHealth = 10;
    }
    private void OnTriggerEnter(Collider other)
    {  // scale  up  the player when  collide with same solor and play sound
        if(other.gameObject.tag == "GreenJunior")
        {
            
            if(state.PlayerState == 1)
            {
                transform.localScale += ScaleChange;
                currentHealth++;
                maxHealth++;
                PlusSound.Play();
            }
            // scale down the player when color is different and play sound
            else
            {
                transform.localScale -= ScaleChange;
                currentHealth--;
                MinusSound.Play();
            }
            //get script component and emit particles
            player.gameObject.GetComponent<JuniorParticlesEmmiter>().EnableGreenEffect();
        }
        
        if (other.gameObject.tag == "RedJunior")
        {
            // scale  up the player according to state when  collide with same solor and play sound
            if (state.PlayerState == 2)
            {
                transform.localScale += ScaleChange;
                currentHealth++;
                maxHealth++;
                PlusSound.Play();
            }
            else
            { // scale  up the player according to state when  collide with same solor and play sound
                transform.localScale -= ScaleChange;
                currentHealth--;
                MinusSound.Play();
            }
            //get script component and emit particles
            player.gameObject.GetComponent<JuniorParticlesEmmiter>().EnableRedEffect();
        }

        if (other.gameObject.tag == "YellowJunior")
        {
            
            if (state.PlayerState == 3)
            {
                transform.localScale += ScaleChange;
                currentHealth++;
                maxHealth++;
                PlusSound.Play();
            }
            else
            {
                transform.localScale -= ScaleChange;
                currentHealth--;
                MinusSound.Play();
            }
            //get script component and emit particles
            player.gameObject.GetComponent<JuniorParticlesEmmiter>().EnableYellowEffect();
        }
        // scale  down  the player when  collide with water and play sound
        if (other.gameObject.tag == "Water")
        {
            transform.localScale -= WaterScaleChange;
            currentHealth--;
            MinusSound.Play();
            player.gameObject.GetComponent<JuniorParticlesEmmiter>().EnableWaterEffect();
        }

    }


}
