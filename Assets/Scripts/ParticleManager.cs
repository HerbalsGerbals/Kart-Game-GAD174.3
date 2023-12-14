using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public ParticleSystem particlesystem;
    
    void Start()
    {
        //Stops it at the start
        particlesystem.Stop(); 
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            particlesystem.Play();
            //plays particles
        }
        else
        {
            particlesystem.Stop();
            //Stops Particles
        }
    }
}
