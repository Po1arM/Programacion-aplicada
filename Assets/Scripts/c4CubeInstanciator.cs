using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c4CubeInstanciator : MonoBehaviour
{
    Vector3 startingPos = new Vector3(0,7);
    public GameObject redCube, greenCube, blueCube, yellowCube;
    float nextTime;
    const float MIN_TIME = 1f, MAX_TIME = 1.5f;
    const float MIN_X = -8.14f, MAX_X = 8.14f;

    void Start()
    {
        nextTime = getNextTime(); 
    }

    void Update()
    {
        if (Time.time > nextTime)
        {
            startingPos.x = Random.Range(MIN_X,MAX_X);
            Instantiate(nextCube(), startingPos, Quaternion.identity);
            nextTime = getNextTime();
        }
    }

    float getNextTime()
    {
        return Time.time * Random.Range(MIN_TIME, MAX_TIME);
    }

    GameObject nextCube()
    {
        switch (Random.Range(0, 4))
        {
            case 0:
                return greenCube;
            case 1:
                return blueCube;
            case 2:
                return redCube;
            default:
                return yellowCube;
        }
    }
}
