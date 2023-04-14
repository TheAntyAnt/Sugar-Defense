using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealBar : MonoBehaviour
{
    public float Heal;
    public string Fool;
    public Transform Fill;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fill.localScale = new Vector3(Heal* 0.01f, 0, 0);
    }
}
