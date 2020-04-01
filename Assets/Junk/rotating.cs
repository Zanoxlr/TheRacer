using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotating : MonoBehaviour
{
    public float rotatingQ = 60f;
    void Update()
    {
        gameObject.transform.Rotate(rotatingQ * Time.deltaTime, rotatingQ * Time.deltaTime, rotatingQ * Time.deltaTime);
    }
}
