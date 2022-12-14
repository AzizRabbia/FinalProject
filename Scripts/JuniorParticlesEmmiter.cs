using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuniorParticlesEmmiter : MonoBehaviour
{
    public ParticleSystem psgreen;
    public ParticleSystem psred;
    public ParticleSystem psyellow;
    public ParticleSystem pswater;

    public void EnableGreenEffect()
    {
        psgreen.Play();
    }

    public void EnableRedEffect()
    {
        psred.Play();
    }

    public void EnableYellowEffect()
    {
        psyellow.Play();
    }

    public void EnableWaterEffect()
    {
        pswater.Play();
    }

}
