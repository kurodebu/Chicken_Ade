using UnityEngine;
public class Leaf : MonoBehaviour
{
    void destroyer()
    {
        Destroy(gameObject);
    }
    void Update()
    {
        Invoke("destroyer", 6);
    }
}
