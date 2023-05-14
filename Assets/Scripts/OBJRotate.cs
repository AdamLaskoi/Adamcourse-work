using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJRotate : MonoBehaviour
{
    [SerializeField] Vector3 axis = Vector3.up;
    [SerializeField] float angularSpeed = 180;
    [SerializeField] Space space = Space.Self;

    void Update()
    {
        transform.Rotate(axis, angularSpeed * Time.deltaTime, space);
    }
}
