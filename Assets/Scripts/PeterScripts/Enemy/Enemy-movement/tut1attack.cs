using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tut1attack : MonoBehaviour
{
    public GameObject player;
    public bool attacked;
    public bool going;
    public int fuel;
    public Playertilemover hold;
    public GameObject modual;

    // Start is called before the first frame update
    void Start()
    {
        attacked = false;
        fuel = 30;
    }

    // Update is called once per frame
    void Update()
    {
        float attackposs = player.transform.position.z;
        if (attackposs == (transform.position.z - 2))
        {
            print("d");
            StartCoroutine("nockback");
        }
        if (attacked == true)
        {
            if(going == true)
            {
                if (hold.input == false)
                {
                    fuel = fuel - 1;
                    going = false;
                }
            }
            if (hold.input == true)
            {
                going = true;
            }
        }
        if (fuel <= 0)
        {
            this.GetComponent<tut1follow>().enabled = false;
            this.GetComponent<tut1attack>().enabled = false;
            this.GetComponent<MeshRenderer>().enabled = false;
            var newSquare = Instantiate(modual, new Vector3(this.transform.position.x, 1, this.transform.position.z), Quaternion.identity);
            StartCoroutine("upmove");

        }
    }
    public IEnumerator nockback()
    {
        player.gameObject.GetComponent<Playertilemover>().input = false;
        player.gameObject.GetComponent<Playertilemover>().pusehd = true;
        attacked = true;
        fuel = fuel - 5;
        Vector3 startposs = player.transform.position;
        Vector3 endposs = player.transform.position - new Vector3(0, 0, 8);
        Vector3 saveposs1 = player.transform.position - new Vector3(0, 0, 0);
        Vector3 saveposs2 = player.transform.position - new Vector3(0, 0, 2);
        Vector3 saveposs3 = player.transform.position - new Vector3(0, 0, 4);
        Vector3 saveposs4 = player.transform.position - new Vector3(0, 0, 6);
        Vector3 saveposs = saveposs1;
        while (player.transform.position.z != endposs.z)
        {
            player.transform.position += (endposs - startposs) * Time.deltaTime * 1;
            yield return null;
            if(player.gameObject.GetComponent<Playertilemover>().hit == true)
            {
                endposs = saveposs;
                startposs = player.transform.position - new Vector3(0, 0, 8) ;
            }
            if (player.transform.position.z - saveposs2.z < 0.05)
            {
                saveposs = saveposs2;

            }
            if (player.transform.position.z - saveposs3.z < 0.05)
            {
                saveposs = saveposs3;

            }
            if (player.transform.position.z - saveposs4.z < 0.05)
            {
                saveposs = saveposs4;

            }
            if (Mathf.Abs(player.transform.position.z - endposs.z) < 0.05)
            {

                player.transform.position = endposs;
            }
        }
        player.gameObject.GetComponent<Playertilemover>().input = true;
        player.gameObject.GetComponent<Playertilemover>().pusehd = false;
        player.gameObject.GetComponent<Playertilemover>().hit = false;


    }
    public IEnumerator upmove()
    {

        Vector3 startposs = transform.position;
        Vector3 endposs = transform.position + new Vector3(0, 4, 0);
        while (transform.position.y != endposs.y)
        {
            transform.position += (endposs - startposs) * Time.deltaTime * 0.5F;
            yield return null;
            if (transform.position.y - endposs.y > 0.05)
            {
                transform.position = endposs;
            }
        }
        Destroy(this.gameObject,1.5F);

    }
}
