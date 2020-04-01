using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotatingCubes : MonoBehaviour
{
    public GameObject WhiteCube;
    public GameObject GreenCube;
    public GameObject RedCube;
    public GameObject BlueCube;
    public GameObject YellowCube;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "white")
        {
            StartCoroutine(WhiteCubes());
        }

        if (other.gameObject.tag == "green")
        {
            StartCoroutine(GreenCubes());
        }

        if (other.gameObject.tag == "blue")
        {
            StartCoroutine(BlueCubes());
        }

        if (other.gameObject.tag == "red")
        {
            StartCoroutine(RedCubes());
        }

        if (other.gameObject.tag == "yellow")
        {
            StartCoroutine(YellowCubes());
        }
    }
    //Picking up cubes
    IEnumerator WhiteCubes()
    {
        WhiteCube.SetActive(false);
        yield return new WaitForSeconds(5.0f);
        WhiteCube.SetActive(true);
    }
    IEnumerator GreenCubes()
    {
        GreenCube.SetActive(false);
        yield return new WaitForSeconds(5.0f);
        GreenCube.SetActive(true);
    }
    IEnumerator BlueCubes()
    {
        BlueCube.SetActive(false);
        yield return new WaitForSeconds(5.0f);
        BlueCube.SetActive(true);
    }
    IEnumerator RedCubes()
    {
        RedCube.SetActive(false);
        yield return new WaitForSeconds(5.0f);
        RedCube.SetActive(true);
    }
    IEnumerator YellowCubes()
    {
        YellowCube.SetActive(false);
        yield return new WaitForSeconds(5.0f);
        YellowCube.SetActive(true);
    }
}
