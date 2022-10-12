using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject coinPrefab;

    void Start()
    {
  
  
        SpawnCoin();
        SpawnCoin();
    }

    // Update is called once per frame
    private void SpawnCoin()
    {
        int xPosi = Random.Range(-5, 5);
        int yPosi = Random.Range(-5, 5);
        int zPosi = Random.Range(-5, 5);

        Instantiate(coinPrefab,new Vector3 (xPosi, yPosi, zPosi), Quaternion.identity);
    }
}
