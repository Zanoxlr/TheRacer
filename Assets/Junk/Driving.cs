using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driving : MonoBehaviour
{
    public Transform camPivot;
    float heading = 0;
    public Transform cam;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject rocket1;
    public GameObject rocket2;
    public GameObject thrust;
    public Transform rocketT1;
    public Transform rocketT2;
    public Transform thrustT;
    public float rotation = 90.0f;
    public float accMax = 5.0f;
    public float accMaxN = -5.0f;
    public float acc = 0.0f;
    public float accMultiplier = 1.0f;
    public float driftRotation = 30.0f;
    public float handbreak = 1.0f;
    public Transform wh1;
    public Transform wh2;
    public Transform wh3;
    public Transform wh4;
    bool boost0 = false;
    bool boost1 = false;
    bool boost2 = false;
    bool boost3 = false;
    public float delay = 0.0f;

    Vector2 input;


    private void Start()
    {
        cam2.SetActive(false);
        cam1.SetActive(true);
        thrust.SetActive(false);
        rocket1.SetActive(false);
        rocket2.SetActive(false);
    }
    void FixedUpdate()
    {
        float whCubes = GetComponent<pickUpSystem>().whCubes;
        float cubeColor = GetComponent<pickUpSystem>().cubeColor;

        //ACCELERATION SCRIPT

        //forwards

        if (acc <= accMax && Input.GetAxis("Vertical") == 1f)
        {
            acc += Input.GetAxis("Vertical") * Time.deltaTime * accMultiplier;
        }

        if (acc > 0 && Input.GetAxis("Vertical") == 0)
        {
            if ((acc - (Time.deltaTime * accMultiplier * 2)) < 0)
            {
                acc = 0;
            }
            else
            {
                acc -= Time.deltaTime * accMultiplier * 2;
            }
        }

            //backwards
        if (acc >= accMaxN && Input.GetAxis("Vertical") == -1f)
        {
            acc += Input.GetAxis("Vertical") * Time.deltaTime * accMultiplier;
        }

        if (acc < 0 && Input.GetAxis("Vertical") == 0)
        {
            if ((acc + (Time.deltaTime * accMultiplier * 2)) > 0)
            {
                acc = 0;
            }
            else
            {
                acc += Time.deltaTime * accMultiplier * 2;
            }
        }
        //greencube
        if (Input.GetKey(KeyCode.H) && cubeColor == 1 && whCubes == 0)
        {
            boost0 = true;
            cubeColor -= 1;
        }

        if (boost0 == true)
        {
            if (delay <= 5f && acc < accMax)
            {
                accMax = 8.0f;
                delay += Time.deltaTime;
                acc = 7.5f;
            }
            else
            {
                accMax = 5.0f;
                delay = 0.0f;
                acc = 4.9f;
                boost0 = false;
            }
        }
        //green cube and 1 white cube
        if (Input.GetKey(KeyCode.H) && cubeColor == 1 && whCubes == 1)
        {
            boost1 = true;
            cubeColor -= 1;
            whCubes -= 1;
        }

        if (boost1 == true)
        {
            if (delay <= 5f && acc < accMax)
            {
                accMax = 10.0f;
                delay += Time.deltaTime;
                acc = 9.5f;
                if (delay > 0.1f && delay < 0.6f)
                {
                    thrust.SetActive(true);
                    thrustT.Rotate(180f * Time.deltaTime, 0f, 0f);
                }
                if (delay >= 4.3f && delay <= 4.8)
                {
                    thrustT.Rotate(-180f * Time.deltaTime, 0f, 0f);
                }
            }
            else
            {
                accMax = 5.0f;
                delay = 0.0f;
                acc = 4.9f;
                boost1 = false;
                thrust.SetActive(false);
            }
        }
        //green cube and 2 white cubes
        if (Input.GetKey(KeyCode.H) && cubeColor == 1 && whCubes == 2)
        {
            boost2 = true;
            cubeColor -= 1;
            whCubes -= 2;
        }

        if (boost2 == true)
        {
            if (delay <= 5f && acc < accMax)
            {
                float xasis = transform.position.x;
                float zasis = transform.position.z;
                transform.position = new Vector3(xasis, delay, zasis);
                accMax = 10.0f;
                delay += Time.deltaTime;
                acc = 9.5f;
                if (delay > 0.1f && delay < 0.6f)
                {
                    camPivot.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                    rocket1.SetActive(true);
                    rocketT1.Rotate(180f * Time.deltaTime, 0f, 0f);
                    rocket2.SetActive(true);
                    rocketT2.Rotate(180f * Time.deltaTime, 0f, 0f);
                }
                if (delay >= 4.3f && delay <= 4.8)
                {
                    rocketT1.Rotate(-180f * Time.deltaTime, 0f, 0f);
                    rocketT2.Rotate(-180f * Time.deltaTime, 0f, 0f);
                    camPivot.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
            else
            {
                accMax = 5.0f;
                delay = 0.0f;
                acc = 4.9f;
                boost2 = false;
                rocket1.SetActive(false);
                rocket2.SetActive(false);
            }
        }
        //green cube and 3 white cubes
        if (Input.GetKey(KeyCode.H) && cubeColor == 1 && whCubes == 3)
        {
            boost3 = true;
            cubeColor -= 1;
            whCubes -= 3;
        }

        if (boost3 == true)
        {
            if (delay <= 5f && acc < accMax)
            {
                accMax = 14.0f;
                delay += Time.deltaTime;
                acc = 13.5f;
            }
            else
            {
                accMax = 5.0f;
                delay = 0.0f;
                acc = 4.9f;
                boost3 = false;
            }
        }
        //drift script
        if (Input.GetAxis("Drift") == 1.0f)
        {
            rotation = driftRotation;
        }
        else
        {
            rotation = 90.0f;
        }

        //wheel rotation
        wh1.Rotate(0f, acc, 0f);
        wh2.Rotate(0f, -acc, 0f);
        wh3.Rotate(0f, acc, 0f);
        wh4.Rotate(0f, -acc, 0f);

        //camera switcher and wheel spin
        if (acc < 0)
        {
            cam2.SetActive(true);
            cam1.SetActive(false);
        }
        if (acc > 0)
        {
            cam2.SetActive(false);
            cam1.SetActive(true);
        }
        //moving camera
        heading += Input.GetAxis("Horizontal") * Time.deltaTime * rotation;
        camPivot.rotation = Quaternion.Euler(0.0f, heading, 0.0f);

        //moving object
        input = new Vector2(0.0f, acc);
        input = Vector2.ClampMagnitude(input, accMax);

        //camera pointer

        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;

        camF = camF.normalized;
        camR = camR.normalized;

        transform.position += (camF * input.y + camR * input.x) * Time.deltaTime * 5.0f;

    }

}