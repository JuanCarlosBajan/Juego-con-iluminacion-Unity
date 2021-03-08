using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMesh : MonoBehaviour
{

    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (light.gameObject.activeSelf == true) {

            light.intensity =  Mathf.Abs(Mathf.Sin(Time.time)) * 40;

        }
        
    }


    private void OnTriggerEnter(Collider other)
    {
        light.gameObject.SetActive(true);
        
    }
}
