using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public bool hit;
    public bool hiten;
    public HealthBar healthbar;
    public bool push;

    public GameObject pow;
    // Start is called before the first frame update
    void Start()
    {
        health = 20;
        healthbar.SetMaxHealth(health);

    }

    // Update is called once per frame
    void Update()
    {
        healthbar.SetHealth(health);

        if (health <= 0)
        {

            transform.position = new Vector3(-20, -20, -20);
            Destroy(this.gameObject,1);
        }
    }
    public IEnumerator pushdam()
    {
        health = health - 5;
        var newSquare = Instantiate(pow, new Vector3(this.transform.position.x, 2, this.transform.position.z-1f), Quaternion.identity);

        yield return null;

    }
    public IEnumerator stardam()
    {
        health = health - 4;
        var newSquare = Instantiate(pow, new Vector3(this.transform.position.x, 2, this.transform.position.z - 1f), Quaternion.identity);

        yield return null;

    }
    public IEnumerator bulletdam()
    {
        health = health - 4;
        var newSquare = Instantiate(pow, new Vector3(this.transform.position.x, 2, this.transform.position.z - 1f), Quaternion.identity);

        yield return null;

    }
    public IEnumerator hitdam()
    {
        health = health - 7;
        var newSquare = Instantiate(pow, new Vector3(this.transform.position.x, 2, this.transform.position.z - 1f), Quaternion.identity);

        yield return null;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Chesspeice"))
        {
            hit = true;
        }
        if (other.CompareTag("Enemy"))
        {
            hiten = true;
            hit = true;

        }
        if (other.CompareTag("bullet"))
        {
            StartCoroutine("bulletdam");
        }
        if (other.CompareTag("star"))
        {
            StartCoroutine("stardam");
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Chesspeice"))
        {
            hit = true;
        }
        if (other.CompareTag("Enemy"))
        {
            hiten = true;
            hit = true;

        }

    }
}
