using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private GameObject healthPrefab;
    public float coinDropChance = 0.3f;
    public float heartDropChance = 0.1f;

    public void DropItems()
    {
        float rnd = Random.Range(0f, 1f);

        if (rnd <= coinDropChance)
        {
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
        }

        if(rnd <= heartDropChance){
            Instantiate(healthPrefab, transform.position, Quaternion.identity);
        }
    }
}
