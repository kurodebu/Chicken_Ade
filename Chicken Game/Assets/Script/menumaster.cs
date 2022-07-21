using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumaster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=1;
    }
    public void Play()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit Success");
    }
    public void Tutor()
    {
        SceneManager.LoadScene("Tutorial");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
