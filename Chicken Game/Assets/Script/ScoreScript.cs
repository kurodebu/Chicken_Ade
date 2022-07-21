using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    public GameObject Win;
    public GameObject Pause;
    public static int score=0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text=score.ToString();
        if(score>=250)
            {
                Time.timeScale=0;
                Win.SetActive(true);
                Pause.SetActive(false);
            }
        if(score<=0)
            {
                score=0;
            }
    }
    /*function Update()
    {
        score = (Mathf.clamp(0, Mathf.Infinity));
    }*/
}
