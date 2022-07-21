using UnityEngine;

public class BossChick : MonoBehaviour
{
    public HealthBar healthBar;
    public GameObject Feathers;
    public GameObject FloatingScorePlus1;
    public float Hitpoints;
    public float MaxHitpoints = 5;
    float speed;

    void Start()
    {
        Hitpoints = MaxHitpoints;
        healthBar.SetHealth(Hitpoints, MaxHitpoints);
        speed = 1f;
    }
    void FixedUpdate () {
            godown();
    }

void godown() {
    transform.position += Vector3.down *speed* Time.deltaTime;
}
    public void onTap()
    {
            Hitpoints -= 1;
            healthBar.SetHealth(Hitpoints, MaxHitpoints);
            if (Hitpoints == 5)
            {
                sfxmanager.sfxInstance.Audio.PlayOneShot(sfxmanager.sfxInstance.AudioBoss);
            }
            if (Hitpoints == 4)
            {
                sfxmanager.sfxInstance.Audio.PlayOneShot(sfxmanager.sfxInstance.AudioBoss1);
            }
            if (Hitpoints == 3)
            {
                sfxmanager.sfxInstance.Audio.PlayOneShot(sfxmanager.sfxInstance.AudioBoss2);
            }
            if (Hitpoints == 2)
            {
                sfxmanager.sfxInstance.Audio.PlayOneShot(sfxmanager.sfxInstance.AudioBoss3);
            }
            if (Hitpoints == 1)
            {
                sfxmanager.sfxInstance.Audio.PlayOneShot(sfxmanager.sfxInstance.AudioBoss4);
            }
            if (Hitpoints <= 0)
            {
            Destroy(gameObject);
            ScoreScript.score+=10;
            Dead();
            Instantiate(FloatingScorePlus1, transform.position, Quaternion.identity);
            sfxmanager.sfxInstance.Audio.PlayOneShot(sfxmanager.sfxInstance.AudioChick);
            }
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        lifesystem.lifeCount-=2;
        Destroy(gameObject);
    }
    void Dead()
    {
        Instantiate(Feathers, transform.position, Quaternion.identity);
    }
}
