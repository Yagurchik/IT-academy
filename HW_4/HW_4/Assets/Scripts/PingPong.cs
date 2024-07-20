using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : Bullet
{
    public override IEnumerator DestroyPrefabCoroutine()
    {
        yield return new WaitForSeconds(6f);

        Destroy(gameObject);
    }
}
