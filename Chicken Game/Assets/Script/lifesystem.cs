using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lifesystem : MonoBehaviour
{
    public GameObject[] lifes;
    public GameObject Pause;
    public GameObject Over;
    public static int lifeCount;
    // Start is called before the first frame update
    void Start()
    {
        lifeCount=3;
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeCount>=6)
        {
            lifeCount=6;
        }
        if(lifeCount==6)
        {
            lifes[0].SetActive(true);
            lifes[1].SetActive(true);
            lifes[2].SetActive(true);
            lifes[3].SetActive(true);
            lifes[4].SetActive(true);
            lifes[5].SetActive(true);
        }
        if(lifeCount==5)
        {
            lifes[0].SetActive(true);
            lifes[1].SetActive(true);
            lifes[2].SetActive(true);
            lifes[3].SetActive(true);
            lifes[4].SetActive(true);
            lifes[5].SetActive(false);
        }
        if(lifeCount==4)
        {
            lifes[0].SetActive(true);
            lifes[1].SetActive(true);
            lifes[2].SetActive(true);
            lifes[3].SetActive(true);
            lifes[4].SetActive(false);
            lifes[5].SetActive(false);
        }
        if(lifeCount==3)
        {
            lifes[0].SetActive(true);
            lifes[1].SetActive(true);
            lifes[2].SetActive(true);
            lifes[3].SetActive(false);
            lifes[4].SetActive(false);
            lifes[5].SetActive(false);
        }
        if(lifeCount==2)
        {
            lifes[0].SetActive(true);
            lifes[1].SetActive(true);
            lifes[2].SetActive(false);
            lifes[3].SetActive(false);
            lifes[4].SetActive(false);
            lifes[5].SetActive(false);
        }
        if(lifeCount==1)
        {
            lifes[0].SetActive(true);
            lifes[1].SetActive(false);
            lifes[2].SetActive(false);
            lifes[3].SetActive(false);
            lifes[4].SetActive(false);
            lifes[5].SetActive(false);
        }
        if(lifeCount<=0)
        {
            lifes[0].SetActive(false);
            lifes[1].SetActive(false);
            lifes[2].SetActive(false);
            lifes[3].SetActive(false);
            lifes[4].SetActive(false);
            lifes[5].SetActive(false);
            Time.timeScale=0;
            Pause.SetActive(false);
            Over.SetActive(true);
        }
    }
}
