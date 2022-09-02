using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tilechangerwalk : MonoBehaviour
{

    public Material Material1;
    public Material Material2;
    public Material Material3;
    public Material Material4;
    public Material Material5;

    public GameObject player;
    public GameObject inside;
    public Playertilemover Playermover;
    public int counter;
    public bool ocupided;
    public bool target;
    public bool target1;

    public bool hasplayer;
    public bool attack;
    public bool attacking;


    //in the editor this is what you would set as the object you wan't to change

    void Start()
    {
        counter = 0;
        ocupided = false;
        this.GetComponent<MeshRenderer>().material = Material1;
    }
    private void OnTriggerStay(Collider other)
    {
        ocupided = true;
        if(other.tag == "Player")
        {
            hasplayer = true;
        }
        inside = other.gameObject;
        if (target == false)
        {
            this.GetComponent<MeshRenderer>().material = Material2;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        hasplayer = false;

        ocupided = false;
        inside = null;
        if (target == false)
        {
            this.GetComponent<MeshRenderer>().material = Material1;
        }
    }
    void Update()
    {
        if (Input.GetAxis("Crossup") != 0)
        {
            target = false;
            counter = counter - 1;
        }
        if (Input.GetAxis("Crossside") != 0)
        {
            target = false;
            counter = counter - 1;

        }
        if (Playermover.Slashcango == false&& Playermover.bashcango == false && Playermover.hitcango == false && Playermover.Fireballcango == false&&target==true)
        {
            target = false;
            this.GetComponent<MeshRenderer>().material = Material1;

        }
        if (target == true)
        {
            this.GetComponent<MeshRenderer>().material = Material3;

        }
        if (target1 == true)
        {
            this.GetComponent<MeshRenderer>().material = Material3;

        }
        if (attack == true)
        {
            this.GetComponent<MeshRenderer>().material = Material4;

        }

        if (counter!= Playermover.move && ocupided == false && hasplayer == false)
        {
            attack = false;
            counter = Playermover.move;
            target = false;
            target1 = false;
            attacking = false;

            this.GetComponent<MeshRenderer>().material = Material1;

        }
        if (counter != Playermover.move && ocupided == true && hasplayer == true)
        {
            attack = false;
            attacking = false;

            counter = Playermover.move;
            target = false;
            target1 = false;

            this.GetComponent<MeshRenderer>().material = Material1;

        }
        if (counter != Playermover.move && ocupided == true && hasplayer == false)
        {
            attack = false;
            attacking = false;

            counter = Playermover.move;
            target = false;
            target1 = false;

            this.GetComponent<MeshRenderer>().material = Material2;

        }
        if(attacking == true)
        {
            this.GetComponent<MeshRenderer>().material = Material5;

        }


        //     if (player.GetComponent<Playertilemover>().targeting == false)
        //   {
        //      target = false;
        //       if (ocupided == false)
        //      {
        //          this.GetComponent<MeshRenderer>().material = Material1;
        //      }
        // }
    }

}
