using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScoreScript.score=0;
        Time.timeScale=1;
    }
    public void Pause()
    {
        Time.timeScale=0;
    }
    public void Resume()
    {
        Time.timeScale=1;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Play()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit Success");
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit.collider != null)
            {
                if(hit.collider.gameObject.tag=="chick")
                {
                    hit.collider.gameObject.GetComponent<Chick>().onTap();
                }
                if(hit.collider.gameObject.tag=="Boss")
                {
                    hit.collider.gameObject.GetComponent<BossChick>().onTap();
                }
            }
        }
    }
}
