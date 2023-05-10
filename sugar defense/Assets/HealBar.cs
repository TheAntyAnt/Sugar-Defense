using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealBar : MonoBehaviour
{
    public float Heal;
    public string Fool;
    public Transform Fill;
    public string Lose;

    // Start is called before the first frame update
    void Start()
    {
        Heal = 90f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))

        {
            Heal += -23;
        }

        if (Heal <= 0)
        {
            SceneManager.LoadScene(Lose);
        }
     
        Fill.localScale = new Vector3(Heal* 0.01f, 0.9f, 0.876f);

     
    }


}
