using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public float flashSpeed = 5f;
    public Color flashColor = new Color(1f, 0f, 0f, 0.1f);
    public LevelManager levelManager;

    Animator anim;
    PlayerController playerController;
    PlayerShoot playerShoot;
    bool isDead;
    bool damaged;

    // Start is called before the first frame update
    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerController = GetComponent<PlayerController>();
        playerShoot = GetComponentInChildren<PlayerShoot>();

        currentHealth = startingHealth;
    }

    // Update is called once per frame
    //private void Update()
    //{
    //    if (damaged)
    //    {
    //        damageImage.color = flashColor;
    //    }

    //    else
    //    {
    //        damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
    //    }

    //    damaged = false;
    //}

    public void TakeDamage (int amount)
    {
        damaged = true;

        currentHealth -= amount;
        print(currentHealth / 100);

        healthSlider.value = (float)currentHealth / 100;

        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }

    public void Heal()
    {
        currentHealth += 20;
        healthSlider.value = (float)currentHealth / 100;
    }


    void Death()
    {
        isDead = true;

        //playerShoot.DestroyFinishedParticle();

        //anim.SetTrigger("die");

        levelManager.RespawnPlayer();
       // playerController.enabled = false;
       // playerShoot.enabled = false;
    }
}
