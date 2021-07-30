using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngleObject : MonoBehaviour
{
	public Transform target;
    public Text Angletxt;
    public float angle;
    public float tiempo;
    public Vector2 direction;
    public float sign = 0;
    public float offset = 1;
	
	void Update ()
	{
    Timer ty = GetComponent<Timer>();
        tiempo = ty.finalT;
        if (tiempo < 1)
        {
            direction = target.position - transform.position;
            sign = (direction.y >= 0) ? 1 : -1;
            offset = (sign >= 0) ? 0 : 360;

            angle = Vector2.Angle(Vector2.right, direction) * sign + offset;

            Angletxt.text = angle.ToString("0.00") + "°";
        }
	}
}