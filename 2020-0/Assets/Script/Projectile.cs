using System.Collections;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;

    public float timeOut;

    public GameObject player;

    public GameObject enemyDeath;

    public GameObject projectileParticle;

    public int pointsForKill;
    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.Find("Player");

        // print(player);

        //enemyDeath = Resources.Load("Prefabs/PS") as GameObject;

        if (player.transform.localScale.x < 0)
        { 
        speed = -speed;
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
       // print(speed);

        Destroy(gameObject, timeOut);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime,0,0);
        //GetComponent<Rigidbody>().velocity = new Vector3(speed, GetComponent<Rigidbody>().velocity.y,0);
       // print(GetComponent<Rigidbody>().velocity);
       // print(transform.rotation);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            print("Entering Trigger!" + other.gameObject);
            //Instantiate(enemyDeath, other.transform.position, other.transform.rotation);
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
