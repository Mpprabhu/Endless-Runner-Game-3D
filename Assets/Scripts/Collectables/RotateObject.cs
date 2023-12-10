using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotatespeed = 2;

void Update()
    {
        transform.Rotate(0,rotatespeed,0,Space.World);
    }
}
