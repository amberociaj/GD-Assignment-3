using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript2 : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Hit");
        }
    }
}
