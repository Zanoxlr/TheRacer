using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DisableCubes : MonoBehaviour
{
    //rotating cubes
    public float rotatingQ = 60f;
    public Renderer rend;
    Collider m_Collider;
    void Start()
    {
        m_Collider = GetComponent<Collider>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }
    void Update()
    {
        gameObject.transform.Rotate(rotatingQ * Time.deltaTime, rotatingQ * Time.deltaTime, rotatingQ * Time.deltaTime);
    }
    //disabling when touch
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(CubesQ());
        }
    }
    IEnumerator CubesQ()
    {
        rend.enabled = false;
        m_Collider.enabled = false;
        yield return new WaitForSeconds(5f);
        rend.enabled = true;
        m_Collider.enabled = true;
    }
}
