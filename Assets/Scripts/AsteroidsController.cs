using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsController : MonoBehaviour
{
    public float speed_min;
    public float speed_max;
    public float size = 1f;
    Rigidbody2D rb;
    public AsteroidManager manager;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        direction = direction * Random.Range(speed_min, speed_max);
        Debug.Log(direction);
        rb.AddForce(direction);
        manager.asteroids += 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Death()
    {
        if (transform.localScale.x > 0.25f)
        {
            GameObject temp1 = Instantiate(manager.asteroid, transform.position, transform.rotation);
            temp1.GetComponent<AsteroidsController>().manager = manager;
            temp1.transform.localScale = transform.localScale * 0.5f;

            GameObject temp2 = Instantiate(manager.asteroid, transform.position, transform.rotation);
            temp2.GetComponent<AsteroidsController>().manager = manager;
            Destroy(gameObject);
            temp2.transform.localScale = transform.localScale * 0.5f;
        }
        GameManager.instance.points += 100;
        manager.asteroids -= 1;
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<MovementCharacter>().Death();
        }

    }
}
