using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float speed;
    



    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Boundray")
        {
            transform.Translate(Vector2.down * .5f);
            speed *= -1;
            
        }
       
    }
}




