using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementAula : MonoBehaviour
{
    Vector3 initialPos = new Vector3(2.75f, 0, 0);
    Vector2 movementeSpeed = new Vector2(15,15);
    Vector3 deltaPos = new Vector3();
    Color initialColor;
    sphereGeneratorAula globalScript;

    const float MAX_LIM_X = 8.13f, MIN_LIM_X = 2.75f, MIN_LIM_Y = -4.25f, MAX_LIM_Y = 4.25f;
    private void Start()
    {
        gameObject.transform.Translate(initialPos);
        initialColor = randomColor();
        gameObject.GetComponent<Renderer>().material.color = randomColor();
        globalScript = GameObject.Find("GlobalScriptText").GetComponent<sphereGeneratorAula>();

    }

    void Update()
    {
        deltaPos.x = Input.GetAxis("Horizontal") * movementeSpeed.x;
        deltaPos.y = Input.GetAxis("Vertical") * movementeSpeed.y;

        deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(deltaPos);
        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, MIN_LIM_X, MAX_LIM_X),
            Mathf.Clamp(gameObject.transform.position.y, MIN_LIM_Y, MAX_LIM_Y),
            gameObject.transform.position.z
        );
    }
    private void OnTriggerEnter(Collider other)
    {

        switch (other.tag)
        {
            case "Enemy":
                if (other.GetComponent<Renderer>().material.color == gameObject.GetComponent<Renderer>().material.color)
                {
                    globalScript.updateScore();
                }
                else
                {
                    globalScript.updateLife(-1);

                }
                break;
            case "Life":    
                globalScript.updateLife(1);
                break;

            case "SpeedCube":
                globalScript.speedUp();
                break;

            default:
                gameObject.GetComponent<Renderer>().material.color = other.GetComponent<Renderer>().material.color;
                break;
        }
        

        Destroy(other.gameObject);

    }

    Color randomColor()
    {
        switch (Random.Range(0, 3))
        {
            case 0:
                return Color.green;
            case 1:
                return Color.red;
            default:
                return Color.yellow;
        }
    }
}
