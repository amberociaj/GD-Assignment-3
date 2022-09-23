using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public GameObject Gun;
    public GameObject impactEffect;

    float damageEnemy = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(Gun.transform.position, Gun.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);

            EnemyHealth enemyHealthScript = hit.transform.GetComponent<EnemyHealth>();
            enemyHealthScript.DeductHealth(damageEnemy);
            Debug.Log("Hit");
        }
    }
}
