using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Tower : MonoBehaviour
{
    public Camera _cam;
    Vector3 mousePos;
    public Transform RotationPoint;
    public float rotationSpeed = 10f;

    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        transform.up = mousePos;
    }
}
