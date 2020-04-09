using System.Collections;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;

    public float timeOut;

    public GameObject player;

    public GameObject enemyDeath;

    public GameObject projectileParticle;

    public int pointsForKill
    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.Find("Player");

        enemyDeath = Resources.Load("Prefabs/PS") as GameObject;

        if (player.transform.localScale.x < 0)
            speed = -speed;

        Destroy(gameObject, timeOut);
    }

    // Update is called once per frame
    private void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector2(speed, GetComponent<Rigidbody>().velocity.y);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            print("Entering Trigger!" + other.gameObject);
            Instantiate(enemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            ScoreManager.AddPoints(pointsForKill);
        }

        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision other)
    {
        print("Hitting Collider!" + other.gameObject);
        Instantiate(projectileParticle, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
