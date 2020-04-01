using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -20f || transform.position.y >= 50f)
        {
            transform.position = new Vector3(0f, 1f, 0f);
        }
    }
}
