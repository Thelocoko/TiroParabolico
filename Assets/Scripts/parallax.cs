using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{    
    public Timer scripta;
    public float velocidad = 0f;            
    void Update()
    {        
        if(scripta.triger == 1)
        {
            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Time.time * velocidad,0);            
        }
    }
}
