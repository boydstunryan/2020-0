using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Light))]
public class LightControlScript : MonoBehaviour
{
    private Light lightobj;
    // Start is called before the first frame update
    void Start()
    {
        lightobj = GetComponent<Light>();
        lightobj.intensity = 0f;
    }

    private void OnEnable;
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
