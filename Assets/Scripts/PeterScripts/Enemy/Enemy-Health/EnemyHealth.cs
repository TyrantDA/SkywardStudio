using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            transform.position = new Vector3(-20, -20, -20);
            Destroy(this.gameObject,1);
        }
    }
    public IEnumerator Fireballdam()
    {
        health = health - 1;

        yield return null;

    }
}
