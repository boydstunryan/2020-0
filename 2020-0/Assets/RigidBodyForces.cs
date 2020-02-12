using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyForces : MonoBehaviour
{
    public Rigidbody rigidBodyObj;
    public float force = 100;
    private Vector3 forceVector = new Vector3();
 
    private void OnCollisionEnter(Collision other)
    {
        forceVector.y = force;
        rigidBodyObj.AddExplosionForce(forceVector);
    }

}
