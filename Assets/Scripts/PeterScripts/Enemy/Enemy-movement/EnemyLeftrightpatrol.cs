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
    // Start is called before the first frame update
    void Start()
    {
        go = false;
        leftmove = true;
        rightmove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<Playertilemover>().input == false)
        {
            if(go == false)
            {
                go = true;
                if(transform.position.x == 9)
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

                        StartCoroutine("Rightmove");

                    }
                    else
                    {
                        leftmove = true;
                        rightmove = false;
                        if (leftmove == true)
                        {
                            Vector3 endposs2 = transform.position - new Vector3(2, 0, 0);

                            if (endposs2.z == 1)
                            {
                                currenttile = Tiles.array1[Mathf.RoundToInt((endposs2.x - 1) / 2)];
                            }
                            if (endposs2.z == 3)
                            {
                                currenttile = Tiles.array2[Mathf.RoundToInt((endposs2.x - 1) / 2)];
                            }
                            if (endposs2.z == 5)
                            {
                                currenttile = Tiles.array3[Mathf.RoundToInt((endposs2.x - 1) / 2)];
                            }
                            if (endposs2.z == 7)
                            {
                                currenttile = Tiles.array4[Mathf.RoundToInt((endposs2.x - 1) / 2)];
                            }
                            if (endposs2.z == 9)
                            {
                                currenttile = Tiles.array5[Mathf.RoundToInt((endposs2.x - 1) / 2)];
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
                    }
                }

            }
        }
        if (player.GetComponent<Playertilemover>().input == true)
        {
            go = false;
        }

    }
    public IEnumerator Leftmove()
    {

        Vector3 startposs = transform.position;
        Vector3 endposs = transform.position - new Vector3(2, 0, 0);
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
    }
}
