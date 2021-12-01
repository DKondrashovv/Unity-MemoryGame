using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text ScoreDisplay;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreDisplay.text = "Счёт: " + score.ToString();
    }
    public void Plus()
    {
        score++;

        
    }
}
