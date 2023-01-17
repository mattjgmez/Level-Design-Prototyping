using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AsteroidHolder : MonoBehaviour
{
    void Update()
    {
        foreach (Transform asteroid in transform)
        {
            asteroid.transform.RotateAround(transform.position, Vector3.down, 20 * Time.deltaTime);
        }
    }
}
