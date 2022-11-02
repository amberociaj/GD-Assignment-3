using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBurst : MonoBehaviour
{
    public GameObject burst;

    // Start is called before the first frame update
    void Start()
    {
        burst.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            burst.gameObject.SetActive(true);
            StartCoroutine(AttackBurst());
        }
    }

    IEnumerator AttackBurst()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
        }
    }
}
