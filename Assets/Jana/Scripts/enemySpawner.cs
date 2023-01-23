using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    private int enemiesNumber = 3;
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private GameObject enemyPrefab;
    private Vector3 spawnLocation;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = new Vector3(5.04f, 5.85f, 8.75f);
        for (int i = 0; i < enemiesNumber; i++)
        {
            Instantiate(enemyPrefab, spawnLocation, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
