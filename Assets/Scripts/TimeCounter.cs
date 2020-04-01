using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public float carPos;
    bool finished = false;
    public GameObject cp;
    public GameObject lapCounter;
    public GameObject maxLapCounter;
    public GameObject finishedText;
    public int checkpointCounter = 0;
    public float lap = 0;
    public float maxLap = 3;
    //Time
    public float minuteCount;
    public float secondCount;
    public float milliCount;
    public string milliDisplay;
    public GameObject minuteBox;
    public GameObject secondBox;
    public GameObject milliBox;
    public Transform[] checkpoinsInArray;
    void Update()
    {
        //counter
        if (finished == false)
        {
            milliCount += Time.deltaTime * 10;
        }
        //display counter
        milliBox.GetComponent<Text>().text = milliDisplay;
        if (milliCount < 9)
        {
            milliDisplay = milliCount.ToString("0");
        }
        else
        {
            milliDisplay = "0";
        }
        //millicount
        if (milliCount > 10)
        {
            milliCount = 0;
            secondCount += 1;
        }
        //second count
        if (secondCount <= 9)
        {
            secondBox.GetComponent<Text>().text = "0" + secondCount + ".";
        }
        else
        {
            secondBox.GetComponent<Text>().text = secondCount + ".";
        }
        if (secondCount >= 60)
        {
            secondCount = 0;
            minuteCount += 1;
        }
        //minute count
        if (minuteCount <= 9)
        {
            minuteBox.GetComponent<Text>().text = "0" + minuteCount + ":";
        }
        else
        {
            minuteBox.GetComponent<Text>().text = minuteCount + ":";
        }
    }
}