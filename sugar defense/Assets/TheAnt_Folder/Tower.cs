using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Tower : MonoBehaviour
{
    private Camera _cam;
    private GameObject rotationtower;
    Vector3 mousePos;

    // Start is called before the first frame update
    void Awake()
    {
        _cam = Camera.main;
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
        //Vector3 rotation = Quaternion.Lerp(baset.rotation, lookRotation, Time.deltaTime * rotationSpeed).eulerAngles;
        //makes it so it only rotates around the Y-axis
        //baset.rotation = Quaternion.Euler(0f, rotation.y, 0f);
    }
}
