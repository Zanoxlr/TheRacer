using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointArray : MonoBehaviour
{
    public GameObject[] children;
    void Start()
    {
        children = GetComponentsInChildren<GameObject>();
    }
}
