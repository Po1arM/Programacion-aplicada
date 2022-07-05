using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sphereGeneratorAula : MonoBehaviour
{
    Vector3 startingPos = new Vector3(-10.47f, 0,0);
    public GameObject speedCube,colorCube,enemy,life;
    float lastTime,nextTime;
    const float MIN_TIME = 1f, MAX_TIME = 1.3f;
    const float MIN_Y = -4.31f, MAX_Y = 4.31f;
    const float MOVEMENT_SPEED = 0.1f;
    //Crear una funcion que modifique MOVEMENT_SPEED por un periodo definido de tiempo
    int currentScore, currentLife;

    public TMP_Text scoreText;
    public TMP_Text lifeText;


    void Start()
    {
        currentScore = 0;
        currentLife = 3;
        lastTime = Time.time;
        nextTime = getNextTime();
    }

    void Update()
    {
        if (getDeltaTime() > nextTime)
        {
            startingPos.y = Random.Range(MIN_Y, MAX_Y);         
            Instantiate(randomObjectGenerator(), startingPos, Quaternion.identity);
            nextTime = getNextTime();
            lastTime = Time.time;
        }
    }
    float getDeltaTime()
    {
        return Time.time - lastTime;
    }
    float getNextTime()
    {
        return Random.Range(MIN_TIME, MAX_TIME);
    }

    public void speedUp()
    {
        
    }

    public void updateScore()
    {
        currentScore += 100;
        scoreText.text = currentScore.ToString();
    }

    public void updateLife(int value)
    {
        currentLife += value;
        lifeText.text = currentLife.ToString();
        if(currentLife == 0)
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;

        }
    }

    public GameObject randomObjectGenerator()
    {
        switch (Random.Range(0, 15))
        {
            case 0:
                return life;
            case 1:
                return speedCube;
            case 2:
                return colorCube;
            default:
                return enemy;
        }
    }
}
