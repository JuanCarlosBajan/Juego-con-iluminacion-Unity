using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Character : MonoBehaviour
{

    public Text texto;
    public GameObject panel;
    Light light;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {

        light = gameObject.GetComponent<Light>();
        audio = gameObject.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {

        Ray myray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f));
        RaycastHit hitinfo;

        if (Input.GetMouseButtonDown(0)){
            audio.Play();
            if (light.intensity > 0)
            {

                light.intensity = 0;
                
            }
            else {

                light.intensity = 10;
            }
        }

        if (Physics.Raycast(myray, out hitinfo) && hitinfo.collider.gameObject.CompareTag("ReadableObject"))
        {
            panel.SetActive(true);
            texto.gameObject.SetActive(true);
            texto.enabled = true;
            texto.text = hitinfo.collider.name;
        }
        else {
            panel.SetActive(false);
            texto.gameObject.SetActive(false);
            texto.text = "";

        }

    }


}
