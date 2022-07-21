using UnityEngine;

public class TextFloat : MonoBehaviour
    {
        void destroyer()
    {
        Destroy(gameObject);
    }
    void Update()
    {
        Invoke("destroyer", 1f);
    }

}
