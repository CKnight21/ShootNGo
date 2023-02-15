using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    public int hearts = 3;
    public Image[] heartsUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject);

            hearts -= 1;

            for(int i = 0; i < heartsUI.Length; i++)
            {
                if(i < hearts)
                {
                    heartsUI[i].enabled = true; //if this many lives are currently active enable the player image
                }
                else
                {
                    heartsUI[i].enabled = false;
                }
            }
            if(hearts <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
