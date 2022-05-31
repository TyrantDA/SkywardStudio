using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playertilemover : MonoBehaviour
{
    public bool input;
    public Tileholder Tiles;
    public GameObject currenttile;
    public Vector3 Starttile;

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
            Starttile = transform.position;

            if (Input.GetKeyDown("w"))
            {
                Vector3 endposs = transform.position + new Vector3(0, 0, 2);

                if (endposs.z == 1)
                {
                    currenttile = Tiles.array1[Mathf.RoundToInt((endposs.x-1)/2)];
                }
                if (endposs.z == 3)
                {
                    currenttile = Tiles.array2[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (endposs.z == 5)
                {
                    currenttile = Tiles.array3[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (endposs.z == 7)
                {
                    currenttile = Tiles.array4[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (endposs.z == 9)
                {
                    currenttile = Tiles.array5[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (currenttile.GetComponent<Tilechangerwalk>().ocupided == false)
                {
                    input = false;

                    StartCoroutine("Forwardmove");

                }


            }
            if (Input.GetKeyDown("s"))
            {
                Vector3 endposs = transform.position - new Vector3(0, 0, 2);

                if (endposs.z == 1)
                {
                    currenttile = Tiles.array1[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (endposs.z == 3)
                {
                    currenttile = Tiles.array2[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (endposs.z == 5)
                {
                    currenttile = Tiles.array3[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (endposs.z == 7)
                {
                    currenttile = Tiles.array4[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (endposs.z == 9)
                {
                    currenttile = Tiles.array5[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (currenttile.GetComponent<Tilechangerwalk>().ocupided == false)
                {
                    input = false;

                    StartCoroutine("Backmove");

                }
            }
            if (Input.GetKeyDown("a"))
            {
                Vector3 endposs = transform.position - new Vector3(2, 0, 0);

                if (endposs.z == 1)
                {
                    currenttile = Tiles.array1[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (endposs.z == 3)
                {
                    currenttile = Tiles.array2[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (endposs.z == 5)
                {
                    currenttile = Tiles.array3[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (endposs.z == 7)
                {
                    currenttile = Tiles.array4[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (endposs.z == 9)
                {
                    currenttile = Tiles.array5[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (currenttile.GetComponent<Tilechangerwalk>().ocupided == false)
                {
                    input = false;

                    StartCoroutine("Leftmove");

                }
            }
            if (Input.GetKeyDown("d"))
            {
                Vector3 endposs = transform.position + new Vector3(2, 0, 0);

                if (endposs.z == 1)
                {
                    currenttile = Tiles.array1[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (endposs.z == 3)
                {
                    currenttile = Tiles.array2[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (endposs.z == 5)
                {
                    currenttile = Tiles.array3[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (endposs.z == 7)
                {
                    currenttile = Tiles.array4[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (endposs.z == 9)
                {
                    currenttile = Tiles.array5[Mathf.RoundToInt((endposs.x - 1) / 2)];
                }
                if (currenttile.GetComponent<Tilechangerwalk>().ocupided == false)
                {
                    input = false;

                    StartCoroutine("Rightmove");

                }
            }
            if (Input.GetKeyDown("space"))
            {
                input = false;
                StartCoroutine("Notmove");
            }
        }



    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Chesspeice"))
        {
            StopAllCoroutines();
            StartCoroutine("Moveback");
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
    public IEnumerator Notmove()
    {
        yield return new WaitForSeconds(1);
        input = true;

    }
    public IEnumerator Moveback()
    {

        Vector3 startposs = transform.position;
        Vector3 endposs = Starttile;
        while (transform.position.z != endposs.z)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (Mathf.Abs(endposs.z - transform.position.z) < 0.05)
            {
                transform.position = endposs;
            }
        }
        input = true;


    }


}