using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject[] Chick;
    public GameObject Boss;
    public GameObject[] BYL;
    public GameObject Mom;
    public float[] x;
    public float y;
    public float timeBetweenWaves = 20;
    private float countdown = 20;
    public Text waveCountdownText;
    public GameObject WaveNotif;
    void Start()
    {
        InvokeRepeating("spawnChick", 0.5f, 1.5f);
        InvokeRepeating("spawnBYL", 10, 15);
        InvokeRepeating("spawnMom", 9, 18);
    }
    void spawnChick()
    {
        int randomChick = Random.Range(0, Chick.Length);
        int randomX = Random.Range(0, x.Length);
        Instantiate(Chick[randomChick],new Vector2 (x[randomX], y), Quaternion.identity);
    }
     void spawnBYL()
    {
        int randomByl = Random.Range(0, BYL.Length);
        int randomX = Random.Range(0, x.Length);
        Instantiate(BYL[randomByl],new Vector2 (x[randomX], y), Quaternion.identity);
    }
    void spawnMom()
    {
        int randomX = Random.Range(0, x.Length);
        Instantiate(Mom,new Vector2 (x[randomX], y), Quaternion.identity);
    }
    void spawnBoss()
    {
        int randomX = Random.Range(0, x.Length);
        Instantiate(Boss,new Vector2 (x[randomX], y), Quaternion.identity);
    }
    void Update ()
    {   
        if (countdown <= 0f)
        {
            SetSpawnBoss();
            countdown = timeBetweenWaves;
            WaveNotif.SetActive(true);
        }
        countdown -= Time.deltaTime;
        waveCountdownText.text = Mathf.Round(countdown).ToString();
    } 
    
    void SetSpawnBoss()
    {
        Invoke("spawnBoss", 5);
        Invoke("spawnChick", 3);
        Invoke("spawnChick", 9);
    }
}
