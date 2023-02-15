using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLazer : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Boundray")
        {
            Destroy(gameObject);
        }

        if (collision.CompareTag("Player"))
        {
           collision.GetComponent<Health>().TakeDamage(1);
            Destroy(gameObject);
        }
    }
    
}
