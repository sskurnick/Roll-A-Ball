using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Vector3 pointA = new Vector3(27, 1, 10);
    Vector3 pointB = new Vector3(33, 1, 10);
        
        void Update()
   
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}
