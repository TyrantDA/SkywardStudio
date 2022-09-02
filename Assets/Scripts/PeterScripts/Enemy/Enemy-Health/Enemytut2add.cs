using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemytut2add : MonoBehaviour
{
    public EnemyHealth hold;
    public bool firsttime;
    public bool secondtime;

    // Start is called before the first frame update
    void Start()
    {
        firsttime = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (hold.health <= 19)
        {
            if (firsttime == true)
            {
                firsttime = false;

                StartCoroutine("moveup");

            }
            if (secondtime == true)
            {
              //  this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, 1, this.gameObject.transform.position.z);
                this.gameObject.GetComponent<EnemyLeftrightpatrol>().enabled = true;

            }

        }
    }
    public IEnumerator moveup()
    {
        Vector3 startposs = this.gameObject.transform.position;
        Vector3 endposs = this.gameObject.transform.position + new Vector3(0, 0.5f, 0);
        while (this.gameObject.transform.position.y != endposs.y)
        {
            this.gameObject.transform.position += (endposs - startposs) * Time.deltaTime * 5;
            yield return null;

            if (Mathf.Abs(this.gameObject.transform.position.y - endposs.y) < 0.05)
            {

                this.gameObject.transform.position = endposs;
                secondtime = true;
            }
        }
    }
}


