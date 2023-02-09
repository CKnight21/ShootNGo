using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingFromShip : MonoBehaviour
{
    public GameObject LazerPreFab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Instantiate             (LazerPreFab, transform.position, Quaternion.identity);
  //tells unity to spawn an object /the object  /spwans on the main ojbect  /keeps all roatation the same
  //                                            /in this case the ship
            
        }
    }
}
