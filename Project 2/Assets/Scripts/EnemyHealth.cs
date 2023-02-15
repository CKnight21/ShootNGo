using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }


    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {

        }
        else
        {
           Destroy(gameObject);
           
        }
        //
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Lazer"))
            {
                other.GetComponent<EnemyHealth>().TakeDamage(1);
            }

        }
    }
}
