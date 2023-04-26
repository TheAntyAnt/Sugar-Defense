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
        Heal = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))

        {
            Heal += +1;
        }
     
        Fill.localScale = new Vector3(Heal* 0.01f, 0.9f, 0.876f);

     
    }


}
