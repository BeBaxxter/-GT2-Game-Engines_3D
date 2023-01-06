using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHitbox : MonoBehaviour
{
    [SerializeField] int swordDamage = 1;
    private GameObject enemy;

    private void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == enemy)
        {
            Debug.Log("Sword hit an enemy");

        }
    }


}
