using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSytem2 : MonoBehaviour
{
    /*Cars
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;
    public GameObject car5;
    public GameObject car6;
    private GameObject[] carsGO;
    //car position
    float car1pos = 1;
    float car2pos = 2;
    float car3pos = 3;
    float car4pos = 4;
    float car5pos = 5;
    float car6pos = 6
    //Checkpoints
    public Transform checkpoint1;
    public Transform checkpoint2;
    public Transform checkpoint3;
    public Transform checkpoint4;
    public Transform checkpoint5;
    public Transform checkpoint6;
    public Transform checkpoint7;
    public Transform checkpoint8;
    private float[] checkpointX;
    private float[] checkpointY;
    private float[][] carValues;
    private Transform[] checkpoints;
    void Start()
    {
        carsGO = new GameObject[] { car1, car2, car3, car4, car5, car6 };
        checkpointX = new float[]
        {
            checkpoint1.position.x,
            checkpoint2.position.x,
            checkpoint3.position.x,
            checkpoint4.position.x,
            checkpoint5.position.x,
            checkpoint6.position.x,
            checkpoint7.position.x,
            checkpoint8.position.x
        };
        checkpointY = new float[]
        {
            checkpoint1.position.y,
            checkpoint2.position.y,
            checkpoint3.position.y,
            checkpoint4.position.y,
            checkpoint5.position.y,
            checkpoint6.position.y,
            checkpoint7.position.y,
            checkpoint8.position.y
        };
    }
    void Update()
    {
        carValues = new float[][]
        {
            new float[] { car1.GetComponent<LapCounter>().lap, car1.GetComponent<LapCounter>().checkpointCounter, car1pos },
            new float[] { car2.GetComponent<LapCounter>().lap, car2.GetComponent<LapCounter>().checkpointCounter, car2pos },
            new float[] { car3.GetComponent<LapCounter>().lap, car3.GetComponent<LapCounter>().checkpointCounter, car3pos },
            new float[] { car4.GetComponent<LapCounter>().lap, car4.GetComponent<LapCounter>().checkpointCounter, car4pos },
            new float[] { car5.GetComponent<LapCounter>().lap, car5.GetComponent<LapCounter>().checkpointCounter, car5pos },
            new float[] { car6.GetComponent<LapCounter>().lap, car6.GetComponent<LapCounter>().checkpointCounter, car6pos },
        };
        //Seting values
        int checkpoint = (int)carValues[0][2];
        if (checkpoint < 7)
        {
            checkpoint += 1;
        }
        else
        {
            checkpoint = 0;
        }
        //Calculating differences between two objects
        float a1 = Mathf.Pow(carsGO[0].transform.position.x - checkpointX[checkpoint], 2);
        float a2 = Mathf.Pow(carsGO[1].transform.position.x - checkpointX[checkpoint], 2);
        float b1 = Mathf.Pow(carsGO[0].transform.position.y - checkpointY[checkpoint], 2);
        float b2 = Mathf.Pow(carsGO[1].transform.position.y - checkpointY[checkpoint], 2);
        float change1 = Mathf.Sqrt(a1 + b1);
        float change2 = Mathf.Sqrt(a2 + b2);
        if (change1 < change2)
        {
            carsGO[0].GetComponent<LapCounter>().carPos = 2;
            carsGO[1].GetComponent<LapCounter>().carPos = 1;
        }
        Checking if you are on the same lap and checkpoint
        for (int num1 = 0; num1 <= 1; num1++)
        {
            for (int num2 = 0; num2 <= 1; num2++)
            {
                //if lap and checkpoint is the same
                if (carValues[num1][0] == carValues[num2][0] && carValues[num1][1] == carValues[num2][1])
                {
                    //Seting values
                    int checkpoint = (int)carValues[num1][2];
                    if (checkpoint < 7)
                    {
                        checkpoint += 1;
                    }
                    else
                    {
                        checkpoint = 0;
                    }
                    //Calculating differences between two objects
                    float a1 = Mathf.Pow(carsGO[num1].transform.position.x - checkpointX[checkpoint], 2);
                    float a2 = Mathf.Pow(carsGO[num2].transform.position.x - checkpointX[checkpoint], 2);
                    float b1 = Mathf.Pow(carsGO[num1].transform.position.y - checkpointY[checkpoint], 2);
                    float b2 = Mathf.Pow(carsGO[num1].transform.position.y - checkpointY[checkpoint], 2);
                    float change1 = Mathf.Sqrt(a1 + b1);
                    float change2 = Mathf.Sqrt(a2 + b2);
                    if(change1 < change2)
                    {
                        carsGO[num1].GetComponent<LapCounter>().carPos = 2;
                        carsGO[num2].GetComponent<LapCounter>().carPos = 1;
                    }
                    //Checking who has the lowest diference of the two GameObjects
                    /*if (change1 < change2 && carValues[num1][2] > carValues[num2][2])
                    {
                        float numb1 = carValues[num1][2];
                        float numb2 = carValues[num2][2];
                        carsGO[num1].GetComponent<LapCounter>().carPos = numb2;
                        carsGO[num2].GetComponent<LapCounter>().carPos = numb1;
                    }
                    if(change1 < change2)
                    {
                        carsGO[num1].GetComponent<LapCounter>().carPos = 1;
                        carsGO[num2].GetComponent<LapCounter>().carPos = 2;
                    }
                }
            }*/
}