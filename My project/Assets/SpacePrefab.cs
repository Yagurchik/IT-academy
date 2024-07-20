using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePrefab : MonoBehaviour
{
    public GameObject[] prefabs; // Массив с префабами, которые вы хотите спавнить

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnRandomPrefabObject();
        }
    }

    private void SpawnRandomPrefabObject()
    {
        if (prefabs.Length == 0)
        {
            Debug.LogWarning("Не заданы префабы для спавна!");
            return;
        }
        Vector3 rotate = transform.eulerAngles;
        rotate.y = Random.Range(0, 180);
        transform.eulerAngles = rotate;
        int randomIndex = Random.Range(0, prefabs.Length);
        int randomPosition = Random.Range(-14, 14);

        Instantiate(prefabs[randomIndex], new Vector3(randomPosition,1,randomPosition), Quaternion.identity);
    }
}