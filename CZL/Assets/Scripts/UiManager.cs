using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public TMP_Text diam_text;
    public TMP_Text gameOverdisplay;
    public TMP_Text levelcompletedisplay;
    public TMP_Text game_score;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float positionz = 45.0f + cube.transform.position.z;

        string p = PlayerPrefs.GetInt("diamond").ToString();

        diam_text.text = gameOverdisplay.text = levelcompletedisplay.text = p;
        game_score.text = positionz.ToString("0");
    }

    public void Retry()
    {
        SceneManager.LoadScene (1);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene (0);
    }
    public void ToLevel2()
    {
        SceneManager.LoadScene(2);
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

}
