using System;
using System.Collections;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectile;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(projectile, firePoint.position, Quaternion.identity);
            anim.SetTrigger("isAttacking");
        }
    }

    
}
