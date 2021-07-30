using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mathematics : MonoBehaviour
{
    public Text Velocidadtxt;
    public Text Alturatxt;    
    public Text Tiempotxt;    
    public Text DistanciaXtxt;    
    public Text DistanciaYtxt;        
    public Text DistanciaStxt;
    public float tiempo;
    public float tiempos;    
    public float distancia;    
    public double operacionX;
    public double operacionY;
    public float triyer;    
    public double angulo;
    public double Vel;
    public double anguloR;
    public double cua;
    public double Alt;
    public double sin;
    public double Time;
    public Slider sliderInstance;
    
    void Update()
    {
        AngleObject an = GetComponent<AngleObject>();
        Timer tim = GetComponent<Timer>();
        DistanceObject dis = GetComponent<DistanceObject>();
        angulo = an.angle;
        tiempo = tim.finalT;
        triyer = tim.triger;
        distancia = dis.distance;
        if (triyer == 1)
        {
            //Velocidad inicial
            anguloR = angulo * Mathf.PI / 180;
            sin = Math.Sin(anguloR);            
            Vel = Math.Sqrt(((distancia/100)*9.81)/(Math.Sin(2 * anguloR)));
            Velocidadtxt.text = Vel.ToString("0.00") + " m/s2";
            //Altura maxima
            cua = Vel * Vel;
            Alt = (cua * (sin * sin)) / (2 *9.81);                        
            Alturatxt.text = Alt.ToString("0.00") + " metros";
            DistanciaStxt.text = (distancia/100).ToString("0.00");
            Time = ((Vel * 2) * sin)/9.81;
        }                                    
    }    
    public void OnValueChanged(float value)
    {                
        AngleObject an = GetComponent<AngleObject>();
        Timer tim = GetComponent<Timer>();
        DistanceObject dis = GetComponent<DistanceObject>();
        angulo = an.angle;        
        distancia = dis.distance;                
        
        tiempos = (float)Time;
        sliderInstance.maxValue = tiempos;
        Tiempotxt.text = value.ToString("0.00");    
        
        operacionX = (Vel*Math.Cos((angulo * Mathf.PI / 180)) * value);
        DistanciaXtxt.text = operacionX.ToString("0.00");
        
        operacionY = (Vel*Math.Sin((angulo * Mathf.PI / 180)) * value + 0.5 * -9.81 * (value * value));
        if(operacionY <= Alt)
        {
        DistanciaYtxt.text = operacionY.ToString("0.00");
        }
        else
        {
        operacionY = (Vel*Math.Sin((angulo * Mathf.PI / 180)) * value + 0.5 * -9.81 * (value * value));
        DistanciaYtxt.text = operacionY.ToString("0.00");
        }        
    }
}
