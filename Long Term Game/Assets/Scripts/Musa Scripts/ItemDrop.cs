using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public GameObject[] itemList;
    private int itemIndex;
    private int totalItemsInArray = 0;
    private Transform enemyPos;

    // Start is called before the first frame update
    private void Start()
    {
        foreach(GameObject item in itemList)
        {
            totalItemsInArray++;
        }
        itemIndex = Random.Range(0, totalItemsInArray);
    }

    // Update is called once per frame
    private void Update()
    {
        if(EnemyHealth.enemyIsDead == true)
        {
            DropItem();
            Destroy(gameObject);
        }
    }

    void DropItem()
    {
        EnemyHealth.enemyIsDead = false;
        enemyPos = GetComponent<Transform>().transform;
        Instantiate(itemList[itemIndex], enemyPos.position, Quaternion.identity);
    }
}
