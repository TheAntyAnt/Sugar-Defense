using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    //variables that can be connected to gameobjects in the scene
    [SerializeField] private Rigidbody BulletRB;
    [SerializeField] private float BulletSpeed;

    //decides the speed of the bullet
    public void Init(Vector3 dir)
    {
        BulletRB.velocity = dir * BulletSpeed;
        //BulletRB.transform.rotation = ;
    }

    //what happens when bullet collides with something
    void OnCollisionEnter(Collision col)
    {
        //col.transform.GetComponent<put the name of the enemy script here>().death method goes here()

        Destroy(gameObject);
    }
}
