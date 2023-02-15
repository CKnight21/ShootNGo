using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBossShot : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyBoss"))
        {
            other.GetComponent<EnemyHealth>().TakeDamage(1);
        }

    }
}
