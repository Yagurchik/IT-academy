using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] prefabs;
    public Material[] materials;
    public float[] changeControl;
    
    public float speed = 10.0F;
    internal Vector3 direction = Vector3.forward;
    private Renderer rend;
    //private MeshFilter rendMesh;

    void Start()
    {
        Vector3 rotate = transform.eulerAngles;
        rotate.y = Random.Range(0, 180);
        transform.eulerAngles = rotate;
        rend = GetComponent<Renderer>();
        //rendMesh = GetComponent<MeshFilter>();
    }
    private void OnTriggerEnter (Collider other)
    {

        if (other.gameObject.CompareTag("Wall"))
        {
            Vector3 rotate = transform.eulerAngles;
            rotate.y = 180 - rotate.y;
            transform.eulerAngles = rotate;
            TriggerViger();
        }
        if (other.gameObject.CompareTag("Wall2"))
        {
            Vector3 rotate = transform.eulerAngles;
            rotate.y = -rotate.y;
            transform.eulerAngles = rotate;
            TriggerViger();
        }
    }
    void Update()
    {
        Vector3 movement = direction * speed * Time.deltaTime;
        transform.Translate(movement);
    }
    private void TriggerViger()
    {
        if (prefabs.Length == 0 || materials.Length == 0 || changeControl.Length == 0)
        {
            Debug.LogWarning("Не заданы префабы или материалы!");
            return;
        }
        int fate = Random.Range(0,3);
        Debug.Log(fate);
        switch (fate)
            { 
            case 0:
                int randomPrefabIndex = Random.Range(0, prefabs.Length);
                Instantiate(prefabs[randomPrefabIndex], transform.position, Quaternion.identity);
                Destroy(gameObject);
                break;
            case 1:
                int randomMaterialIndex = Random.Range(0, materials.Length);
                rend.material = materials[randomMaterialIndex];
                break;
            case 2:

                int randomScaleIndex = Random.Range(0, changeControl.Length);
                transform.localScale = new Vector3(changeControl[randomScaleIndex], changeControl[randomScaleIndex], changeControl[randomScaleIndex]);
                break;
        }
    }
}
