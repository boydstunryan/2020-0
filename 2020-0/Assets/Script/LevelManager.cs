﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckPoint;
    private Rigidbody2D pcRigid;

    private GameObject player;

    public GameObject deathParticle;
    public GameObject respawnParticle;

    public float respawnDelay;

    public int pointPenaltyOnDeath;

    private float gravityStore;
    //private Object respawnParticle;

    // Start is called before the first frame update
    void Start()
    {
        //pcRigid = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }
    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo()
    {
        Instantiate(deathParticle, player.transform.position, player.transform.rotation);
        player.SetActive(false);
        player.GetComponent<Renderer>().enabled = false;
        //gravityStore = pcRigid.GetComponent<Rigidbody2D>().gravityScale;
       // pcRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;
        //pcRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        ScoreManager.AddPoints(-pointPenaltyOnDeath);
        Debug.Log("PC Respawn");
        yield return new WaitForSeconds(respawnDelay);
        //  pcRigid.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        // pcRigid.transform.position = currentCheckPoint.transform.position;
        player.transform.position = currentCheckPoint.transform.position;
        player.GetComponent<PlayerHealth>().currentHealth = 80;
        player.GetComponent<PlayerHealth>().Heal();
        player.SetActive(true);
        player.GetComponent<Renderer>().enabled = true;
        Instantiate(respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);
    }
}
