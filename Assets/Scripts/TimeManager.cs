using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float minuteCount;
    public float secondCount;
    public float milliCount;
    public string milliDisplay;
    public GameObject minuteBox;
    public GameObject secondBox;
    public GameObject milliBox;

    void Update()
    {
        //counter
        milliCount += Time.deltaTime * 10;
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
