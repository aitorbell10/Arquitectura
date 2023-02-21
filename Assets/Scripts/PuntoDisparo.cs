using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoDisparo : MonoBehaviour
{
    public Transform Spawn;
    public static PuntoDisparo instance;
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
