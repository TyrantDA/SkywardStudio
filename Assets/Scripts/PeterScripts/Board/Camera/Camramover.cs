using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camramover : MonoBehaviour
{
    public bool moved;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetAxis("Second joystick") == -1)
        {
            moved = true;
            StartCoroutine("Forwardmove");

        }
        if (Input.GetAxis("Second joystick2") == 1)
        {
            moved = true;

            StartCoroutine("Rightmove");

        }
        if (Input.GetAxis("Second joystick2") == -1)
        {
            moved = true;

            StartCoroutine("Leftmove");

        }
        if (Input.GetAxis("Second joystick") == 1)
        {
            moved = true;

            StartCoroutine("Backmove");

        }
    }
    public IEnumerator Forwardmove()
    {

        Vector3 startposs = transform.position;
        Vector3 endposs = transform.position + new Vector3(0, 0, 0.5f);
        while (transform.position.z != endposs.z)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (endposs.z - transform.position.z < 0.05)
            {
                transform.position = endposs;
            }
        }


    }
    public IEnumerator Backmove()
    {

        Vector3 startposs = transform.position;
        Vector3 endposs = transform.position - new Vector3(0, 0, 0.5f);
        while (transform.position.z != endposs.z)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (transform.position.z - endposs.z < 0.05)
            {
                transform.position = endposs;
            }
        }

    }
    public IEnumerator Leftmove()
    {

        Vector3 startposs = transform.position;
        Vector3 endposs = transform.position - new Vector3(0.5f, 0, 0);
        while (transform.position.x != endposs.x)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (transform.position.x - endposs.x < 0.05)
            {
                transform.position = endposs;
            }
        }


    }
    public IEnumerator Rightmove()
    {

        Vector3 startposs = transform.position;
        Vector3 endposs = transform.position + new Vector3(0.5f, 0, 0);
        while (transform.position.x != endposs.x)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (endposs.x - transform.position.x < 0.05)
            {
                transform.position = endposs;
            }
        }

    }
}
