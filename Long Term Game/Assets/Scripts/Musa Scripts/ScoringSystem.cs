using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{

    private void Start()
    {
        StartCoroutine(PillLifeSpan());
    }

    IEnumerator PillLifeSpan()
    {
        yield return new WaitForSeconds(25f);
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
