using UnityEngine;

public class TimeDestroy : MonoBehaviour
{
    public int time;
    void destroyer()
    {
        Destroy(gameObject);
    }
    void Update()
    {
        Invoke("destroyer", time);
    }
}
