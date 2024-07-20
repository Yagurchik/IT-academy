using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletUssual : Bullet
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
