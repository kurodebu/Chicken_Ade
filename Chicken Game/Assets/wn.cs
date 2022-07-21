using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wn : MonoBehaviour
{
    private float wnTime;
    public GameObject wnG;
    // Start is called before the first frame update
    void Start()
    {
        wnTime = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (wnTime <= 0)
        {
            wnTime = 2;
            wnG.SetActive(false);
        }
        wnTime -= Time.deltaTime;
        
    }
}
