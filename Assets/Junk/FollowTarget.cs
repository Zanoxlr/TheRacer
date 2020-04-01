using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public GameObject target;
    public GameObject originalPosition;
    public GameObject shurikenBody;
    public float moveSpeed = 10f;
    public float rotationSpeed = 5f;
    bool goToTarget = false;

    // Update is called once per frame
    void Update()
    {
        //get values 
        float cubeColor = GetComponent<AllScriptsForCar>().cubeColor;
        float whCubes = GetComponent<AllScriptsForCar>().whCubes;

        if (Input.GetKey(KeyCode.H) && cubeColor == 3 && whCubes == 0)
        {
            goToTarget = true;
            shurikenBody.SetActive(true);
        }

        if (goToTarget == true)
        {
            
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.transform.position - transform.position), rotationSpeed * Time.deltaTime);
            transform.position += transform.forward * Time.deltaTime * moveSpeed;
        }
        if (goToTarget == false)
        {
            shurikenBody.SetActive(true);
        }
    }
}
