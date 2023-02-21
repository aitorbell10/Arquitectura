using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class FlechaController : MonoBehaviour
{
    public GameObject flechaa;
    public GameObject Enemigo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Este apartado funciona igual que el enemie controller pero lo tiene la flecha para sumar puntuacion al score cuando ocurra lo mismo.
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
            ScoreScript.scoreValue += 1;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.layer != LayerMask.NameToLayer("Enemigo"))
        {
            lanzamientoFlecha.instance.Spawn();
            //collision.gameObject.GetComponentInParent<FlechaController>().gameObject.SetActive(false);
        }
    }


}
