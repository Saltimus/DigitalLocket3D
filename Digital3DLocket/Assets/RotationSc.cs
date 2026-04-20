using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class RotationSc : MonoBehaviour
{
    [SerializeField] private GameObject objectToRotate;
    [SerializeField] private float rotationSpeed = 10;
    public void FixedUpdate()
    {
        objectToRotate.transform.Rotate(objectToRotate.transform.up, rotationSpeed * Time.deltaTime);
    }



}
