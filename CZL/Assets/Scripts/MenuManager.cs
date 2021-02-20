using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject cube;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene(3);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void X1()
    {
        PlayerPrefs.SetFloat("speed", 1);
    }
    public void X2()
    {
        PlayerPrefs.SetFloat("speed", 1.25f);
    }
    public void X3()
    {
        PlayerPrefs.SetFloat("speed", 1.5f);
    }
    public void X4()
    {
        PlayerPrefs.SetFloat("speed", 1.75f);
    }
    public void X5()
    {
        PlayerPrefs.SetFloat("speed", 2);
    }

    public void Mat1()
    {
        PlayerPrefs.SetInt("color", 1);
        
    }
    public void Mat2()
    {
        PlayerPrefs.SetInt("color", 2);
        
    }
    public void Mat3()
    {
        PlayerPrefs.SetInt("color", 3);
    }
    public void Mat4()
    {
        PlayerPrefs.SetInt("color", 4);
        
    }

}
