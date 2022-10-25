using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    [SerializeField]
    float damageEnemy = 10f;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            EnemyHealth enemyHealthScript = collision.transform.GetComponent<EnemyHealth>();
            enemyHealthScript.DeductHealth(damageEnemy);
            Debug.Log("Hit");
        }
    }
}
