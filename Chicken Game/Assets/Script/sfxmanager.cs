using UnityEngine;

public class sfxmanager : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip AudioBoss;
    public AudioClip AudioBoss1;
    public AudioClip AudioBoss2;
    public AudioClip AudioBoss3;
    public AudioClip AudioBoss4;
    public AudioClip AudioChick;
    public static sfxmanager sfxInstance;
    
    private void Awake()
    {
        if (sfxInstance != null && sfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        sfxInstance = this;
        DontDestroyOnLoad(this);
    }
}
