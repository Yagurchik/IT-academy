using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speedBullet;
    
    private void Start()
    {
        StartCoroutine(DestroyPrefabCoroutine());
    }
    public virtual IEnumerator DestroyPrefabCoroutine()
    {
        yield return new WaitForSeconds(3f);

        Destroy(gameObject);
    }
}
