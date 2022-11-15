using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 2;
    public PlayerHealth playerHealth;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("EnemyHit");
            playerHealth.TakeDamage(damage);

        }
    }


}
