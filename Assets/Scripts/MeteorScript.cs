using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScript : MonoBehaviour
{
    Collider m_Collider;
    public bool disappear = true;
    void Start()
    {
        m_Collider = GetComponent<Collider>();
    }
    void Update()
    {
        if(disappear == false)
        {
            gameObject.transform.position = new Vector3(transform.position.x, 0 , transform.position.z);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(ColliderDisable());
        }
    }
    IEnumerator ColliderDisable()
    {
        m_Collider.enabled = !m_Collider.enabled;
        disappear = false;
        yield return new WaitForSeconds(5f);
        m_Collider.enabled = !m_Collider.enabled;
        disappear = true;
        gameObject.SetActive(false);
    }
}
