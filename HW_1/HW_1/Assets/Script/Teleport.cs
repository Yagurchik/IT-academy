using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TeleportRandomly());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator TeleportRandomly()
    {
        while (true)
        {
            transform.position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));

            yield return new WaitForSeconds(2);
        }
    }
}
