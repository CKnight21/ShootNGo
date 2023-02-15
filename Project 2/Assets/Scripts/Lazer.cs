using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            void OnTriggerEnter(Collider other)
            {
                if (other.CompareTag("Player"))
                {
                    other.GetComponent<EnemyHealth>().TakeDamage(1);
                }

            }

        }
        if (collision.gameObject.tag == "Boundray")
        {
            
            Destroy(gameObject);
        }
    }
}
