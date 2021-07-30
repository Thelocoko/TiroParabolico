using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public AudioClip gameplay;
    public AudioClip gameover;
    public AudioClip up;
    public AudioClip crahs;    
    public Text count;
    public Text finalTime;
    public float time;
    public float finalT;
    public double FFF;
    public GameObject escena;
    public GameObject boton;
    public GameObject marcadores;
    public GameObject control;
    public int triger;
    
    AudioSource fuente;
    
    void sounds()
    {        
        if(triger == 1)
        {
            Handheld.Vibrate();
        }
        if(triger == 2)
        {                
        Handheld.Vibrate();            
        fuente.clip = gameover;        
        fuente.Play();
        } 
    }
    void Start()
    {
        count.text = time.ToString("F2");
        fuente = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        triger++;
        sounds();        
    }
    void Update()
    {
        Mathematics an = GetComponent<Mathematics>();
        FFF = an.Time;
        if (triger == 1)
        {
            finalT = time += Time.deltaTime;
            count.text = (time/10).ToString("F2");
            finalTime.text = (FFF).ToString("F2");                                    
        }

        if(triger == 2)
        {
            control.SetActive(false);
            boton.SetActive(false);
            marcadores.SetActive(false);
            escena.SetActive(true);                                
        }
    }
}
