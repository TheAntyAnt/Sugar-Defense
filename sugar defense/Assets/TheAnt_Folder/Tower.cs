using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Tower : MonoBehaviour
{
    //finds the camera
    public Camera _cam;
    //finds th eposition of the mouse
    Vector3 mousePos;

    [SerializeField] private Shooting projectilePrefab;

    [SerializeField] private Transform spawnPoint;


    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //finds the position of the mouse relative to the middle of the world
        mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        //turns the turret to the position of the mouse
        transform.up = mousePos;

        //when the left mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            //a projectilePrefab is created at the spawnPoint
            Instantiate(projectilePrefab, spawnPoint.position, Quaternion.identity).Init(transform.up);
        }
    }
}
