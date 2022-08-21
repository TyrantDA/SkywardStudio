    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rangedattackmove : MonoBehaviour
{
    public bool forward;
    public bool Back;
    public bool Left;
    public bool Right;

    public GameObject playerhold;
    public Playertilemover playervaluehold;
    public Tileholder Tiles;
    public GameObject[] Currentarray;

    public bool sight;
    public bool seen;
    public bool targeted;
    public int count;
    public bool attacking;
    public bool attacked;
    public bool pop;
    public bool pop2;

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
        count = 1;
        sight = true;

    }

    // Update is called once per frame
    void Update()
    { 
        if (playervaluehold.move != count && attacked == true)
        {
            if (pop == true)
            {
                pop2 = true;
            }
            attacked = false;
            attacking = false;
            pop = true;
            count = playervaluehold.move;
            Instantiate(bullet, transform.position, transform.rotation);
        }
        if (playervaluehold.move > count & targeted == false)
        {
            count = playervaluehold.move;
        }
        if (playervaluehold.move > count && targeted == true)
        {
            count = playervaluehold.move;

            attacking = true;
        }
        if (playerhold.transform.position.z != this.transform.position.z && playerhold.transform.position.x != this.transform.position.x)
        {
            targeted = false;
            attacking = false;
        }
        if (sight == false&& forward ==true&& attacked== false)
        {
            if (seen == false)
            {
                count = playervaluehold.move + 1;

                targeted = false;
                attacking = false;
            }
        }
        if (sight == false && Back == true && attacked == false)
        {
            if (seen == false)
            {
                count = playervaluehold.move + 1;

                targeted = false;
                attacking = false;
            }

        }
        if (playerhold.transform.position.x < this.transform.position.x && playerhold.transform.position.z == this.transform.position.z)
        {
            sight = true;

            if (this.transform.position.z == 1)
            {
                for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                {
                    if (Tiles.array1[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array1[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = 1; i < this.transform.position.x - 1; i++)
                    {
                        Tiles.array1[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 3)
            {
                for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                {
                    if (Tiles.array2[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array2[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = 1; i < this.transform.position.x - 1; i++)
                    {
                        Tiles.array2[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 5)
            {
                for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                {
                    if (Tiles.array3[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array3[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = 1; i < this.transform.position.x - 1; i++)
                    {
                        Tiles.array3[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 7)
            {
                for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                {
                    if (Tiles.array4[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array4[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = 1; i < this.transform.position.x - 1; i++)
                    {
                        Tiles.array4[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 9)
            {
                for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                {
                    if (Tiles.array5[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array5[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = 1; i < this.transform.position.x - 1; i++)
                    {
                        Tiles.array5[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 11)
            {
                for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                {
                    if (Tiles.array6[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array6[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = 1; i < this.transform.position.x - 1; i++)
                    {
                        Tiles.array6[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 13)
            {
                for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                {
                    if (Tiles.array7[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array7[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = 1; i < this.transform.position.x - 1; i++)
                    {
                        Tiles.array7[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 15)
            {
                for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                {
                    if (Tiles.array8[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array8[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = 1; i < this.transform.position.x - 1; i++)
                    {
                        Tiles.array8[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 17)
            {
                for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                {
                    if (Tiles.array9[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array9[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = -2; i < this.transform.position.x - 1; i++)
                    {
                        Tiles.array9[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (sight == true)
            {
                targeted = true;

                Left = true;
                Right = false;
                forward = false;
                Back = false;
            }


        }
        if (playerhold.transform.position.x > this.transform.position.x && playerhold.transform.position.z == this.transform.position.z)
        {
            sight = true;
            if (this.transform.position.z == 1)
            {
                for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                {
                    if (Tiles.array1[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array1[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 12; i++)
                    {
                        Tiles.array1[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 3)
            {
                for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                {
                    if (Tiles.array2[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array2[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 12; i++)
                    {
                        Tiles.array2[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 5)
            {
                for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                {
                    if (Tiles.array3[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array3[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 12; i++)
                    {
                        Tiles.array3[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 7)
            {
                for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                {
                    if (Tiles.array4[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array4[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 12; i++)
                    {
                        Tiles.array4[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 9)
            {
                for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                {
                    if (Tiles.array5[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array5[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 12; i++)
                    {
                        Tiles.array5[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 11)
            {
                for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                {
                    if (Tiles.array6[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array6[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 12; i++)
                    {
                        Tiles.array6[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 13)
            {
                for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                {
                    if (Tiles.array7[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array7[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 12; i++)
                    {
                        Tiles.array7[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 15)
            {
                for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                {
                    if (Tiles.array8[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array8[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 14; i++)
                    {
                        Tiles.array8[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (this.transform.position.z == 17)
            {
                for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                {
                    if (Tiles.array9[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true && Tiles.array9[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        i = i + 14;
                        sight = false;
                    }
                }
                if (sight == true)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 14; i++)
                    {
                        Tiles.array9[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    }
                }
            }
            if (sight == true)
            {
                targeted = true;

                Left = false;
                Right = true;
                forward = false;
                Back = false;
            }


        }
        if (playerhold.transform.position.z < this.transform.position.z && playerhold.transform.position.x == this.transform.position.x)
        {
            sight = true;
            seen = false;
            if (this.transform.position.z == 3)
            {
                if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }

                }
                if (sight == true || seen == true)
                {
                    Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                }
            }
            if (this.transform.position.z == 5)
            {
                if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (sight == true || seen == true)
                {
                    Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;

                }
            }
            if (this.transform.position.z == 7)
            {
                if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (sight == true || seen == true)
                {
                    Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;

                }
            }
            if (this.transform.position.z == 9)
            {
                if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (sight == true || seen == true)
                {
                    Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;

                }
            }
            if (this.transform.position.z == 11)
            {
                if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (sight == true || seen == true)
                {
                    Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;

                }
            }
            if (this.transform.position.z == 13)
            {
                if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (sight == true || seen == true)
                {
                    Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;

                }
            }
            if (this.transform.position.z == 15)
            {
                if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (sight == true || seen == true)
                {
                    Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;

                }
            }
            if (this.transform.position.z == 17)
            {
                if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {
                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (sight == true || seen == true)
                {
                    Tiles.arrayMIUS1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;

                    Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;

                }
            }
            if (sight == true || seen == true)
            {
                targeted = true;
                sight = true;

                seen = false;
                Left = false;
                Right = false;
                forward = true;
                Back = false;
            }
        }
        if (playerhold.transform.position.z > this.transform.position.z && playerhold.transform.position.x == this.transform.position.x)
        {
            sight = true;
            seen = false;
            print("heello");

            if (this.transform.position.z == 1)
            {
                if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (sight == true || seen == true)
                {
                    Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;


                }
            }
            if (this.transform.position.z == 3)
            {
                if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (sight == true || seen == true)
                {
                    Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;


                }
            }
            if (this.transform.position.z == 5)
            {
                if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (sight == true || seen == true)
                {
                    Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;


                }
            }
            if (this.transform.position.z == 7)
            {
                if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (sight == true || seen == true)
                {
                    Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;


                }
            }
            if (this.transform.position.z == 9)
            {
                if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (sight == true || seen == true)
                {
                    Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;


                }
            }
            if (this.transform.position.z == 11)
            {
                if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (sight == true || seen == true)
                {
                    Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;
                    Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;


                }
            }
            if (this.transform.position.z == 13)
            {
                if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                {

                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                    {
                        sight = false;

                    }
                    else
                    {
                        if (sight == true)
                        {
                            seen = true;
                        }

                    }
                }
                if (sight == true || seen == true)
                {
                    Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().target1 = true;


                }
            }
            if (sight == true || seen == true)
            {
                targeted = true;
                sight = true;

                seen = false;
                Left = false;
                Right = false;
                forward = false;
                Back = true;
            }

        }
        if (forward == true)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, 0f, transform.rotation.z);
        }
        if (Back == true)
        {


            transform.rotation = Quaternion.Euler(transform.rotation.x, 180f, transform.rotation.z);
        }
        if (Left == true)
        {

            transform.rotation = Quaternion.Euler(transform.rotation.x, 90f, transform.rotation.z);
        }
        if (Right == true)
        {

            transform.rotation = Quaternion.Euler(transform.rotation.x, 270f, transform.rotation.z);
        }



        if (attacking == true)

        {

            if (playerhold.transform.position.x < this.transform.position.x && playerhold.transform.position.z == this.transform.position.z)
            {
                sight = true;
                if (this.transform.position.z == 1)
                {
                    for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                    {
                        if (Tiles.array1[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = 1; i < this.transform.position.x - 1; i++)
                        {
                            Tiles.array1[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 3)
                {
                    for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                    {
                        if (Tiles.array2[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = 1; i < this.transform.position.x - 1; i++)
                        {
                            Tiles.array2[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 5)
                {
                    for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                    {
                        if (Tiles.array3[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = 1; i < this.transform.position.x - 1; i++)
                        {
                            Tiles.array3[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 7)
                {
                    for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                    {
                        if (Tiles.array4[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = 1; i < this.transform.position.x - 1; i++)
                        {
                            Tiles.array4[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 9)
                {
                    for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                    {
                        if (Tiles.array5[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = 1; i < this.transform.position.x - 1; i++)
                        {
                            Tiles.array5[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 11)
                {
                    for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                    {
                        if (Tiles.array6[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = 1; i < this.transform.position.x - 1; i++)
                        {
                            Tiles.array6[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 13)
                {
                    for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                    {
                        if (Tiles.array7[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = 1; i < this.transform.position.x - 1; i++)
                        {
                            Tiles.array7[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 15)
                {
                    for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                    {
                        if (Tiles.array8[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = 1; i < this.transform.position.x - 1; i++)
                        {
                            Tiles.array8[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 17)
                {
                    for (int i = Mathf.RoundToInt(playervaluehold.Starttile.x) + 1; i < this.transform.position.x - 1; i++)
                    {
                        if (Tiles.array9[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = -2; i < this.transform.position.x - 1; i++)
                        {
                            Tiles.array9[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (sight == true)
                {
                    attacked = true;

                    Left = true;
                    Right = false;
                    forward = false;
                    Back = false;
                }


            }
            if (playerhold.transform.position.x > this.transform.position.x && playerhold.transform.position.z == this.transform.position.z)
            {
                sight = true;
                if (this.transform.position.z == 1)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                    {
                        if (Tiles.array1[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 12; i++)
                        {
                            Tiles.array1[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 3)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                    {
                        if (Tiles.array2[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 12; i++)
                        {
                            Tiles.array2[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 5)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                    {
                        if (Tiles.array3[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 12; i++)
                        {
                            Tiles.array3[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 7)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                    {
                        if (Tiles.array4[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 12; i++)
                        {
                            Tiles.array4[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 9)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                    {
                        if (Tiles.array5[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 12; i++)
                        {
                            Tiles.array5[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 11)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                    {
                        if (Tiles.array6[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 12; i++)
                        {
                            Tiles.array6[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 13)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                    {
                        if (Tiles.array7[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 12; i++)
                        {
                            Tiles.array7[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 15)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                    {
                        if (Tiles.array8[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 14; i++)
                        {
                            Tiles.array8[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (this.transform.position.z == 17)
                {
                    for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < playervaluehold.Starttile.x - 1; i++)
                    {
                        if (Tiles.array9[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                        {
                            i = i + 14;
                            sight = false;
                        }
                    }
                    if (sight == true)
                    {
                        for (int i = Mathf.RoundToInt(this.transform.position.x) + 1; i < 14; i++)
                        {
                            Tiles.array9[Mathf.RoundToInt((i + 2) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        }
                    }
                }
                if (sight == true)
                {
                    attacked = true;

                    Left = false;
                    Right = true;
                    forward = false;
                    Back = false;
                }


            }
            if (playerhold.transform.position.z < this.transform.position.z && playerhold.transform.position.x == this.transform.position.x)
            {
                sight = true;
                seen = false;
                print("heello1");
                if (this.transform.position.z == 3)
                {
                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }

                    }
                    if (sight == true || seen == true)
                    {
                        Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                    }
                }
                if (this.transform.position.z == 5)
                {
                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (sight == true || seen == true)
                    {
                        Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;

                    }
                }
                if (this.transform.position.z == 7)
                {
                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (sight == true || seen == true)
                    {
                        Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;

                    }
                }
                if (this.transform.position.z == 9)
                {
                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (sight == true || seen == true)
                    {
                        Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;

                    }
                }
                if (this.transform.position.z == 11)
                {
                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (sight == true || seen == true)
                    {
                        Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;

                    }
                }
                if (this.transform.position.z == 13)
                {
                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (sight == true || seen == true)
                    {
                        Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;

                    }
                }
                if (this.transform.position.z == 15)
                {
                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (sight == true || seen == true)
                    {
                        Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;

                    }
                }
                if (this.transform.position.z == 17)
                {
                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {
                        if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (sight == true || seen == true)
                    {
                        Tiles.arrayMIUS1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;

                        Tiles.array1[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;

                    }
                }
                if (sight == true || seen == true)
                {
                    attacked = true;
                    sight = true;

                    seen = false;
                    Left = false;
                    Right = false;
                    forward = true;
                    Back = false;
                }
            }
            if (playerhold.transform.position.z > this.transform.position.z && playerhold.transform.position.x == this.transform.position.x)
            {
                sight = true;
                seen = false;

                if (this.transform.position.z == 1)
                {
                    if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (sight == true || seen == true)
                    {
                        Tiles.array2[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;


                    }
                }
                if (this.transform.position.z == 3)
                {
                    if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (sight == true || seen == true)
                    {
                        Tiles.array3[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;


                    }
                }
                if (this.transform.position.z == 5)
                {
                    if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (sight == true || seen == true)
                    {
                        Tiles.array4[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;


                    }
                }
                if (this.transform.position.z == 7)
                {
                    if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (sight == true || seen == true)
                    {
                        Tiles.array5[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;


                    }
                }
                if (this.transform.position.z == 9)
                {
                    if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (sight == true || seen == true)
                    {
                        Tiles.array6[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;


                    }
                }
                if (this.transform.position.z == 11)
                {
                    if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (sight == true || seen == true)
                    {
                        Tiles.array7[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;
                        Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;


                    }
                }
                if (this.transform.position.z == 13)
                {
                    if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().ocupided == true)
                    {

                        if (Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().hasplayer == false)
                        {
                            sight = false;

                        }
                        else
                        {
                            if (sight == true)
                            {
                                seen = true;
                            }

                        }
                    }
                    if (sight == true || seen == true)
                    {
                        Tiles.array8[Mathf.RoundToInt((transform.position.x + 1) / 2)].GetComponent<Tilechangerwalk>().attack = true;


                    }
                }
                if (sight == true || seen == true)
                {
                    sight = true;

                    attacked = true;
                    seen = false;
                    Left = false;
                    Right = false;
                    forward = false;
                    Back = true;
                }

            }
            if (forward == true)
            {

                transform.rotation = Quaternion.Euler(transform.rotation.x, 0f, transform.rotation.z);
            }
            if (Back == true)
            {
                transform.rotation = Quaternion.Euler(transform.rotation.x, 180f, transform.rotation.z);
            }
            if (Left == true)
            {
                transform.rotation = Quaternion.Euler(transform.rotation.x, 90f, transform.rotation.z);
            }
            if (Right == true)
            {
                transform.rotation = Quaternion.Euler(transform.rotation.x, 270f, transform.rotation.z);
            }
        }

    }
}
