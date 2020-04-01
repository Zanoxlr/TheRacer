using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpSystem : MonoBehaviour
{
    public GameObject whiteCube;
    public GameObject greenCube;
    public GameObject blueCube;
    public GameObject redCube;
    public GameObject yellowCube;
    public float cubeColor = 0f;
    public float whCubes = 0f;
    bool isOnW = false;
    bool isOnG = false;
    bool isOnR = false;
    bool isOnB = false;
    bool isOnY = false;
    public float delayW = 0f;
    public float delayG = 0f;
    public float delayB = 0f;
    public float delayR = 0f;
    public float delayY = 0f;

    void Update()
    {
        if (isOnW == true)
        {
            if (delayW >= 5f)
            {
                whiteCube.SetActive(true);
                delayW = 0f;
                isOnW = false;
            }
            else
            {
                delayW += Time.deltaTime;
            }
        }
        if (isOnG == true)
        {
            if (delayG >= 5f)
            {
                whiteCube.SetActive(true);
                delayG = 0f;
                isOnG = false;
            }
            else
            {
                delayG += Time.deltaTime;
            }
        }
        if (isOnB == true)
        {
            if (delayB >= 5f)
            {
                blueCube.SetActive(true);
                delayB = 0f;
                isOnB = false;
            }
            else
            {
                delayB += Time.deltaTime;
            }
        }
        if (isOnR == true)
        {
            redCube.SetActive(false);
            if (delayR >= 5f)
            {
                redCube.SetActive(true);
                delayR = 0f;
                isOnR = false;
            }
            else
            {
                delayR += Time.deltaTime;
            }
        }
        if (isOnY == true)
        {
            if (delayY >= 5f)
            {
                yellowCube.SetActive(true);
                delayY = 0f;
                isOnY = false;
            }
            else
            {
                delayY += Time.deltaTime;
            }
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "white")
        {
            if (whCubes <= 2f)
            {
                isOnW = true;
                whCubes += 1;
                whiteCube.SetActive(false);
            }
        }
        
        if (other.gameObject.tag == "green")
        {
            isOnG = true;
            cubeColor = 1;
            greenCube.SetActive(false);
        }
        
        if (other.gameObject.tag == "blue")
        {
                isOnB = true;
            cubeColor = 2;
            blueCube.SetActive(false);
        }
        
        if (other.gameObject.tag == "red")
        {
            isOnR = true;
            cubeColor = 3;
            redCube.SetActive(false);
        }
        
        if (other.gameObject.tag == "yellow")
        {
            isOnY = true;
            cubeColor = 4;
            yellowCube.SetActive(false);
        }
        
    }
}
