using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallaxMenu : MonoBehaviour
{    
    public float velocidad = 0f;            
    void Update()
    {
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Time.time * velocidad,0);                   
    }
}
