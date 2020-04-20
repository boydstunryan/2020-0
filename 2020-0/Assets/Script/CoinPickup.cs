using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    public int coinValue;
   
    private void OnTriggerEnter(Collider other)
    {
        print("Youve collect the coin!!");

        ScoreManager.AddPoints(coinValue);

        if (other.GetComponent<PlayerHealth>())
        {
            other.GetComponent<PlayerHealth>().Heal();
        }

        Destroy(gameObject);
    }
}
