using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float horizontalInput;
    float verticalInput;
    
    

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);

        verticalInput = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector2.up * verticalInput * speed * Time.deltaTime);
    }
}
