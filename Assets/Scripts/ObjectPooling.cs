using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public List<GameObject> pooledFlechas;
    public int sizeFlecha;
    public static ObjectPooling instance;
    public GameObject flechaa;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update

    //Object Pooling
    void Start()
    {
        pooledFlechas = new List<GameObject>();
        for (int i = 0; i < sizeFlecha; i++)
        {
            GameObject obj = (GameObject)Instantiate(flechaa);
            obj.SetActive(true);
            pooledFlechas.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
