using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour

{
    public int maxHealth;
    public int currentHealth;
    private GameObject playerWeapon;
    public SwordHitbox sword;
    private int damage;

    //public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        playerWeapon = GameObject.FindGameObjectWithTag("Weapon");
        damage = sword.swordDamage;
        //healthBar.SetMaxHealth(maxHealth);

    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == playerWeapon)
        {
            TakeDamage(damage);
            Debug.Log("Sword hit an enemy");
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
        //healthBar.SetHealth(currentHealth);
    }
}
