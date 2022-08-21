using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLeftrightpatrol : MonoBehaviour
{
    public GameObject player;
    public bool go;
    public bool leftmove;
    public bool rightmove;
    public Tileholder Tiles;
    public GameObject currenttile;
    public GameObject prevtile;

    public bool attacked;
    public bool face;
    public int count;
    public bool stopped;
    public Vector3 saveposs;
    public bool hitten;
    // Start is called before the first frame update
    void Start()
    {
        go = false;
        leftmove = true;
        rightmove = false;
        stopped = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<EnemyHealth>().hiten == true&& hitten ==false&& this.GetComponent<EnemyHealth>().push == false)
        {
            print("help");
            hitten = true;
            StopAllCoroutines();
            StartCoroutine("backmove");
        }
        if (Mathf.Abs(player.transform.position.z - this.transform.position.z) == 2 && player.transform.position.x == this.transform.position.x && go ==false)
        {
            if(player.transform.position.z - this.transform.position.z < 0)
            {
                transform.rotation = Quaternion.Euler(transform.rotation.x, 90f, transform.rotation.z);
                face = true;
            }
            if (player.transform.position.z - this.transform.position.z > 0)
            {
                transform.rotation = Quaternion.Euler(transform.rotation.x, 270f, transform.rotation.z);
                face = true;

            }
        }

        if (attacked == false)
        {
            if (Mathf.Abs(player.transform.position.x - this.transform.position.x) ==2 && player.transform.position.z == this.transform.position.z && go == false)
            {
                if (player.transform.position.x - this.transform.position.x < 0)
                {
                    transform.rotation = Quaternion.Euler(transform.rotation.x, 180f, transform.rotation.z);
                }
                if (player.transform.position.x - this.transform.position.x > 0)
                {
                    transform.rotation = Quaternion.Euler(transform.rotation.x, 0f, transform.rotation.z);

                }
                player.GetComponent<Playertilemover>().StartCoroutine("attackedm");
                attacked = true;
            }
            if (face == true && player.GetComponent<Playertilemover>().Notmover == true)
            {
                count = player.GetComponent<Playertilemover>().move;
                player.GetComponent<Playertilemover>().StartCoroutine("attackedm");
                attacked = true;
                stopped = true;
            }
        }
        if (player.GetComponent<Playertilemover>().input == false && stopped == false)
        {

            if(go == false)
            {
                prevtile = currenttile;
                face = false;
                go = true;
                if (transform.position.x == 11)
                {
                    leftmove = true;
                    rightmove = false;

                }
                if (transform.position.x == 1)
                {
                    rightmove = true;
                    leftmove = false;

                }
                if (leftmove == true)
                {
                    transform.rotation = Quaternion.Euler(transform.rotation.x, 180f, transform.rotation.z);

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

                        StartCoroutine("Leftmove");

                    }
                    else
                    {
                        leftmove = false;
                        rightmove = true;
                    }
                }
                if (rightmove == true)
                {
                    transform.rotation = Quaternion.Euler(transform.rotation.x, 0f, transform.rotation.z);

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

                        StartCoroutine("Rightmove");

                    }
                    else
                    {

                        leftmove = true;
                        rightmove = false;
                        if (leftmove == true)
                        {
                            transform.rotation = Quaternion.Euler(transform.rotation.x, 180f, transform.rotation.z);

                            Vector3 endposs2 = transform.position - new Vector3(2, 0, 0);
                            if (endposs2.z == -1)
                            {
                                currenttile = Tiles.arrayMIUS1[Mathf.RoundToInt((endposs2.x + 1) / 2)];
                            }
                            if (endposs2.z == 1)
                            {
                                currenttile = Tiles.array1[Mathf.RoundToInt((endposs2.x + 1) / 2)];
                            }
                            if (endposs2.z == 3)
                            {
                                currenttile = Tiles.array2[Mathf.RoundToInt((endposs2.x + 1) / 2)];
                            }
                            if (endposs2.z == 5)
                            {
                                currenttile = Tiles.array3[Mathf.RoundToInt((endposs2.x + 1) / 2)];
                            }
                            if (endposs2.z == 7)
                            {
                                currenttile = Tiles.array4[Mathf.RoundToInt((endposs2.x + 1) / 2)];
                            }
                            if (endposs2.z == 9)
                            {
                                currenttile = Tiles.array5[Mathf.RoundToInt((endposs2.x + 1) / 2)];
                            }
                            if (endposs2.z == 11)
                            {
                                currenttile = Tiles.array6[Mathf.RoundToInt((endposs2.x + 1) / 2)];
                            }
                            if (endposs2.z == 13)
                            {
                                currenttile = Tiles.array7[Mathf.RoundToInt((endposs2.x + 1) / 2)];
                            }
                            if (endposs2.z == 15)
                            {
                                currenttile = Tiles.array8[Mathf.RoundToInt((endposs2.x +  1) / 2)];
                            }
                            if (endposs2.z == 17)
                            {
                                currenttile = Tiles.array9[Mathf.RoundToInt((endposs2.x + 1) / 2)];
                            }
                            if (currenttile.GetComponent<Tilechangerwalk>().ocupided == false)
                            {

                                StartCoroutine("Leftmove");

                            }
                            else
                            {
                                attacked = false;
                                leftmove = false;
                                rightmove = true;
                            }
                        }
                    }
                }

            }
        }
        if (player.GetComponent<Playertilemover>().input == true && stopped == true)
        {
            stopped = false;

        }

        if (player.GetComponent<Playertilemover>().input == true)
        {
            go = false;

        }

    }
    public IEnumerator Leftmove()
    {
        Vector3 startposs = transform.position;
        saveposs = startposs;
        Vector3 endposs = transform.position - new Vector3(2, 0, 0);
        while (transform.position.x != endposs.x)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (transform.position.x - endposs.x < 0.05)
            {
                attacked = false;

                transform.position = endposs;
            }
        }

    }
    public IEnumerator Rightmove()
    {

        Vector3 startposs = transform.position;
        saveposs = startposs;
        Vector3 endposs = transform.position + new Vector3(2, 0, 0);
        while (transform.position.x != endposs.x)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (endposs.x - transform.position.x < 0.05)
            {
                attacked = false;

                transform.position = endposs;
            }
        }
    }
    public IEnumerator backmove()
    {

        Vector3 startposs = transform.position;
        Vector3 endposs = saveposs;
        while (transform.position.x != endposs.x)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (Mathf.Abs(endposs.x - transform.position.x) < 0.05)
            {
                currenttile = prevtile;

                attacked = false;
                this.GetComponent<EnemyHealth>().hiten = false;
                transform.position = endposs;
                if(leftmove == true)
                {
                    leftmove = false;
                    rightmove = true;
                }
                else if (rightmove == true)
                {
                    leftmove = true;
                    rightmove = false;
                }
                hitten = false;

            }
        }
    }
}
