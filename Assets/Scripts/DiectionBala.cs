using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiectionBala : MonoBehaviour
{
    public GameObject player;

    public GameObject arco;

    public GameObject navi;

    // public Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
        //Direction();
    }

    // Update is called once per frame
    void Update()
    {
        arco.transform.LookAt(-navi.transform.position);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Grid"))
        {
            Destroy(this.gameObject);
        }
    }

}
