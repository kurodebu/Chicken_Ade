using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicsChick : MonoBehaviour
{
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

    void destroyer()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        Invoke("destroyer",15);
    }
}
