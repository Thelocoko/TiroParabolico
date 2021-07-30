using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundlvl1 : MonoBehaviour
{    
    public AudioClip up;
    public AudioClip crahs;
    public int triger;
    
    AudioSource fuente;
    void sounds()
    {       
        if(triger == 1)
        {
        fuente.clip = up;
        fuente.Play();
        }
        if(triger == 2)
        {        
        fuente.clip = crahs;
        fuente.Play();        
        }
    }
    void Start()
    {
        fuente = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {       
        triger++;
        sounds();
    }       
}
