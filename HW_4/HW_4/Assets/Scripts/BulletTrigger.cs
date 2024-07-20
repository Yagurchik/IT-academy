using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletTrigger : MonoBehaviour
{
     public Bullet bullet;

    private void OnTriggerEnter(Collider _player)
    {
        if (_player != null)
        {
            Player playerComponent = _player.GetComponent<Player>();
            if (playerComponent != null)
            {
                playerComponent._bullet = bullet;
            }
        }
    }
}
