using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceObject : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public float distance;
    public float meters;
    public float triyer;
    public Text distancetxt;
    public Text Fdistancetxt;
    void Start()
    {
        SetDistance();
    }


    void Update()
    {
        distance = Vector3.Distance(object1.transform.position, object2.transform.position);
        SetDistance();
    }

    void SetDistance()
    {
        Timer tim = GetComponent<Timer>();
        triyer = tim.triger;
        if(triyer == 1)
        {
            if (distance <= 100)
            {
                distancetxt.text = distance.ToString("0") + " Centimetros";
                Fdistancetxt.text = distance.ToString("0") + " Centimetros";
            }
            else
            {
                int ten = 100;
                meters = (distance / ten);
                distancetxt.text = meters.ToString("0.00") + " Metros";
                Fdistancetxt.text = meters.ToString("0.00") + " Metros";
            }
        }
    }
}
