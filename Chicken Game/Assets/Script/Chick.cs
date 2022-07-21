using UnityEngine;

public class Chick : MonoBehaviour
{
    public bool isWhite;
    public bool isRed;
    public bool isBlue;
    public bool isYellow;
    public bool isLeaf;
    public bool isMomChick;
    public GameObject Leaf;
    public GameObject Mom;
    public GameObject Feathers;
    public GameObject FloatingScorePlus;
    public GameObject FloatingScoreMin;
    public GameObject FloatingLifePlus;
    public GameObject FloatingLifeMinus;
    //public Animation Dead;
    float speed;
    void Start()
    {
        speed = 1f;
    }
    void FixedUpdate () {
            godown();
    }
    void godown() {
    transform.position += Vector3.down * speed * Time.deltaTime;
    }
    public void onTap()
    {
        if(isWhite)
        {
            Destroy(gameObject);
            ScoreScript.score-=10;
            Dead();
            Instantiate(FloatingScoreMin, transform.position, Quaternion.identity);
            sfxmanager.sfxInstance.Audio.PlayOneShot(sfxmanager.sfxInstance.AudioChick);
        }
        if(isRed)
        {
            Destroy(gameObject);
            ScoreScript.score+=5;
            Dead();
            Instantiate(FloatingScorePlus, transform.position, Quaternion.identity);
            sfxmanager.sfxInstance.Audio.PlayOneShot(sfxmanager.sfxInstance.AudioChick);
        }
        if(isBlue)
        {
            Destroy(gameObject);
            lifesystem.lifeCount+=1;
            Dead();
            Instantiate(FloatingLifePlus, transform.position, Quaternion.identity);
            sfxmanager.sfxInstance.Audio.PlayOneShot(sfxmanager.sfxInstance.AudioChick);
        }
        if(isYellow)
        {
            Destroy(gameObject);
            lifesystem.lifeCount-=1;
            Dead();
            Instantiate(FloatingLifeMinus, transform.position, Quaternion.identity);
            sfxmanager.sfxInstance.Audio.PlayOneShot(sfxmanager.sfxInstance.AudioChick);
        }
        if(isLeaf)
        {
            Destroy(gameObject);
            Instantiate(Leaf);
            Dead();
            sfxmanager.sfxInstance.Audio.PlayOneShot(sfxmanager.sfxInstance.AudioChick);
        }
        if(isMomChick)
        {
            Destroy(gameObject);
            Instantiate(Mom);
            Dead();
            sfxmanager.sfxInstance.Audio.PlayOneShot(sfxmanager.sfxInstance.AudioChick);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (isRed)
        {
        lifesystem.lifeCount-=2;
        }
    Destroy(gameObject);
    }
    void Dead()
    {
        Instantiate(Feathers, transform.position, Quaternion.identity);
    }
    void destroyer()
    {
        Destroy(gameObject);
    }
    void scoreMin()
    {
        Instantiate(FloatingScoreMin, transform.position, Quaternion.identity);
    }
}