using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bigenmimove : MonoBehaviour
{
    public GameObject player;
    public bool go;
    public bool go2;

    public bool stoper;
    public Vector3 save;

    public Tileholder Tiles;
    public GameObject currenttile;
    public GameObject star;
    public GameObject star1;
    public bool TRYBOOL;

    // Start is called before the first frame update
    void Start()
    {
        save = this.transform.position;

        go = false;

    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(player.transform.position.x - this.transform.position.x) > Mathf.Abs(player.transform.position.z - this.transform.position.z))
        {

            if ((player.transform.position.x - this.transform.position.x) > 0)
            {

                transform.rotation = Quaternion.Euler(transform.rotation.x, 270f, transform.rotation.z);


            }
            else
            {

                transform.rotation = Quaternion.Euler(transform.rotation.x, 90f, transform.rotation.z);

            }
        }
        else
        {

            if ((player.transform.position.z - this.transform.position.z) > 0)
            {

                transform.rotation = Quaternion.Euler(transform.rotation.x, 180f, transform.rotation.z);

            }
            else
            {

                transform.rotation = Quaternion.Euler(transform.rotation.x, 0f, transform.rotation.z);


            }
        }
        if (star1 != null)
        {
            star1.transform.position = this.transform.position;

        }

        if (player.GetComponent<Playertilemover>().input == false)
        {
            if (go == false&& stoper == false)
            {
                go = true;
                stoper = true;
            }
            else if (go == false && stoper == true)
            {
                stoper = false;

                go = true;
                if(Mathf.Abs(player.transform.position.x-this.transform.position.x ) > Mathf.Abs(player.transform.position.z - this.transform.position.z))
                {
                    if (Mathf.Abs(player.transform.position.x - this.transform.position.x) <= 3)
                    {


                    }
                    else if ((player.transform.position.x - this.transform.position.x) > 0)
                    {

                        StartCoroutine("Rightmove");


                    }
                    else
                    {

                        StartCoroutine("Leftmove");

                    }
                }
                else
                {
                    if (Mathf.Abs(player.transform.position.z - this.transform.position.z) <= 3)
                    {


                    }
                    else if ((player.transform.position.z - this.transform.position.z) > 0)
                    {

                        StartCoroutine("Backmove");

                    }
                    else
                    {

                        StartCoroutine("Forwardmove");


                    }
                }

            }


        }
        if (player.GetComponent<Playertilemover>().input == false)
        {
            if (go2 == false)
            {
                go2 = true;
                if (TRYBOOL ==true)
                {
                    TRYBOOL = false;
                    StartCoroutine("attack");
                }
            }
        }
        if (player.GetComponent<Playertilemover>().input == true)
        {
            if (go2 == false)
            {
                go2 = true;
                if (Mathf.Abs(player.transform.position.x - save.x) <= 3 && Mathf.Abs(player.transform.position.z - save.z) <= 3)
                {
                    TRYBOOL = true;
                    StartCoroutine("attacktar");
                }
            }
        }



        if (player.GetComponent<Playertilemover>().input == true)
        {
            go = false;
            go2 = false;
        }

    }
    public IEnumerator attack()
    {
        GameObject star1 = Instantiate(star, transform.position, transform.rotation);
        star1.transform.parent = this.gameObject.transform;

        Debug.Log("33");
        yield return null;

    }
    public IEnumerator attacktar()
    {
        if (this.transform.position.z == 2)
        {
            for (int i = Mathf.RoundToInt(this.transform.position.x)/2 -1; i < Mathf.RoundToInt(this.transform.position.x)/2 + 3; i++)
            {
                Tiles.arrayMIUS1[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array1[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array2[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array3[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
            }

        }
        if (this.transform.position.z == 4)
        {
            for (int i = Mathf.RoundToInt(this.transform.position.x) / 2 - 1; i < Mathf.RoundToInt(this.transform.position.x) / 2 + 3; i++)
            {
                Tiles.array1[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array2[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array3[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array4[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;

            }

        }
        if (this.transform.position.z == 6)
        {
            for (int i = Mathf.RoundToInt(this.transform.position.x) / 2 - 1; i < Mathf.RoundToInt(this.transform.position.x) / 2 + 3; i++)
            {
                Tiles.array2[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array3[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array4[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array5[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;

            }

        }
        if (this.transform.position.z == 8)
        {
            for (int i = Mathf.RoundToInt(this.transform.position.x) / 2 - 1; i < Mathf.RoundToInt(this.transform.position.x) / 2 + 3; i++)
            {
                Tiles.array3[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array4[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array5[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array6[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;

            }

        }
        if (this.transform.position.z == 10)
        {
            for (int i = Mathf.RoundToInt(this.transform.position.x) / 2 - 1; i < Mathf.RoundToInt(this.transform.position.x) / 2 + 3; i++)
            {
                Tiles.array4[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array5[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array6[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array7[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;

            }

        }
        if (this.transform.position.z == 12)
        {
            for (int i = Mathf.RoundToInt(this.transform.position.x) / 2 - 1; i < Mathf.RoundToInt(this.transform.position.x) / 2 + 3; i++)
            {
                Tiles.array5[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array6[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array7[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array8[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;

            }

        }
        if (this.transform.position.z == 14)
        {
            for (int i = Mathf.RoundToInt(this.transform.position.x) / 2 - 1; i < Mathf.RoundToInt(this.transform.position.x) / 2 + 3; i++)
            {
                Tiles.array6[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array7[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array8[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;
                Tiles.array9[Mathf.RoundToInt(i)].GetComponent<Tilechangerwalk>().attack = true;

            }

        }
        Debug.Log("tar");
        yield return null;

    }
    public IEnumerator Rightmove()
    {

        Vector3 startposs = transform.position;
        Vector3 endposs = transform.position + new Vector3(2, 0, 0);
        while (transform.position.x != endposs.x)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (endposs.x - transform.position.x < 0.025)
            {
                transform.position = endposs;
                save = endposs;

            }
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
            if (transform.position.x - endposs.x < 0.025)
            {
                transform.position = endposs;
                save = endposs;

            }
        }

    }
    public IEnumerator Forwardmove()
    {

        Vector3 startposs = transform.position;
        Vector3 endposs = transform.position - new Vector3(0, 0, 2);

        while (transform.position.z != endposs.z)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (transform.position.z - endposs.z < 0.025)
            {
                transform.position = endposs;
                save = endposs;

            }
        }
    }
    public IEnumerator Backmove()
    {

        Vector3 startposs = transform.position;
        Vector3 endposs = transform.position + new Vector3(0, 0, 2);

        while (transform.position.z != endposs.z)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if (endposs.z - transform.position.z < 0.025)

            {
                transform.position = endposs;
                save = endposs;

            }
        }

    }
}

