using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;

    Animator anim;
    public GameObject player;
    PlayerHealth playerHealth;
    private EnemyHealth enemyHealth;
    bool playerInRange;
    float timer;
 
    void Awake()
    {
        
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        //anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Attack();
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = false;
        }
    }

    ////void Update()
    //{      
    //    if(playerInRange && enemyHealth.currentHealth > 0)
    //    {
    //        Attack();
    //    }

    //    if (playerHealth.currentHealth <= 0)
    //    {
    //        anim.SetTrigger("PlayerDead");
    //    }
    //}

    void Attack()
    {
        timer = 0f;

        if(playerHealth.currentHealth > 0)
        {
            NewMethod();
        }
    }

    private void NewMethod()
    {
        player.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
    }
}
