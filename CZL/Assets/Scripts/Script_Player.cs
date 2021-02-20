using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_Player : MonoBehaviour
{
    public static Script_Player instance;

    public Rigidbody cube;
    public GameObject c2;
    public int omega_y;
    public GameObject start_anim;
    bool started;
    public Vector3 vel;
    public Material a, b, c, d;

    private void Awake()
    { 
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        started = false;
        if (PlayerPrefs.GetFloat("speed")== 0)
        {
            PlayerPrefs.SetFloat("speed", 1);
        }
    }

    void FixedUpdate()
    {
        if (started)
        {
            start_anim.SetActive(false);
            vel = cube.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 10f * PlayerPrefs.GetFloat("speed"));
        }

        if (!started)
        {
            if(Input.anyKeyDown)
            {
                started = true;
            }
        }

        if (Input.GetKey("s"))
        {
            //cube.transform.RotateAround(transform.position, new Vector3(0, omega_y, 0), 120 *Time.deltaTime);
            //cube.transform.GetComponent<Rigidbody>().AddTorque(Vector3.down* omega_y * Time.fixedDeltaTime);
        }

        else if (Input.GetKey("d"))
        {
            //cube.transform.RotateAround(transform.position, new Vector3(0, -omega_y, 0), 120 * Time.deltaTime);
            //cube.transform.GetComponent<Rigidbody>().AddTorque(Vector3.up* omega_y * Time.fixedDeltaTime);
       
        }

        if (PlayerPrefs.GetInt("color") == 1 && PlayerPrefs.GetInt("color") == 0)
        {
            cube.GetComponent<Renderer>().material = a;
        }
        if (PlayerPrefs.GetInt("color") == 2)
        {
            cube.GetComponent<Renderer>().material = b;
        }
        if (PlayerPrefs.GetInt("color") == 3)
        {
            cube.GetComponent<Renderer>().material = c;
        }
        if (PlayerPrefs.GetInt("color") == 4)
        {
            cube.GetComponent<Renderer>().material = d;
        }
    }

    public void RotateCW()
    {
        //cube.transform.Rotate(0, omega_y, 0);
        //cube.transform.RotateAround(transform.position, new Vector3(0, omega_y, 0), 30 *15 * Time.fixedDeltaTime);
        cube.transform.GetComponent<Rigidbody>().AddTorque(Vector3.down* omega_y *25 * Time.fixedDeltaTime);
    }

    public void RotateACW()
    {
        //cube.transform.Rotate(0, -omega_y, 0);
        //cube.transform.RotateAround(transform.position, new Vector3(0, -omega_y, 0), 30 * 15* Time.fixedDeltaTime);
        cube.transform.GetComponent<Rigidbody>().AddTorque(Vector3.up * omega_y*25 * Time.fixedDeltaTime);
    }
    
    public void cubeStop()
    {
        cube.GetComponent<Rigidbody>().isKinematic = true;
    }

    

}
