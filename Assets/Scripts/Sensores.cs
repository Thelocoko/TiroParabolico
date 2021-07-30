using UnityEngine;
using UnityEngine.UI;

public class Sensores : MonoBehaviour
{
    public Transform Obj;

    [Range(-1, 1)]
    public float X;

    [Range(-1, 1)]
    public float Y;

    [Range(-1, 1)]
    public float Z;
     
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 vector = Input.acceleration;

        X = vector.x;
        Y = vector.y;
        Z = vector.z;
    }
}
