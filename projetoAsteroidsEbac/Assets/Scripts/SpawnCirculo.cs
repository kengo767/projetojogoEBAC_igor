using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCirculo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefabCirculo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
                Instantiate(prefabCirculo, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        }
    }
}
