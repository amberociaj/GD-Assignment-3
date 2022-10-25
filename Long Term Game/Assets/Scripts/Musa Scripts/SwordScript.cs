using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    [SerializeField]
    float damageEnemy = 10f;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            EnemyHealth enemyHealthScript = col.transform.GetComponent<EnemyHealth>();
            enemyHealthScript.DeductHealth(damageEnemy);
            Debug.Log("Hit");
        }
    }
}
