using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;
    public AudioSource collectSound;

    private void Start()
    {
        StartCoroutine(PillLifeSpan());
    }

    IEnumerator PillLifeSpan()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        theScore += 50;
        scoreText.GetComponent<Text>().text = "ORBS: " + theScore;
        Destroy(gameObject);
    }
}
