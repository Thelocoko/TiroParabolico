using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stateTutorial : MonoBehaviour
{
    public int est = 0;
    private int alv;
    public GameObject backs;
    public GameObject tut;
    public GameObject fix;
    public GameObject gameplay;
    public GameObject personaje;    
    void Start()
    {        
        tutorial();                        
    }
    void tutorial()
    {
        if(state.estadojuego.estado > est)
        {
            backs.SetActive(true);
            tut.SetActive(false);
            fix.SetActive(true);
            gameplay.SetActive(true);
            personaje.SetActive(false);
        }        
    }
    public void but()
    {
        est++;
        state.estadojuego.estado = est;
        state.estadojuego.Guardar();
    }
    public void mos()
    {
        alv = est--;
        state.estadojuego.estado = alv;
        state.estadojuego.Guardar();
    }
}
