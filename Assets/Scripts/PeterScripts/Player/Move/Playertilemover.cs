using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playertilemover : MonoBehaviour
{
    public bool input;
    public Tileholder Tiles;
    public GameObject currenttile;
    public Vector3 Starttile;

    public bool forward;
    public bool Back;
    public bool Left;
    public bool Right;

    public bool Fireball;
    public bool Fireballcango;
    public bool Fireballisgo;

    public bool targeting;
    public GameObject[] Currentarray;

    // Start is called before the first frame update
    void Start()
    {
        input = true;
        forward = true;
        Back = false;
        Left = false;
        Right = false;
        Fireball = true;
        targeting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (input == true)
        {
            Starttile = transform.position;

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                targeting = false;
                Fireballcango = false;
                forward = true;
                Back = false;
                Left = false;
                Right = false;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                targeting = false;
                Fireballcango = false;

                forward = false;
                Back = true;
                Left = false;
                Right = false;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                targeting = false;
                Fireballcango = false;

                forward = false;
                Back = false;
                Left = true;
                Right = false;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                targeting = false;
                Fireballcango = false;

                forward = false;
                Back = false;
                Left = false;
                Right = true;
            }
            if (Input.GetKeyDown("r"))
            {
                targeting = true;

                if (Fireball == true)
                {
                    StartCoroutine("FireballTar");
                }
            }
            if(Fireballcango == true)
            {
                if (Input.GetKeyDown("f"))
                {
                    StartCoroutine("Fireballgo");
                }
            }
            if (Input.GetKeyDown("w"))
            {
                targeting = false;
                Fireballcango = false;

                forward = true;
                Back = false;
                Left = false;
                Right = false;

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
                targeting = false;
                Fireballcango = false;

                forward = false;
                Back = true;
                Left = false;
                Right = false;
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
                targeting = false;
                Fireballcango = false;

                forward = false;
                Back = false;
                Left = true;
                Right = false;
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
                targeting = false;
                Fireballcango = false;

                forward = false;
                Back = false;
                Left = false;
                Right = true;
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
                targeting = false;
                Fireballcango = false;

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
    public IEnumerator Fireballgo()
    {
        foreach (GameObject tile in Tiles.array1)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    tile.GetComponent<Tilechangerwalk>().inside.gameObject.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");
                }
            }
        }
        foreach (GameObject tile in Tiles.array2)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    tile.GetComponent<Tilechangerwalk>().inside.gameObject.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");
                }
            }
        }
        foreach (GameObject tile in Tiles.array3)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    tile.GetComponent<Tilechangerwalk>().inside.gameObject.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");
                }
            }
        }
        foreach (GameObject tile in Tiles.array4)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    tile.GetComponent<Tilechangerwalk>().inside.gameObject.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");
                }
            }
        }
        foreach (GameObject tile in Tiles.array5)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    tile.GetComponent<Tilechangerwalk>().inside.gameObject.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");
                }
            }
        }
        yield return null;

    }
    public IEnumerator FireballTar()
    {
        if (forward == true)
        {
            Vector3 Thisposs = transform.position;

            for (int i = Mathf.RoundToInt(Thisposs.z)+1; i < 10; i++)
            {
                if (i == 1)
                {
                    Tiles.array1[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                }
                if (i == 3)
                {
                    Tiles.array2[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                }
                if (i == 5)
                {
                    Tiles.array3[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                }
                if (i == 7)
                {
                    Tiles.array4[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                }
                if (i == 9)
                {
                    Tiles.array5[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                }
            }
        }
        if (Back == true)
        {
            Vector3 Thisposs = transform.position;

            for (int i = 1; i < Mathf.RoundToInt(Thisposs.z); i++)
            {
                if (i == 1)
                {
                    Tiles.array1[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                }
                if (i == 3)
                {
                    Tiles.array2[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                }
                if (i == 5)
                {
                    Tiles.array3[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                }
                if (i == 7)
                {
                    Tiles.array4[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                }
                if (i == 9)
                {
                    Tiles.array5[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                }
            }
        }
        if (Right== true)
        {
            Vector3 Thisposs = transform.position;

            if (Thisposs.z == 1)
            {
                Currentarray = Tiles.array1;
            }
            if (Thisposs.z == 3)
            {
                Currentarray = Tiles.array2;
            }
            if (Thisposs.z == 5)
            {
                Currentarray = Tiles.array3;
            }
            if (Thisposs.z == 7)
            {
                Currentarray = Tiles.array4;
            }
            if (Thisposs.z == 9)
            {
                Currentarray = Tiles.array5;
            }
            for (int i = Mathf.RoundToInt((Thisposs.x + 1) / 2); i < 5; i++)
            {
                Currentarray[i].GetComponent<Tilechangerwalk>().target = true;
            }
        }
        if (Left == true)
        {
            Vector3 Thisposs = transform.position;

            if (Thisposs.z == 1)
            {
                Currentarray = Tiles.array1;
            }
            if (Thisposs.z == 3)
            {
                Currentarray = Tiles.array2;
            }
            if (Thisposs.z == 5)
            {
                Currentarray = Tiles.array3;
            }
            if (Thisposs.z == 7)
            {
                Currentarray = Tiles.array4;
            }
            if (Thisposs.z == 9)
            {
                Currentarray = Tiles.array5;
            }
            for (int i = 0; i < Mathf.RoundToInt((Thisposs.x - 1) / 2); i++)
            {
                Currentarray[i].GetComponent<Tilechangerwalk>().target = true;
            }
        }
        Fireballcango = true;
        input = true;
        yield return null;


    }

}