using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    public float dropChance = 0.3f;

    public void DropItems()
    {
        float rnd = Random.Range(0f, 1f);

        if (rnd <= dropChance)
        {
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
        }
    }
}
