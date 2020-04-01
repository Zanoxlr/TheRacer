using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllScriptsForCar : MonoBehaviour
{
    public Transform camPivot;
    float heading = 0;
    public Transform cam;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject rocket1;
    public GameObject rocket2;
    public GameObject thrust;
    public float rotation = 90.0f;
    public float accMax = 5.0f;
    public float accMaxN = -5.0f;
    public float acc = 0.0f;
    public float driftRotation = 180.0f;
    public float accMulty = 0.05f;
    public Transform wheel1;
    public Transform wheel2;
    public Transform wheel3;
    public Transform wheel4;
    public GameObject bodyOfCar;
    public bool isDamagable;
    public float cubeColor = 0f;
    public float whCubes = 0f;
    public GameObject def0;
    public GameObject def1;
    public GameObject def2;
    public GameObject def3;
    public GameObject oil;
    public GameObject shuriken;
    public GameObject shurikenQ;
    public GameObject tnt;
    public GameObject meteor;
    public GameObject shovel;
    public GameObject toilet;
    public GameObject fan;
    public GameObject area;
    bool shurikenToTarget = false;
    public bool meteorToTarget = false;
    bool toiletToTarget = false;
    bool shovelToTarget = false;
    public GameObject target;
    float moveSpeed = 10f;
    float rotationSpeed = 5f;
    bool rotationBool = false;
    bool goUp = false;
    public bool canMove = true;
    float goUpInput = 0;

    Vector2 input;
    private void Start()
    {
        cam2.SetActive(false);
        cam1.SetActive(true);
        thrust.SetActive(false);
        rocket1.SetActive(false);
        rocket2.SetActive(false);
        def0.SetActive(false);
        def1.SetActive(false);
        def2.SetActive(false);
        def3.SetActive(false);
    }
    void Update()
    {
        //POWERUPS ON CAR
        //greencube
        if (Input.GetKey(KeyCode.H) && cubeColor == 1 && whCubes == 0)
        {
            StartCoroutine(MethodBoost0());
        }
        //green cube and 1 white cube
        if (Input.GetKey(KeyCode.H) && cubeColor == 1 && whCubes == 1)
        {
            StartCoroutine(MethodBoost1());
        }
        //green cube and 2 white cubes
        if (Input.GetKey(KeyCode.H) && cubeColor == 1 && whCubes == 2)
        {
            StartCoroutine(MethodBoost2());
        }
        //green cube and 3 white cubes
        if (Input.GetKey(KeyCode.H) && cubeColor == 1 && whCubes == 3)
        {
            StartCoroutine(MethodBoost3());
        }
        //Sheild rotate
        def0.transform.Rotate(0f, rotation * Time.deltaTime, 0f);
        def1.transform.Rotate(0f, rotation * Time.deltaTime, 0f);
        def2.transform.Rotate(0f, rotation * Time.deltaTime, 0f);
        def3.transform.Rotate(0f, rotation * Time.deltaTime, 0f);
        //blue cube
        if (Input.GetKey(KeyCode.H) && cubeColor == 2 && whCubes == 0)
        {
            StartCoroutine(MethodDefence0());
        }
        //blue cube with 1 white cube
        if (Input.GetKey(KeyCode.H) && cubeColor == 2 && whCubes == 1)
        {
            StartCoroutine(MethodDefence1());
        }
        //blue cube with 2 white cubes
        if (Input.GetKey(KeyCode.H) && cubeColor == 2 && whCubes == 2)
        {
            StartCoroutine(MethodDefence2());
        }
        //blue cube with 3 white cubes
        if (Input.GetKey(KeyCode.H) && cubeColor == 2 && whCubes == 3)
        {
            StartCoroutine(MethodDefenece3());
        }
        //yellow cube
        if (Input.GetKey(KeyCode.H) && cubeColor == 4 && whCubes == 0)
        {
            StartCoroutine(MethodCurse0());
        }
        //yellow cube and one white cube
        if (Input.GetKey(KeyCode.H) && cubeColor == 4 && whCubes == 1)
        {
            StartCoroutine(MethodCurse1());
        }
        //yellow cube and two white cubes
        if (Input.GetKey(KeyCode.H) && cubeColor == 4 && whCubes == 2)
        {
            StartCoroutine(MethodCurse2());
        }
        //yellow cube and three white cubes
        if (Input.GetKey(KeyCode.H) && cubeColor == 4 && whCubes == 3)
        {
            StartCoroutine(MethodCurse3());
        }
        //red cube
        if (Input.GetKey(KeyCode.H) && cubeColor == 3 && whCubes == 0)
        {
            StartCoroutine(MethodHurt0());
        }
        //red cube and one whitecube
        if (Input.GetKey(KeyCode.H) && cubeColor == 3 && whCubes == 1)
        {
            StartCoroutine(MethodHurt1());
        }
        //red cube and two whitecubes
        if (Input.GetKey(KeyCode.H) && cubeColor == 3 && whCubes == 2)
        {
            StartCoroutine(MethodHurt2());
        }
        //red cube and three whitecubes
        if (Input.GetKey(KeyCode.H) && cubeColor == 3 && whCubes == 3)
        {
            MethodHurt3();
        }
        //rotation if you get hit
        if (rotationBool == true)
        {
            bodyOfCar.transform.Rotate(0f, 180 * Time.deltaTime, 0f);
        }
        //go up if you get hit
        if (goUp == true)
        {
            goUpInput += 5 * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, goUpInput, transform.position.z);
        }
        //toilet going to target
        if (toiletToTarget == true)
        {
            toilet.transform.rotation = Quaternion.Slerp(toilet.transform.rotation, Quaternion.LookRotation(target.transform.position - toilet.transform.position), rotationSpeed * Time.deltaTime);
            toilet.transform.position += toilet.transform.forward * Time.deltaTime * moveSpeed;
        }
        //shovel going to target
        if (shovelToTarget == true)
        {
            shovel.transform.rotation = Quaternion.Slerp(shovel.transform.rotation, Quaternion.LookRotation(target.transform.position - shovel.transform.position), rotationSpeed * Time.deltaTime);
            shovel.transform.position += shovel.transform.forward * Time.deltaTime * moveSpeed;
        }
        //shuriken going to target
        if (shurikenToTarget == true)
        {
            shuriken.transform.Rotate(rotation * Time.deltaTime * 3, rotation * Time.deltaTime * 3, 0f);
            shurikenQ.transform.rotation = Quaternion.Slerp(shurikenQ.transform.rotation, Quaternion.LookRotation(target.transform.position - shurikenQ.transform.position), rotationSpeed * Time.deltaTime);
            shurikenQ.transform.position += shurikenQ.transform.forward * Time.deltaTime * moveSpeed;
        }
        //meteor going to target
        if (meteorToTarget == true)
        {
            meteor.transform.rotation = Quaternion.Slerp(meteor.transform.rotation, Quaternion.LookRotation(target.transform.position - meteor.transform.position), rotationSpeed * Time.deltaTime);
            meteor.transform.position += meteor.transform.forward * Time.deltaTime * moveSpeed * 2f;
        }
        //fan area
        //reset position if car is too low or too high
        if (transform.position.y <= -20f || transform.position.y >= 50f)
        {
            transform.position = new Vector3(270f, 1f, 275f);
            acc = 0f;
        }
        //Controls
        //forwards
        if (canMove == true)
        {
            if (acc <= accMax && Input.GetAxis("Vertical") == 1f)
            {
                acc += Input.GetAxis("Vertical") * Time.deltaTime;
            }
            if (acc > 0 && Input.GetAxis("Vertical") == 0)
            {
                if ((acc - (Time.deltaTime * 2)) < 0)
                {
                    acc = 0;
                }
                else
                {
                    acc -= Time.deltaTime * 2;
                }
            }
            //backwards
            if (acc >= accMaxN && Input.GetAxis("Vertical") == -1f)
            {
                acc += Input.GetAxis("Vertical") * Time.deltaTime;
            }
            if (acc < 0 && Input.GetAxis("Vertical") == 0)
            {
                if ((acc - (Time.deltaTime * 2)) < 0)
                {
                    acc = 0;
                }
            }
        }
        else
        {
            acc -= Time.deltaTime * 2;
        }
        //decelerating if no input
        if (acc < 0 && Input.GetAxis("Vertical") == 0)
        {
            if ((acc - (Time.deltaTime * 2)) < 0)
            {
                acc = 0;
            }
            else
            {
                acc -= Time.deltaTime * 2;
            }
        }
        //turn faster if drift key in on
        if (Input.GetAxis("Drift") == 1.0f)
        {
            rotation = driftRotation;
        }
        else
        {
            rotation = 90.0f;
        }
        //wheel rotation relative to acc
        wheel1.Rotate(0f, acc, 0f);
        wheel2.Rotate(0f, -acc, 0f);
        wheel3.Rotate(0f, acc, 0f);
        wheel4.Rotate(0f, -acc, 0f);
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
        if (canMove == true)
        {
            heading += Input.GetAxis("Horizontal") * Time.deltaTime * rotation;
        }
        camPivot.rotation = Quaternion.Euler(0.0f, heading, 0.0f);
        //moving car
        input = new Vector2(0.0f, acc * accMulty);
        input = Vector2.ClampMagnitude(input, accMax * accMulty);
        //camera pointing forwards
        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;
        camF = camF.normalized;
        camR = camR.normalized;
        transform.position += (camF * input.y + camR * input.x) * 5.0f;
    }
    void OnCollisionEnter(Collision other)
    {
        //adding cubes
        if (other.gameObject.tag == "white")
        {
            if (whCubes <= 2)
            {
                whCubes += 1;
            }
        }
        if (other.gameObject.tag == "green")
        {
            cubeColor = 1;
        }
        if (other.gameObject.tag == "blue")
        {
            cubeColor = 2;
        }
        if (other.gameObject.tag == "red")
        {
            cubeColor = 3;
        }
        if (other.gameObject.tag == "yellow")
        {
            cubeColor = 4;
        }
        //getting hit by other objects
        if (other.gameObject.tag == "meteor")
        {
            MethodGoUpRotate();
            acc = 0;
            meteorToTarget = false;
        }
        if (isDamagable == true)
        {
            if (other.gameObject.tag == "shuriken")
            {
                MethodGoUpRotate();
                shurikenToTarget = false;
            }
            if (other.gameObject.tag == "toilet")
            {
                StartCoroutine(MethodRotate());
                toiletToTarget = false;
            }
            if (other.gameObject.tag == "shovel")
            {
                StartCoroutine(MethodGoUp());
                shovelToTarget = false;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        //getting hit by other objects
        if (isDamagable == true)
        {
            if (other.gameObject.tag == "oil")
            {
                StartCoroutine(MethodRotate());
            }
            if (other.gameObject.tag == "tnt")
            {
                StartCoroutine(MethodGoUp());
            }
            if (other.gameObject.tag == "fan")
            {
                StartCoroutine(MethodAccDiv2());
            }
            if (other.gameObject.tag == "area")
            {
                StartCoroutine(MethodDisableMovement());
            }
        }
    }
    //POWERUPS ON CAR
    //one green cube
    IEnumerator MethodBoost0()
    {
        cubeColor = 0f;
        accMax = 8.0f;
        acc = 7.5f;
        yield return new WaitForSeconds(5f);
        accMax = 5.0f;
        acc = 4.9f;
    }
    //one green cube and 1 white cube
    IEnumerator MethodBoost1()
    {
        cubeColor = 0f;
        whCubes = 0f;
        accMax = 10.0f;
        acc = 9.5f;
        thrust.SetActive(true);
        yield return new WaitForSeconds(5f);
        accMax = 5.0f;
        acc = 4.9f;
        thrust.SetActive(false);
    }
    //one green cube and 2 white cube
    IEnumerator MethodBoost2()
    {
        cubeColor = 0f;
        whCubes = 0f;
        accMax = 10.0f;
        acc = 9.5f;
        float xasis = transform.position.x;
        float zasis = transform.position.z;
        transform.position = new Vector3(xasis, 2f, zasis);
        camPivot.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        rocket1.SetActive(true);
        rocket2.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        camPivot.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        accMax = 5.0f;
        acc = 4.9f;
        rocket1.SetActive(false);
        rocket2.SetActive(false);
    }
    //one green cube and 3 white cube
    IEnumerator MethodBoost3()
    {
        cubeColor = 0f;
        whCubes = 0f;
        accMax = 14.0f;
        acc = 13.5f;
        driftRotation = 240f;
        yield return new WaitForSeconds(5.0f);
        driftRotation = 180f;
        accMax = 5.0f;
        acc = 4.9f;
    }
    //one blue cube
    IEnumerator MethodDefence0()
    {
        cubeColor = 0f;
        def0.SetActive(true);
        isDamagable = false;
        yield return new WaitForSeconds(5.0f);
        isDamagable = true;
        def0.SetActive(false);
    }
    //one blue cube and 1 white cube
    IEnumerator MethodDefence1()
    {
        cubeColor = 0f;
        whCubes = 0f;
        def1.SetActive(true);
        isDamagable = false;
        yield return new WaitForSeconds(8.0f);
        isDamagable = true;
        def1.SetActive(false);
    }
    //one blue cube and 2 white cube
    IEnumerator MethodDefence2()
    {
        cubeColor = 0f;
        whCubes = 0f;
        def2.SetActive(true);
        isDamagable = false;
        yield return new WaitForSeconds(13.0f);
        isDamagable = true;
        def2.SetActive(false);
    }
    //one blue cube and 3 white cube
    IEnumerator MethodDefenece3()
    {
        cubeColor = 0f;
        whCubes = 0f;
        def3.SetActive(true);
        isDamagable = false;
        yield return new WaitForSeconds(18.0f);
        isDamagable = true;
        def0.SetActive(false);
    }
    //yellow cube
    IEnumerator MethodCurse0()
    {
        cubeColor = 0;
        oil.transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
        yield return new WaitForSeconds(0.4f);
        oil.SetActive(true);
        yield return new WaitForSeconds(6.6f);
        oil.SetActive(false);
    }
    IEnumerator MethodCurse1()
    {
        cubeColor = 0;
        whCubes = 0;
        tnt.transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        yield return new WaitForSeconds(0.4f);
        tnt.SetActive(true);
        yield return new WaitForSeconds(6.6f);
        tnt.SetActive(false);
    }
    IEnumerator MethodCurse2()
    {
        cubeColor = 0;
        whCubes = 0;
        fan.transform.position = new Vector3(transform.position.x, -5.1f, transform.position.z);
        fan.transform.Rotate(transform.rotation.x, transform.rotation.y + 90f, transform.rotation.z);
        yield return new WaitForSeconds(0.4f);
        fan.SetActive(true);
        yield return new WaitForSeconds(10f);
        fan.SetActive(false);
    }
    IEnumerator MethodCurse3()
    {
        cubeColor = 0;
        whCubes = 0;
        area.transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        yield return new WaitForSeconds(2f);
        area.SetActive(true);
        yield return new WaitForSeconds(8f);
        area.SetActive(false);
    }
    //red cube
    IEnumerator MethodHurt0()
    {
        cubeColor = 0;
        toilet.transform.position = transform.position;
        toiletToTarget = true;
        yield return new WaitForSeconds(0.2f);
        toilet.SetActive(true);
        yield return new WaitForSeconds(5f);
        toiletToTarget = false;
        toilet.SetActive(false);
    }
    IEnumerator MethodHurt1()
    {
        cubeColor = 0;
        whCubes = 0;
        shovel.transform.position = transform.position;
        shovelToTarget = true;
        yield return new WaitForSeconds(0.2f);
        shovel.SetActive(true);
        yield return new WaitForSeconds(5f);
        shovelToTarget = false;
        shovel.SetActive(false);
    }
    IEnumerator MethodHurt2()
    {
        cubeColor = 0;
        whCubes = 0;
        shurikenQ.transform.position = transform.position;
        shurikenToTarget = true;
        yield return new WaitForSeconds(0.2f);
        shuriken.SetActive(true);
        yield return new WaitForSeconds(5f);
        shurikenToTarget = false;
        shuriken.SetActive(false);
    }
    void MethodHurt3()
    {
        cubeColor = 0;
        whCubes = 0;
        meteor.SetActive(true);
        meteor.transform.position = new Vector3(0f, 150f, 0f);
        meteorToTarget = true;
    }
    //Rotate and go up
    void MethodGoUpRotate()
    {
        if (isDamagable == true)
        {
            StartCoroutine(MethodRotate());
            StartCoroutine(MethodGoUp());
        }
    }
    //Rotating method
    IEnumerator MethodRotate()
    {
        canMove = false;
        rotationBool = true;
        yield return new WaitForSeconds(2.0f);
        rotationBool = false;
        canMove = true;
    }
    IEnumerator MethodGoUp()
    {
        goUp = true;
        yield return new WaitForSeconds(2.0f);
        goUpInput = 0;
        goUp = false;
    }
    IEnumerator MethodDisableMovement()
    {
        canMove = false;
        yield return new WaitForSeconds(5.0f);
        canMove = true;
    }
    IEnumerator MethodAccDiv2()
    {
        acc = 1f;
        accMax = 1.1f;
        yield return new WaitForSeconds(2.0f);
        accMax = 5f;
    }
}