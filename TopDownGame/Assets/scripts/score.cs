using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public static float points = 0f;
    TextMeshProUGUI scoretxt;
    public bool isHealthtxt;
    // Start is called before the first frame update
    void Start()
    {
        points = 0f;
        scoretxt = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isHealthtxt == true)
        {
            scoretxt.SetText("Health : "+CarController.health + "%");
        }

        else
        {
            scoretxt.SetText("Score : " + points);
        }
        
    }
}
