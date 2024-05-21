using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    public Vector3 direction = new Vector3 (1.0f,1.0f,1.0f);
    public Vector3 direction1 = new Vector3(-1.0f, -1.0f, -1.0f);
    public float speed = 3.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 1.0f || transform.position.x >= 1.0f || transform.position.x >= 1.0f);
        {
            direction = direction1;
        }
        if(transform.position.x <= 0.0f)
        {
            direction = Vector3.one;
        }
        transform.Translate (direction * speed * Time.deltaTime);

    }
}
