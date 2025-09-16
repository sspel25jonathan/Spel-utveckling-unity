using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class scoreB : MonoBehaviour
{
    public Text scoreText;

    int scoreS = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = scoreS.ToString() + " Points";
    }

    // Update is called once per frame
    public void scoreAddPoint()
    {
        scoreS += 1;
        scoreText.text = scoreS.ToString() + " Points";
    }
}
