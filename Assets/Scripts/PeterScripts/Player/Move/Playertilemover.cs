using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playertilemover : MonoBehaviour
{
    public bool input;
    // Start is called before the first frame update
    void Start()
    {
        input = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (input == true)
        {
            if (Input.GetKeyDown("w"))
            {
                input = false;
                StartCoroutine("Forwardmove");

            }
            if (Input.GetKeyDown("s"))
            {
                input = false;

                StartCoroutine("Backmove");
            }
            if (Input.GetKeyDown("a"))
            {
                input = false;

                StartCoroutine("Leftmove");
            }
            if (Input.GetKeyDown("d"))
            {
                input = false;

                StartCoroutine("Rightmove");
            }
        }


    }
    public IEnumerator Forwardmove()
    {

        Vector3 startposs = transform.position;
        Vector3 endposs = transform.position + new Vector3(0, 0, 2);
        while (transform.position.z != endposs.z)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (endposs.z - transform.position.z < 0.05)
            {
                transform.position = endposs;
            }
        }
        input = true;


    }
    public IEnumerator Backmove()
    {

        Vector3 startposs = transform.position;
        Vector3 endposs = transform.position - new Vector3(0, 0, 2);
        while (transform.position.z != endposs.z)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (transform.position.z - endposs.z < 0.05)
            {
                transform.position = endposs;
            }
        }
        input = true;

    }
    public IEnumerator Leftmove()
    {

        Vector3 startposs = transform.position;
        Vector3 endposs = transform.position - new Vector3(2, 0,0);
        while (transform.position.x != endposs.x)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (transform.position.x - endposs.x < 0.05)
            {
                transform.position = endposs;
            }
        }
        input = true;


    }
    public IEnumerator Rightmove()
    {

        Vector3 startposs = transform.position;
        Vector3 endposs = transform.position + new Vector3(2, 0, 0);
        while (transform.position.x != endposs.x)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (endposs.x - transform.position.x < 0.05)
            {
                transform.position = endposs;
            }
        }
        input = true;

    }

}