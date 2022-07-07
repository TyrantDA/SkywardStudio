using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drowning : MonoBehaviour
{
    PlayerHealth ph;
    Transform col;
    public Transform playerTop;
    void Start()
    {
        ph = GetComponent<PlayerHealth>();
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("trigger " + other.gameObject.transform.name + " " + other.gameObject.transform.tag + " " + other.gameObject.transform);
        if (other.gameObject.transform.CompareTag("Water"))
        {
            Debug.Log(other.transform.position.y + " : " + playerTop.position.y);
            if (other.transform.position.y >= playerTop.position.y)
            {
                ph.dealDamage(100);
            }
        }
    }

    private void Update()
    {
    }


}
