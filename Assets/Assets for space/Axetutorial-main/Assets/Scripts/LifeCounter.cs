
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;
public class LifeCounter : MonoBehaviour
{

    public static LifeCounter instance;
    public HealthScript HealthScript;


    public Sprite HealthImage;

    public Image[] healths;

    private float life = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        life = HealthScript.Playerhealth;
        for (int i = 0; i < healths.Length; i++)
        {
            if (i < life)
            {
                healths[i].enabled = true;

            }
            else
            {
                healths[i].enabled = false;
            }
        }
    }


}
