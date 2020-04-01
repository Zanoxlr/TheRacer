using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSystem : MonoBehaviour
{
    public GameObject car1;
    public float car1pos = 1;
    float lap1;
    float cp1;
    public GameObject car2;
    public float car2pos = 2;
    float lap2;
    float cp2;
    public GameObject car3;
    public float car3pos = 3;
    float lap3;
    float cp3;
    public GameObject car4;
    public float car4pos = 4;
    float lap4;
    float cp4;
    public GameObject car5;
    public float car5pos = 5;
    float lap5;
    float cp5;
    public GameObject car6;
    public float car6pos = 6;
    float lap6;
    float cp6;
    public float[] positionOfCars;
    public float[] CarsPositionX;
    public float[] CarsPositionY;
    public float[] CheckpointsX;
    public float[] CheckpointsY;

    void Update()
    {/*
        //Getting checkpoints x and y position
        CheckpointsX = new float[]
        {
        GetComponent<LapCounter>().cp1.transform.position.x,
        GetComponent<LapCounter>().cp2.transform.position.x,
        GetComponent<LapCounter>().cp3.transform.position.x,
        GetComponent<LapCounter>().cp4.transform.position.x,
        GetComponent<LapCounter>().cp5.transform.position.x,
        GetComponent<LapCounter>().cp6.transform.position.x,
        GetComponent<LapCounter>().cp7.transform.position.x,
        GetComponent<LapCounter>().cp8.transform.position.x
        };
        CheckpointsY = new float[]
        {
        GetComponent<LapCounter>().cp1.transform.position.y,
        GetComponent<LapCounter>().cp2.transform.position.y,
        GetComponent<LapCounter>().cp3.transform.position.y,
        GetComponent<LapCounter>().cp4.transform.position.y,
        GetComponent<LapCounter>().cp5.transform.position.y,
        GetComponent<LapCounter>().cp6.transform.position.y,
        GetComponent<LapCounter>().cp7.transform.position.y,
        GetComponent<LapCounter>().cp8.transform.position.y
        };
        //Making array for cars
        GameObject[] positionOfCars = new GameObject[] { car1, car2, car3, car4, car5, car6 };

        //Getting lap values
        lap1 = car1.GetComponent<LapCounter>().lap;
        lap2 = car2.GetComponent<LapCounter>().lap;
        lap3 = car3.GetComponent<LapCounter>().lap;
        lap4 = car4.GetComponent<LapCounter>().lap;
        lap5 = car5.GetComponent<LapCounter>().lap;
        lap6 = car6.GetComponent<LapCounter>().lap;
        //Getting checkpoint values
        cp1 = car1.GetComponent<LapCounter>().checkpointCounter;
        cp2 = car2.GetComponent<LapCounter>().checkpointCounter;
        cp3 = car3.GetComponent<LapCounter>().checkpointCounter;
        cp4 = car4.GetComponent<LapCounter>().checkpointCounter;
        cp5 = car5.GetComponent<LapCounter>().checkpointCounter;
        cp6 = car6.GetComponent<LapCounter>().checkpointCounter;
        //Storing values in array 
        float[][] car = new float[][]
        {
            new float[] { lap1, cp1, car1pos },
            new float[] { lap2, cp2, car2pos },
            new float[] { lap3, cp3, car3pos },
            new float[] { lap4, cp4, car4pos },
            new float[] { lap5, cp5, car5pos },
            new float[] { lap6, cp6, car6pos },
        };
        float[] CarsPositionX = new float[]
        {
            car1.transform.position.x,
            car2.transform.position.x,
            car3.transform.position.x,
            car4.transform.position.x,
            car5.transform.position.x,
            car6.transform.position.x
        };
        float[] CarsPositionY = new float[]
        {
            car1.transform.position.y,
            car2.transform.position.y,
            car3.transform.position.y,
            car4.transform.position.y,
            car5.transform.position.y,
            car6.transform.position.y
        };

        //Checking if you are on the same lap and checkpoint
        for (int num1 = 0; num1 <= 5; num1++)
        {
            for (int num2 = 0; num2 <= 5; num2++)
            {
                //if lap and checkpoint is the same
                if (car[num1][0] == car[num2][0] && car[num1][1] == car[num2][1])
                {
                    //Seting values
                    int checkpoint = (int)car[num1][2];
                    if (checkpoint < 7)
                    {
                        checkpoint += 1;
                    }
                    else
                    {
                        checkpoint = 0;
                    }
                    //Calculating differences between two objects
                    float change1 = (CarsPositionX[num1] + CarsPositionY[num1]) - (CheckpointsX[checkpoint] + CheckpointsY[checkpoint]);
                    float change2 = (CarsPositionX[num2] + CarsPositionY[num2]) - (CheckpointsX[checkpoint] + CheckpointsY[checkpoint]);
                    //Checking who has the lowest diference of the two GameObjects
                    if (change1 < change2 && car[num1][2] > car[num2][2])
                    {
                        int swap = (int)car[num1][2];
                        car[num1][2] = car[num2][2];
                        car[num2][2] = swap;
                        positionOfCars[num1].GetComponent<LapCounter>().carPos = car[num1][2];
                        positionOfCars[num2].GetComponent<LapCounter>().carPos = swap;
                    }
                    if (change1 > change2 && car[num1][2] < car[num2][2])
                    {
                        int swap = (int)car[num1][2];
                        car[num1][2] = car[num2][2];
                        car[num2][2] = swap;
                        positionOfCars[num1].GetComponent<LapCounter>().carPos = car[num1][2];
                        positionOfCars[num2].GetComponent<LapCounter>().carPos = swap;
                    }
                }
            }
        }*/
    }
}