using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    public GameObject EndScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {

            EndScreen.SetActive(true);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
        
    }
}
