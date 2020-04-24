using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    public int coinValue;
   
    private void OnTriggerEnter(Collider other)
    {
        

        if (other.GetComponent<PlayerHealth>())
        {
            other.GetComponent<PlayerHealth>().Heal();

            print("Youve collect the coin!!");

            ScoreManager.AddPoints(coinValue);

            Destroy(gameObject);
        }

        
    }
}
