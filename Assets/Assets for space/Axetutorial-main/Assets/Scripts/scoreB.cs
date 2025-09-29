using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class scoreB : MonoBehaviour
{
    public TMP_Text score;
    public static scoreB instance;

    int scoreS = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreS += 1;
        score.text = scoreS.ToString() + " Points";
    }
    // Update is called once per frame
    public void ScoreAddPoint()
    {
        scoreS = scoreS + 1;
        score.text = scoreS.ToString() + " Points";
    }
}
