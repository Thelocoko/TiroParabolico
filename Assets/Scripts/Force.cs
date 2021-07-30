using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Force : MonoBehaviour
{
    public Timer script;
    public Rigidbody2D TheBody;
    public Text forceTxt;
    public Text fic;
    public Text weightz;
    private double gravity = 0;
    public double forcess;

     Slider weight;
    
    void Awake()
    {
        TheBody = GetComponent<Rigidbody2D>();        
    }
    void Start()
    {        
        weight = GameObject.Find("weight").GetComponent<Slider>();
        weight.minValue = 1;
        weight.maxValue = 8;
        weight.wholeNumbers = true;
        weight.value = 1;
        weightz.text = "Peso: " + TheBody.mass.ToString();
    }
    void Update()
    {
        gravity = TheBody.gravityScale * 9.81;
        forcess = gravity * TheBody.mass;
        forceTxt.text = forcess.ToString("0.00")+ " Newtons";
        if(script.triger == 1)
        {            
            weight = GameObject.Find("weight").GetComponent<Slider>();
            weight.gameObject.SetActive(false);            
            weightz.gameObject.SetActive(false);
        }
        if(script.triger == 2)
        {
            fic.gameObject.SetActive(false);
        }
    }
    public void OnValueChanged(float value)
    {
        TheBody.mass = value;
        weightz.text = "Peso: " + TheBody.mass.ToString();
    }
}
