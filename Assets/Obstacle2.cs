using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle2 : MonoBehaviour
{
    Vector3 pointC = new Vector3(27, 1, -13);
    Vector3 pointD = new Vector3(33, 1, -13);

    void Update()
    {
        transform.position = Vector3.Lerp(pointC, pointD, Mathf.PingPong(Time.time, 1));
    }

}
