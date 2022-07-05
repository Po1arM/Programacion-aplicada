using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    int currentScore = 0;
    public TMP_Text scoreText; 

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
    }

    public void IncrementScore(){
        currentScore++;
        scoreText.text = currentScore.ToString();
    }

}
