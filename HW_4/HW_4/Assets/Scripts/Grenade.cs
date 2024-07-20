using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : Bullet
{
    public float radius = 10.0F;
    public float force;


    public override IEnumerator DestroyPrefabCoroutine()
    {
        yield return new WaitForSeconds(3f);
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider hit in colliders)
        {
            Debug.Log(hit);
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(force, transform.position, radius);
        }
        Destroy(gameObject);
    }
}

