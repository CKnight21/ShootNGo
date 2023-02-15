using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    [SerializeField] private Health enemyHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currentHealthBar;

    private void Start()
    {
        totalhealthBar.fillAmount = enemyHealth.currentHealth / 1;
    }
    private void Update()
    {
        currentHealthBar.fillAmount = enemyHealth.currentHealth / 10;
    }
}
