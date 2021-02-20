using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c2change : MonoBehaviour
{
    public Material a, b, c, d;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("color") == 1 && PlayerPrefs.GetInt("color") == 0)
        {
            transform.GetComponent<Renderer>().material = a;
            //cube.GetComponent<Renderer>().material = a;
        }
        if (PlayerPrefs.GetInt("color") == 2)
        {
            transform.GetComponent<Renderer>().material = b;
            //cube.GetComponent<Renderer>().material = b;
        }
        if (PlayerPrefs.GetInt("color") == 3)
        {
            transform.GetComponent<Renderer>().material = c;
            //cube.GetComponent<Renderer>().material = c;
        }
        if (PlayerPrefs.GetInt("color") == 4)
        {
            transform.GetComponent<Renderer>().material = d;
            //cube.GetComponent<Renderer>().material = d;
        }
    }
}
