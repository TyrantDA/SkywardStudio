using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playertilemover : MonoBehaviour
{
    public bool input;
    public Tileholder Tiles;
    public GameObject currenttile;
    public GameObject actualcurrenttile;

    public GameObject nexttile;
    public GameObject pushing;

    public Vector3 Starttile;

    public bool forward;
    public bool Back;
    public bool Left;
    public bool Right;

    public bool Fireball;
    public bool Fireballcango;
    public bool Fireballisgo;

    public bool Slash;
    public bool Slashcango;
    public bool Slashisgo;

    public bool bash;
    public bool bashcango;
    public bool bashisgo;
    public Vector3 push;

    public bool pusehd;
    public bool hit;

    public bool targeting;
    public GameObject[] Currentarray;

    public int move;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        input = true;
        forward = true;
        Back = false;
        Left = false;
        Right = false;
        Fireball = false;
        bash = true;
        targeting = false;
        pusehd = false;
        hit = false;
        move = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(forward == true)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, 0f, transform.rotation.z);
        }
        if (Back == true)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, 180f, transform.rotation.z);
        }
        if (Left == true)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, 270f, transform.rotation.z);
        }
        if (Right == true)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, 90f, transform.rotation.z);
        }
        if (input == true)
        {
            Starttile = transform.position;
            Vector3 poss = transform.position;
            if (poss.z == -1)
            {
                actualcurrenttile = Tiles.arrayMIUS1[Mathf.RoundToInt((poss.x + 1) / 2)];
            }
            if (poss.z == 1)
            {
                actualcurrenttile = Tiles.array1[Mathf.RoundToInt((poss.x + 1) / 2)];
            }
            if (poss.z == 3)
            {
                actualcurrenttile = Tiles.array2[Mathf.RoundToInt((poss.x + 1) / 2)];
            }
            if (poss.z == 5)
            {
                actualcurrenttile = Tiles.array3[Mathf.RoundToInt((poss.x + 1) / 2)];
            }
            if (poss.z == 7)
            {
                actualcurrenttile = Tiles.array4[Mathf.RoundToInt((poss.x + 1) / 2)];
            }
            if (poss.z == 9)
            {
                actualcurrenttile = Tiles.array5[Mathf.RoundToInt((poss.x + 1) / 2)];
            }
            if (poss.z == 11)
            {
                actualcurrenttile = Tiles.array6[Mathf.RoundToInt((poss.x + 1) / 2)];
            }
            if (poss.z == 13)
            {
                actualcurrenttile = Tiles.array7[Mathf.RoundToInt((poss.x + 1) / 2)];
            }
            if (poss.z == 15)
            {
                actualcurrenttile = Tiles.array8[Mathf.RoundToInt((poss.x + 1) / 2)];
            }
            if (poss.z == 17)
            {
                actualcurrenttile = Tiles.array9[Mathf.RoundToInt((poss.x + 1) / 2)];
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                forward = true;
                Back = false;
                Left = false;
                Right = false;

                Fireballcango = false;
                Slashcango = false;
                bashcango = false;

                if ( targeting == true)
                {
                    targeting = false;
                    if (Fireball == true)
                    {
                        StartCoroutine("FireballTar");
                    }
                    if (Slash == true)
                    {
                        StartCoroutine("SlashTar");
                    }
                    if (bash == true)
                    {
                        StartCoroutine("bashtar");
                    }
                }


            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                forward = false;
                Back = true;
                Left = false;
                Right = false;

                Fireballcango = false;
                Slashcango = false;
                bashcango = false;


                if (targeting == true)
                {
                    targeting = false;
                    if (Fireball == true)
                    {
                        StartCoroutine("FireballTar");
                    }
                    if (Slash == true)
                    {
                        StartCoroutine("SlashTar");
                    }
                    if (bash == true)
                    {
                        StartCoroutine("bashtar");
                    }
                }


            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                forward = false;
                Back = false;
                Left = true;
                Right = false;

                Fireballcango = false;
                Slashcango = false;
                bashcango = false;
                if (targeting == true)
                {
                    targeting = false;
                    if (Fireball == true)
                    {
                        StartCoroutine("FireballTar");
                    }
                    if (Slash == true)
                    {
                        StartCoroutine("SlashTar");
                    }
                    if (bash == true)
                    {
                        StartCoroutine("bashtar");
                    }
                }


            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                forward = false;
                Back = false;
                Left = false;
                Right = true;

                Fireballcango = false;
                Slashcango = false;
                if (targeting == true)
                {
                    targeting = false;
                    if (Fireball == true)
                    {
                        StartCoroutine("FireballTar");
                    }
                    if (Slash == true)
                    {
                        StartCoroutine("SlashTar");
                    }
                    if (bash == true)
                    {
                        StartCoroutine("bashtar");
                    }
                }


            }
            if (Input.GetKeyDown("f"))
            {
                Fireballcango = false;
                Slashcango = false;
                bashcango = false;


                Fireball = true;
                Slash = false;
                bash = false;

                if (targeting == true)
                {
                    targeting = false;
                    if (Fireball == true)
                    {
                        StartCoroutine("FireballTar");
                    }
                    if (Slash == true)
                    {
                        StartCoroutine("SlashTar");
                    }
                    if (bash == true)
                    {
                        StartCoroutine("bashtar");
                    }
                }

            }
            if (Input.GetKeyDown("b"))
            {

                Fireballcango = false;
                Slashcango = false;

                bash = true;
                Slash = false;
                Fireball = false;

                if (targeting == true)
                {
                    targeting = false;
                    if (Fireball == true)
                    {
                        StartCoroutine("FireballTar");
                    }
                    if (Slash == true)
                    {
                        StartCoroutine("SlashTar");
                    }
                    if (bash == true)
                    {
                        StartCoroutine("bashtar");
                    }
                }
            }
            if (Input.GetKeyDown("g"))
            {

                Fireballcango = false;
                Slashcango = false;

                Slash = true;
                Fireball = false;

                if (targeting == true)
                {
                    targeting = false;
                    if (Fireball == true)
                    {
                        StartCoroutine("FireballTar");
                    }
                    if (Slash == true)
                    {
                        StartCoroutine("SlashTar");
                    }
                }
            }
            if (Input.GetKeyDown("r"))
            {
                targeting = true;

                if (Fireball == true)
                {
                    StartCoroutine("FireballTar");
                }
                if (Slash == true)
                {
                    StartCoroutine("SlashTar");
                }
                if (bash == true)
                {
                    StartCoroutine("bashtar");
                }
            }
            if(Fireballcango == true)
            {
                if (Input.GetKeyDown("e"))
                {
                    input = false;
                    StartCoroutine("Attackgo");
                }
            }
            if (Slashcango == true)
            {
                if (Input.GetKeyDown("e"))
                {
                    input = false;
                    StartCoroutine("Attackgo");

                }
            }
            if (bashcango == true)
            {
                if (Input.GetKeyDown("e"))
                {
                   // input = false;
                    StartCoroutine("Bashattackgo");

                }
            }
            if (Input.GetAxis("Vertical") == 1)
            {
                targeting = false;
                Fireballcango = false;
                Slashcango = false;

                forward = true;
                Back = false;
                Left = false;
                Right = false;

                Vector3 endposs = transform.position + new Vector3(0, 0, 2);
                if (endposs.z == -1)
                {
                    currenttile = Tiles.arrayMIUS1[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 1)
                {
                    currenttile = Tiles.array1[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 3)
                {
                    currenttile = Tiles.array2[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 5)
                {
                    currenttile = Tiles.array3[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 7)
                {
                    currenttile = Tiles.array4[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 9)
                {
                    currenttile = Tiles.array5[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 11)
                {
                    currenttile = Tiles.array6[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 13)
                {
                    currenttile = Tiles.array7[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 15)
                {
                    currenttile = Tiles.array8[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 17)
                {
                    currenttile = Tiles.array9[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (currenttile.GetComponent<Tilechangerwalk>().ocupided == false)
                {
                    input = false;

                    StartCoroutine("Forwardmove");

                }


            }
            if (Input.GetAxis("Vertical") == -1)
            {

                targeting = false;
                Fireballcango = false;
                Slashcango = false;

                forward = false;
                Back = true;
                Left = false;
                Right = false;
                Vector3 endposs = transform.position - new Vector3(0, 0, 2);

                if (endposs.z == -1)
                {
                    currenttile = Tiles.arrayMIUS1[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 1)
                {
                    currenttile = Tiles.array1[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 3)
                {
                    currenttile = Tiles.array2[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 5)
                {
                    currenttile = Tiles.array3[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 7)
                {
                    currenttile = Tiles.array4[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 9)
                {
                    currenttile = Tiles.array5[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 11)
                {
                    currenttile = Tiles.array6[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 13)
                {
                    currenttile = Tiles.array7[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 15)
                {
                    currenttile = Tiles.array8[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 17)
                {
                    currenttile = Tiles.array9[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (currenttile.GetComponent<Tilechangerwalk>().ocupided == false)
                {
                    input = false;

                    StartCoroutine("Backmove");

                }
            }
            if (Input.GetAxis("Horizontal") == -1)
            {

                targeting = false;
                Fireballcango = false;
                Slashcango = false;

                forward = false;
                Back = false;
                Left = true;
                Right = false;
                Vector3 endposs = transform.position - new Vector3(2, 0, 0);

                if (endposs.z == -1)
                {
                    currenttile = Tiles.arrayMIUS1[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 1)
                {
                    currenttile = Tiles.array1[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 3)
                {
                    currenttile = Tiles.array2[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 5)
                {
                    currenttile = Tiles.array3[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 7)
                {
                    currenttile = Tiles.array4[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 9)
                {
                    currenttile = Tiles.array5[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 11)
                {
                    currenttile = Tiles.array6[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 13)
                {
                    currenttile = Tiles.array7[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 15)
                {
                    currenttile = Tiles.array8[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 17)
                {
                    currenttile = Tiles.array9[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (currenttile.GetComponent<Tilechangerwalk>().ocupided == false)
                {
                    input = false;

                    StartCoroutine("Leftmove");

                }
            }
            if (Input.GetAxis("Horizontal") == 1)
            {

                targeting = false;
                Fireballcango = false;
                Slashcango = false;

                forward = false;
                Back = false;
                Left = false;
                Right = true;
                Vector3 endposs = transform.position + new Vector3(2, 0, 0);

                if (endposs.z == -1)
                {
                    currenttile = Tiles.arrayMIUS1[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 1)
                {
                    currenttile = Tiles.array1[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 3)
                {
                    currenttile = Tiles.array2[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 5)
                {
                    currenttile = Tiles.array3[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 7)
                {
                    currenttile = Tiles.array4[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 9)
                {
                    currenttile = Tiles.array5[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 11)
                {
                    currenttile = Tiles.array6[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 13)
                {
                    currenttile = Tiles.array7[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 15)
                {
                    currenttile = Tiles.array8[Mathf.RoundToInt((endposs.x + 1) / 2)];
                }
                if (endposs.z == 17)
                {
                    currenttile = Tiles.array9[Mathf.RoundToInt((endposs.x + 1) / 2)];
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
                Slashcango = false;

                input = false;
                StartCoroutine("Notmove");
            }
        }



    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if(pusehd == false)
            {
                StopAllCoroutines();
                StartCoroutine("Moveback");
            }
            if (pusehd == true)
            {
                hit = true;
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
                move++;

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
                move++;

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
                move++;

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
                move++;

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
        while (transform.position.x != endposs.x)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (Mathf.Abs(endposs.x - transform.position.x) < 0.05)
            {
                transform.position = endposs;
            }
        }
        input = true;


    }
    public IEnumerator Bashattackgo()
    {

        if(forward == true)
        {
            push = new Vector3(0, 0, 2);
        }
        if (Back == true)
        {
            push = new Vector3(0, 0, -2);
        }
        if (Left == true)
        {
            push = new Vector3(-2, 0, 0);
        }
        if (Right == true)
        {
            push = new Vector3(2, 0, 0);
        }
        foreach (GameObject tile in Tiles.array1)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        print(saveposs1);
                        print(saveposs2);
                        print(saveposs3);
                        print(saveposs4);

                        while (pushing.transform.position.z != endposs.z)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs2.z) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs3.z) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs4.z) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.z - endposs.z) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        foreach (GameObject tile in Tiles.array2)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        print(saveposs1);
                        print(saveposs2);
                        print(saveposs3);
                        print(saveposs4);

                        while (pushing.transform.position.z != endposs.z)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs2.z) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs3.z) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs4.z) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.z - endposs.z) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        foreach (GameObject tile in Tiles.array3)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        print(saveposs1);
                        print(saveposs2);
                        print(saveposs3);
                        print(saveposs4);

                        while (pushing.transform.position.z != endposs.z)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs2.z) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs3.z) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs4.z) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.z - endposs.z) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        foreach (GameObject tile in Tiles.array4)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        print(saveposs1);
                        print(saveposs2);
                        print(saveposs3);
                        print(saveposs4);

                        while (pushing.transform.position.z != endposs.z)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs2.z) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs3.z) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs4.z) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.z - endposs.z) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        foreach (GameObject tile in Tiles.array5)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        print(saveposs1);
                        print(saveposs2);
                        print(saveposs3);
                        print(saveposs4);

                        while (pushing.transform.position.z != endposs.z)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs2.z) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs3.z) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs4.z) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.z - endposs.z) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        foreach (GameObject tile in Tiles.array6)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        print(saveposs1);
                        print(saveposs2);
                        print(saveposs3);
                        print(saveposs4);

                        while (pushing.transform.position.z != endposs.z)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs2.z) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs3.z) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs4.z) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.z - endposs.z) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        foreach (GameObject tile in Tiles.array7)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        print(saveposs1);
                        print(saveposs2);
                        print(saveposs3);
                        print(saveposs4);

                        while (pushing.transform.position.z != endposs.z)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs2.z) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs3.z) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs4.z) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.z - endposs.z) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        foreach (GameObject tile in Tiles.array8)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        print(saveposs1);
                        print(saveposs2);
                        print(saveposs3);
                        print(saveposs4);

                        while (pushing.transform.position.z != endposs.z)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs2.z) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs3.z) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.z - saveposs4.z) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.z - endposs.z) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        foreach (GameObject tile in Tiles.array1)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        while (pushing.transform.position.x != endposs.x)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs2.x) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs3.x) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs4.x) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.x - endposs.x) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        foreach (GameObject tile in Tiles.array2)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        while (pushing.transform.position.x != endposs.x)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs2.x) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs3.x) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs4.x) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.x - endposs.x) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        foreach (GameObject tile in Tiles.array3)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        while (pushing.transform.position.x != endposs.x)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs2.x) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs3.x) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs4.x) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.x - endposs.x) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        foreach (GameObject tile in Tiles.array4)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        while (pushing.transform.position.x != endposs.x)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs2.x) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs3.x) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs4.x) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.x - endposs.x) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        foreach (GameObject tile in Tiles.array5)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        while (pushing.transform.position.x != endposs.x)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs2.x) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs3.x) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs4.x) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.x - endposs.x) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        foreach (GameObject tile in Tiles.array6)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        while (pushing.transform.position.x != endposs.x)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs2.x) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs3.x) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs4.x) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.x - endposs.x) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        foreach (GameObject tile in Tiles.array7)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        while (pushing.transform.position.x != endposs.x)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs2.x) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs3.x) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs4.x) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.x - endposs.x) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        foreach (GameObject tile in Tiles.array8)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (tile.GetComponent<Tilechangerwalk>().inside.gameObject.tag == "Enemy")
                    {
                        Vector3 startposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position;
                        Vector3 endposs = tile.GetComponent<Tilechangerwalk>().inside.gameObject.transform.position + push;
                        pushing = tile.GetComponent<Tilechangerwalk>().inside.gameObject;
                        Vector3 saveposs1 = pushing.transform.position;
                        Vector3 saveposs2 = pushing.transform.position + 0.25f * push;
                        Vector3 saveposs3 = pushing.transform.position + 0.5f * push;
                        Vector3 saveposs4 = pushing.transform.position + 0.75f * push;
                        Vector3 saveposs = saveposs1;
                        while (pushing.transform.position.x != endposs.x)
                        {
                            pushing.transform.position += (endposs - startposs) * Time.deltaTime * 1;
                            yield return null;
                            if (pushing.gameObject.GetComponent<EnemyHealth>().hit == true)
                            {
                                endposs = saveposs;
                                startposs = pushing.transform.position + push;
                                pushing.gameObject.GetComponent<EnemyHealth>().hit = false;
                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs2.x) < 0.05))
                            {
                                saveposs = saveposs2;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs3.x) < 0.05))
                            {
                                saveposs = saveposs3;

                            }
                            if ((Mathf.Abs(pushing.transform.position.x - saveposs4.x) < 0.05))
                            {
                                saveposs = saveposs4;

                            }
                            if (Mathf.Abs(pushing.transform.position.x - endposs.x) < 0.05)
                            {

                                pushing.transform.position = endposs;
                                pushing.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");

                            }
                        }
                    }
                }
            }
        }
        yield return new WaitForSeconds(1f);

        input = true;
        yield return null;

    }
    public IEnumerator Attackgo()
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
        foreach (GameObject tile in Tiles.array6)
        {
            if (tile.GetComponent<Tilechangerwalk>().target == true)
            {
                if (tile.GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    tile.GetComponent<Tilechangerwalk>().inside.gameObject.GetComponent<EnemyHealth>().StartCoroutine("Fireballdam");
                }
            }
        }
        yield return new WaitForSeconds(1f);

        input = true;
        yield return null;

    }
    public IEnumerator FireballTar()
    {
        yield return new WaitForSeconds(0.1f);

        targeting = true;
        if (forward == true)
        {
            Vector3 Thisposs = transform.position;

            for (int i = Mathf.RoundToInt(Thisposs.z)+1; i < 12; i++)
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
                if (i == 11)
                {
                    Tiles.array6[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
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
                if (i == 11)
                {
                    Tiles.array6[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
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
            if (Thisposs.z == 11)
            {
                Currentarray = Tiles.array6;
            }
            for (int i = Mathf.RoundToInt((Thisposs.x + 1) / 2); i < 6; i++)
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
            if (Thisposs.z == 11)
            {
                Currentarray = Tiles.array6;
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
    public IEnumerator bashtar()
    {
        yield return new WaitForSeconds(0.1f);

        targeting = true;
        if (forward == true)
        {
            Vector3 endposs = transform.position + new Vector3(0, 0, 2);
            if (endposs.z == -1)
            {
                nexttile = Tiles.arrayMIUS1[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 1)
            {
                nexttile = Tiles.array1[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 3)
            {
                nexttile = Tiles.array2[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 5)
            {
                nexttile = Tiles.array3[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 7)
            {
                nexttile = Tiles.array4[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 9)
            {
                nexttile = Tiles.array5[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 11)
            {
                nexttile = Tiles.array6[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 13)
            {
                nexttile = Tiles.array7[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 15)
            {
                nexttile = Tiles.array8[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 17)
            {
                nexttile = Tiles.array9[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
        }
        if (Back == true)
        {
            Vector3 endposs = transform.position - new Vector3(0, 0, 2);


            if (endposs.z == -1)
            {
                nexttile = Tiles.arrayMIUS1[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 1)
            {
                nexttile = Tiles.array1[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 3)
            {
                nexttile = Tiles.array2[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 5)
            {
                nexttile = Tiles.array3[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 7)
            {
                nexttile = Tiles.array4[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 9)
            {
                nexttile = Tiles.array5[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 11)
            {
                nexttile = Tiles.array6[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 13)
            {
                nexttile = Tiles.array7[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 15)
            {
                nexttile = Tiles.array8[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 17)
            {
                nexttile = Tiles.array9[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
        }
        if (Right == true)
        {
            Vector3 endposs = transform.position + new Vector3(2, 0, 0);

            if (endposs.z == -1)
            {
                nexttile = Tiles.arrayMIUS1[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 1)
            {
                nexttile = Tiles.array1[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 3)
            {
                nexttile = Tiles.array2[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 5)
            {
                nexttile = Tiles.array3[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 7)
            {
                nexttile = Tiles.array4[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 9)
            {
                nexttile = Tiles.array5[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 11)
            {
                nexttile = Tiles.array6[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 13)
            {
                nexttile = Tiles.array7[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 15)
            {
                nexttile = Tiles.array8[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 17)
            {
                nexttile = Tiles.array9[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
        }
        if (Left == true)
        {
            Vector3 endposs = transform.position - new Vector3(2, 0, 0);
            if (endposs.z == -1)
            {
                nexttile = Tiles.arrayMIUS1[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 1)
            {
                nexttile = Tiles.array1[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 3)
            {
                nexttile = Tiles.array2[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 5)
            {
                nexttile = Tiles.array3[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 7)
            {
                nexttile = Tiles.array4[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 9)
            {
                nexttile = Tiles.array5[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 11)
            {
                nexttile = Tiles.array6[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 13)
            {
                nexttile = Tiles.array7[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 15)
            {
                nexttile = Tiles.array8[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
            if (endposs.z == 17)
            {
                nexttile = Tiles.array9[Mathf.RoundToInt((endposs.x + 1) / 2)];
            }
        }
        nexttile.GetComponent<Tilechangerwalk>().target = true;

        bashcango = true;
        input = true;
        yield return null;


    }
    public IEnumerator SlashTar()
    {
        yield return new WaitForSeconds(0.1f);
        targeting = true;
        if (forward == true)
        {
            Vector3 Thisposs = transform.position;

            if (Mathf.RoundToInt(Thisposs.z) == 1)
            {
                Tiles.array2[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array2[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array2[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;

            }
            if (Mathf.RoundToInt(Thisposs.z) == 3)
            {
                Tiles.array3[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array3[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array3[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }
            if (Mathf.RoundToInt(Thisposs.z) == 5)
            {
                Tiles.array4[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array4[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array4[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }
            if (Mathf.RoundToInt(Thisposs.z) == 7)
            {
                Tiles.array5[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array5[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array5[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }
            if (Mathf.RoundToInt(Thisposs.z) == 9)
            {
                Tiles.array6[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array6[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array6[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }

        }
        if (Back == true)
        {
            Vector3 Thisposs = transform.position;

            if (Mathf.RoundToInt(Thisposs.z) == 3)
            {
                Tiles.array1[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array1[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array1[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }
            if (Mathf.RoundToInt(Thisposs.z) == 5)
            {
                Tiles.array2[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array2[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array2[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;

            }
            if (Mathf.RoundToInt(Thisposs.z) == 7)
            {
                Tiles.array3[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array3[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array3[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }
            if (Mathf.RoundToInt(Thisposs.z) == 9)
            {
                Tiles.array4[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array4[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array4[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }
            if (Mathf.RoundToInt(Thisposs.z) == 11)
            {
                Tiles.array5[Mathf.RoundToInt((Thisposs.x - 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array5[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array5[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }

        }
        if (Right == true)
        {
            Vector3 Thisposs = transform.position;

            if (Mathf.RoundToInt(Thisposs.z) == 1)
            {
                Tiles.array1[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array2[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }
            if (Mathf.RoundToInt(Thisposs.z) == 3)
            {
                Tiles.array2[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array1[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array3[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;

            }
            if (Mathf.RoundToInt(Thisposs.z) == 5)
            {
                Tiles.array3[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array2[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array4[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }
            if (Mathf.RoundToInt(Thisposs.z) == 7)
            {
                Tiles.array4[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array3[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array5[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }
            if (Mathf.RoundToInt(Thisposs.z) == 9)
            {
                Tiles.array5[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array4[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array6[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;

            }
            if (Mathf.RoundToInt(Thisposs.z) == 11)
            {
                Tiles.array6[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array5[Mathf.RoundToInt((Thisposs.x + 1) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }
        }
        if (Left == true)
        {
            Vector3 Thisposs = transform.position;

            if (Mathf.RoundToInt(Thisposs.z) == 1)
            {
                Tiles.array1[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array2[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }
            if (Mathf.RoundToInt(Thisposs.z) == 3)
            {
                Tiles.array2[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array1[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array3[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;

            }
            if (Mathf.RoundToInt(Thisposs.z) == 5)
            {
                Tiles.array3[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array2[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array4[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }
            if (Mathf.RoundToInt(Thisposs.z) == 7)
            {
                Tiles.array4[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array3[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array5[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }
            if (Mathf.RoundToInt(Thisposs.z) == 9)
            {
                Tiles.array5[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array4[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array6[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }
            if (Mathf.RoundToInt(Thisposs.z) == 11)
            {
                Tiles.array5[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
                Tiles.array6[Mathf.RoundToInt((Thisposs.x - 2.5F) / 2)].GetComponent<Tilechangerwalk>().target = true;
            }
        }
        Slashcango = true;
        input = true;
        yield return null;


    }

}