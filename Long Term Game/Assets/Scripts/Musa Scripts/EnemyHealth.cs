using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHealth = 100f;
    public static bool enemyIsDead;


    void Start()
    {
        enemyIsDead = false;
    }

    public void DeductHealth(float deductHealth)
    {
        enemyHealth -= deductHealth;

        if(enemyHealth <= 0)
        {
            EnemyDead();
        }
    }

    public void EnemyDead()
    {
        enemyIsDead = true;
        Debug.Log("Deadz");
    }
}
