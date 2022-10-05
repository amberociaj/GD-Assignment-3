using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHealth = 100f;

    public GameObject Orb;

    public void DeductHealth(float deductHealth)
    {
        enemyHealth -= deductHealth;

        if(enemyHealth <= 0)
        {
            EnemyDead();
        }
    }

    void EnemyDead()
    {
        Destroy(gameObject);
        Orb.SetActive(true);
    }
}
