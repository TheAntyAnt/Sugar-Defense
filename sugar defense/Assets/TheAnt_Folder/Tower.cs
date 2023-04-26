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
        
        //what direction is the mousepointer?
        Vector3 lookPos = mousePos - transform.position;

        Quaternion lookRotation = Quaternion.LookRotation(lookPos);
        //turn the complicated quaternion equation for rotation into nice and simple eulerAngles
        //eulerAngles is when you rotate something around an axis
        //Lerp makes it so it turns smoothly over a time
        Vector3 rotation = Quaternion.Lerp(RotationPoint.rotation, lookRotation, Time.deltaTime * rotationSpeed).eulerAngles;
        //makes it so it only rotates around the Z-axis
        RotationPoint.rotation = Quaternion.Euler(rotation.x, 0f, 0f);
    }
}
