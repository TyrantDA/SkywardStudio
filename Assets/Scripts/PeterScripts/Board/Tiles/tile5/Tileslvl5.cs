using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tileslvl5 : MonoBehaviour
{
    public Playertilemover playhold;
    public Tileholder tiles;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playhold.move == 1)
        {
            foreach (GameObject i in tiles.arrayMIUS1)
            {
                i.GetComponent<Tilechangerwalk>().attack = true;
            }
            foreach (GameObject i in tiles.array2)
            {
                i.GetComponent<Tilechangerwalk>().attack = true;
            }
            foreach (GameObject i in tiles.array4)
            {
                i.GetComponent<Tilechangerwalk>().attack = true;
            }
            foreach (GameObject i in tiles.array6)
            {
                i.GetComponent<Tilechangerwalk>().attack = true;
            }
            foreach (GameObject i in tiles.array8)
            {
                i.GetComponent<Tilechangerwalk>().attack = true;
            }
        }
        if (playhold.move == 2)
        {
            foreach (GameObject i in tiles.arrayMIUS1)
            {
                i.GetComponent<Tilechangerwalk>().attacking = true;
            }
            foreach (GameObject i in tiles.array2)
            {
                i.GetComponent<Tilechangerwalk>().attacking = true;
            }
            foreach (GameObject i in tiles.array4)
            {
                i.GetComponent<Tilechangerwalk>().attacking = true;
            }
            foreach (GameObject i in tiles.array6)
            {
                i.GetComponent<Tilechangerwalk>().attacking = true;
            }
            foreach (GameObject i in tiles.array8)
            {
                i.GetComponent<Tilechangerwalk>().attacking = true;
            }


            foreach (GameObject i in tiles.array1)
            {
                i.GetComponent<Tilechangerwalk>().attack = true;
            }
            foreach (GameObject i in tiles.array3)
            {
                i.GetComponent<Tilechangerwalk>().attack = true;
            }
            foreach (GameObject i in tiles.array5)
            {
                i.GetComponent<Tilechangerwalk>().attack = true;
            }
            foreach (GameObject i in tiles.array7)
            {
                i.GetComponent<Tilechangerwalk>().attack = true;
            }
            foreach (GameObject i in tiles.array9)
            {
                i.GetComponent<Tilechangerwalk>().attack = true;
            }
        }
        if (playhold.move == 3)
        {
            foreach (GameObject i in tiles.arrayMIUS1)
            {
                i.GetComponent<Tilechangerwalk>().attacking = false;
            }
            foreach (GameObject i in tiles.array2)
            {
                i.GetComponent<Tilechangerwalk>().attacking = false;
            }
            foreach (GameObject i in tiles.array4)
            {
                i.GetComponent<Tilechangerwalk>().attacking = false;
            }
            foreach (GameObject i in tiles.array6)
            {
                i.GetComponent<Tilechangerwalk>().attacking = false;
            }
            foreach (GameObject i in tiles.array8)
            {
                i.GetComponent<Tilechangerwalk>().attacking = false;
            }


            foreach (GameObject i in tiles.array1)
            {
                i.GetComponent<Tilechangerwalk>().attacking = true;
            }
            foreach (GameObject i in tiles.array3)
            {
                i.GetComponent<Tilechangerwalk>().attacking = true;
            }
            foreach (GameObject i in tiles.array5)
            {
                i.GetComponent<Tilechangerwalk>().attacking = true;
            }
            foreach (GameObject i in tiles.array7)
            {
                i.GetComponent<Tilechangerwalk>().attacking = true;
            }
            foreach (GameObject i in tiles.array9)
            {
                i.GetComponent<Tilechangerwalk>().attacking = true;
            }
        }
        if (playhold.move == 4)
        {
            foreach (GameObject i in tiles.array1)
            {
                i.GetComponent<Tilechangerwalk>().attacking = false;
            }
            foreach (GameObject i in tiles.array3)
            {
                i.GetComponent<Tilechangerwalk>().attacking = false;
            }
            foreach (GameObject i in tiles.array5)
            {
                i.GetComponent<Tilechangerwalk>().attacking = false;
            }
            foreach (GameObject i in tiles.array7)
            {
                i.GetComponent<Tilechangerwalk>().attacking = false;
            }
            foreach (GameObject i in tiles.array9)
            {
                i.GetComponent<Tilechangerwalk>().attacking = false;
            }


            for (int i = 0; i < 8; i = i + 2)
            {
                tiles.arrayMIUS1[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array1[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array2[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array3[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array4[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array5[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array6[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array7[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array8[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array9[i].GetComponent<Tilechangerwalk>().attack = true;

            }



        }
        if (playhold.move == 5)
        {

            for (int i = 0; i < 8; i = i + 2)
            {
                tiles.arrayMIUS1[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array1[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array2[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array3[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array4[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array5[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array6[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array7[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array8[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array9[i].GetComponent<Tilechangerwalk>().attacking = true;

            }


            for (int i = 1; i < 8; i = i + 2)
            {
                tiles.arrayMIUS1[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array1[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array2[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array3[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array4[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array5[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array6[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array7[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array8[i].GetComponent<Tilechangerwalk>().attack = true;
                tiles.array9[i].GetComponent<Tilechangerwalk>().attack = true;

            }



        }
        if (playhold.move == 6)
        {
            for (int i = 0; i < 8; i = i + 2)
            {
                tiles.arrayMIUS1[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array1[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array2[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array3[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array4[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array5[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array6[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array7[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array8[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array9[i].GetComponent<Tilechangerwalk>().attacking = false;

            }
            for (int i = 1; i < 8; i = i + 2)
            {
                tiles.arrayMIUS1[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array1[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array2[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array3[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array4[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array5[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array6[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array7[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array8[i].GetComponent<Tilechangerwalk>().attacking = true;
                tiles.array9[i].GetComponent<Tilechangerwalk>().attacking = true;

            }



        }
        if (playhold.move == 7)
        {

            for (int i = 1; i < 8; i = i + 2)
            {
                tiles.arrayMIUS1[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array1[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array2[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array3[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array4[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array5[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array6[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array7[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array8[i].GetComponent<Tilechangerwalk>().attacking = false;
                tiles.array9[i].GetComponent<Tilechangerwalk>().attacking = false;

            }

            tiles.array3[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array3[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array7[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array7[4].GetComponent<Tilechangerwalk>().attack = true;


        }
        if (playhold.move == 8)
        {


            tiles.array3[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array3[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array7[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array7[4].GetComponent<Tilechangerwalk>().attacking = true;

            tiles.array3[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array3[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[5].GetComponent<Tilechangerwalk>().attack = true;


            tiles.array7[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array7[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array6[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array6[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array6[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array6[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[5].GetComponent<Tilechangerwalk>().attack = true;
        }
        if (playhold.move == 9)
        {


            tiles.array3[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array3[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array7[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array7[4].GetComponent<Tilechangerwalk>().attacking = false;

            tiles.array3[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array3[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[5].GetComponent<Tilechangerwalk>().attacking = true;


            tiles.array7[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array7[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array6[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array6[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array6[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array6[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[5].GetComponent<Tilechangerwalk>().attacking = true;

            tiles.array3[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array3[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array1[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array1[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array1[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array1[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array1[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array1[6].GetComponent<Tilechangerwalk>().attack = true;

            tiles.array5[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array5[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array5[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array5[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array5[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array5[6].GetComponent<Tilechangerwalk>().attack = true;

            tiles.array7[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array7[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array6[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array6[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[6].GetComponent<Tilechangerwalk>().attack = true;
        }
        if (playhold.move == 10)
        {
            tiles.array3[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array3[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[5].GetComponent<Tilechangerwalk>().attacking = false;


            tiles.array7[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array7[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[5].GetComponent<Tilechangerwalk>().attacking = false;

            tiles.array3[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array3[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array1[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array1[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array1[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array1[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array1[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array1[6].GetComponent<Tilechangerwalk>().attacking = true;

            tiles.array5[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array5[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array5[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array5[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array5[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array5[6].GetComponent<Tilechangerwalk>().attacking = true;

            tiles.array7[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array7[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array6[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array6[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[6].GetComponent<Tilechangerwalk>().attacking = true;

            tiles.arrayMIUS1[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.arrayMIUS1[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.arrayMIUS1[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.arrayMIUS1[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.arrayMIUS1[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.arrayMIUS1[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.arrayMIUS1[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.arrayMIUS1[7].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array9[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array9[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array9[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array9[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array9[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array9[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array9[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array9[7].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array1[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array3[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array5[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array6[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array7[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array1[7].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[7].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array3[7].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[7].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array5[7].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array6[7].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array7[7].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[7].GetComponent<Tilechangerwalk>().attack = true;



        }
        if (playhold.move == 11)
        {
            tiles.array7[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array7[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[5].GetComponent<Tilechangerwalk>().attacking = false;

            tiles.array3[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array3[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array1[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array1[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array1[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array1[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array1[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array1[6].GetComponent<Tilechangerwalk>().attacking = false;

            tiles.array5[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array5[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array5[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array5[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array5[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array5[6].GetComponent<Tilechangerwalk>().attacking = false;

            tiles.array7[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array7[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[6].GetComponent<Tilechangerwalk>().attacking = false;

            tiles.arrayMIUS1[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.arrayMIUS1[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.arrayMIUS1[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.arrayMIUS1[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.arrayMIUS1[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.arrayMIUS1[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.arrayMIUS1[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.arrayMIUS1[7].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array9[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array9[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array9[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array9[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array9[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array9[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array9[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array9[7].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array1[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array3[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array5[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array6[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array7[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array1[7].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[7].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array3[7].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[7].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array5[7].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array6[7].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array7[7].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[7].GetComponent<Tilechangerwalk>().attacking = true;

        }
        if (playhold.move == 12)
        {
            tiles.arrayMIUS1[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.arrayMIUS1[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.arrayMIUS1[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.arrayMIUS1[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.arrayMIUS1[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.arrayMIUS1[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.arrayMIUS1[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.arrayMIUS1[7].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array9[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array9[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array9[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array9[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array9[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array9[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array9[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array9[7].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array1[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array3[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array5[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array7[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array1[7].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[7].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array3[7].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[7].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array5[7].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[7].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array7[7].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[7].GetComponent<Tilechangerwalk>().attacking = false;

            tiles.array9[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array9[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array9[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array9[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array9[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array9[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array9[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array9[7].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array8[7].GetComponent<Tilechangerwalk>().attack = true;
        }
        if (playhold.move == 13)
        {

            tiles.array9[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array9[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array9[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array9[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array9[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array9[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array9[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array9[7].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array8[7].GetComponent<Tilechangerwalk>().attacking = true;


            tiles.array6[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array6[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array6[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array6[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array6[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array6[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array6[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array6[7].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array7[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array7[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array7[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array7[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array7[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array7[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array7[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array7[7].GetComponent<Tilechangerwalk>().attack = true;
        }
        if (playhold.move == 14)
        {

            tiles.array9[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array9[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array9[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array9[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array9[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array9[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array9[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array9[7].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array8[7].GetComponent<Tilechangerwalk>().attacking = false;


            tiles.array6[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array6[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array6[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array6[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array6[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array6[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array6[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array6[7].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array7[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array7[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array7[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array7[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array7[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array7[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array7[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array7[7].GetComponent<Tilechangerwalk>().attacking = true;

            tiles.array5[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array5[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array5[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array5[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array5[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array5[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array5[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array5[7].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array4[7].GetComponent<Tilechangerwalk>().attack = true;
        }
        if (playhold.move == 15)
        {

            tiles.array7[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array7[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array7[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array7[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array7[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array7[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array7[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array7[7].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array6[7].GetComponent<Tilechangerwalk>().attacking = false;


            tiles.array5[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array5[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array5[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array5[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array5[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array5[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array5[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array5[7].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array4[7].GetComponent<Tilechangerwalk>().attacking = true;

            tiles.array3[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array3[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array3[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array3[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array3[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array3[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array3[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array3[7].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array2[7].GetComponent<Tilechangerwalk>().attack = true;
        }
        if (playhold.move == 16)
        {

            tiles.array5[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array5[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array5[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array5[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array5[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array5[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array5[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array5[7].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array4[7].GetComponent<Tilechangerwalk>().attacking = false;


            tiles.array3[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array3[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array3[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array3[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array3[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array3[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array3[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array3[7].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array2[7].GetComponent<Tilechangerwalk>().attacking = true;

            tiles.array1[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array1[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array1[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array1[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array1[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array1[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array1[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.array1[7].GetComponent<Tilechangerwalk>().attack = true;
            tiles.arrayMIUS1[0].GetComponent<Tilechangerwalk>().attack = true;
            tiles.arrayMIUS1[1].GetComponent<Tilechangerwalk>().attack = true;
            tiles.arrayMIUS1[2].GetComponent<Tilechangerwalk>().attack = true;
            tiles.arrayMIUS1[3].GetComponent<Tilechangerwalk>().attack = true;
            tiles.arrayMIUS1[4].GetComponent<Tilechangerwalk>().attack = true;
            tiles.arrayMIUS1[5].GetComponent<Tilechangerwalk>().attack = true;
            tiles.arrayMIUS1[6].GetComponent<Tilechangerwalk>().attack = true;
            tiles.arrayMIUS1[7].GetComponent<Tilechangerwalk>().attack = true;
        }
        if (playhold.move == 17)
        {


            tiles.array3[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array3[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array3[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array3[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array3[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array3[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array3[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array3[7].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array2[7].GetComponent<Tilechangerwalk>().attacking = false;

            tiles.array1[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array1[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array1[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array1[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array1[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array1[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array1[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.array1[7].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.arrayMIUS1[0].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.arrayMIUS1[1].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.arrayMIUS1[2].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.arrayMIUS1[3].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.arrayMIUS1[4].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.arrayMIUS1[5].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.arrayMIUS1[6].GetComponent<Tilechangerwalk>().attacking = true;
            tiles.arrayMIUS1[7].GetComponent<Tilechangerwalk>().attacking = true;
        }
        if (playhold.move == 17)
        {


            tiles.array1[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array1[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array1[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array1[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array1[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array1[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array1[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.array1[7].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.arrayMIUS1[0].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.arrayMIUS1[1].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.arrayMIUS1[2].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.arrayMIUS1[3].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.arrayMIUS1[4].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.arrayMIUS1[5].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.arrayMIUS1[6].GetComponent<Tilechangerwalk>().attacking = false;
            tiles.arrayMIUS1[7].GetComponent<Tilechangerwalk>().attacking = false;
        }
    }
}
