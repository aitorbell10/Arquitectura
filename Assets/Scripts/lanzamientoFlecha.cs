using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class lanzamientoFlecha : MonoBehaviour
{
    public float speed = 6;
    public GameObject navi;
    public Camera micamara;
    public GameObject player;
    float fuerza;
    public GameObject flechaa;
    public float impulse;
    public GameObject enemigo;
    public GameObject[] Array;
    public Transform parent;
    public static lanzamientoFlecha instance;

    //Singleton
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





    void Start()
    {
        Rigidbody rb = flechaa.GetComponent<Rigidbody>();
        flechaa.SetActive(false);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            navi.SetActive(true);

            RaycastHit hit;
            Ray Ray = micamara.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(Ray, out hit))
            {
                navi.transform.position = hit.point;

            }

            //distancia
            fuerza = Vector2.Distance(navi.transform.position, player.transform.position);

        }
        else
        {
            navi.SetActive(false);
        }



        if (Input.GetButtonUp("Fire1"))
        {
            //Aqui creamos el gameobject. Lo que necesitamos hacer es, en lugar de crearlo
            //es mostrarlo en pantalla, es decir , setactive.true. Para ello, el objeto ya tendria 
            //que estar en la escena. para ello, pondremos el objeto en la escena, y crearemos una variable
            //para que el codigo acceda a este objeto.
            //ESTO SERA OBJECT POOLING
            //Solamente la siguiente línea, la de gameobject bullet, no la de bullet.getcomponent.
            GameObject bullet = Instantiate(flechaa, player.transform.position,player.transform.rotation) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * fuerza * impulse);
            flechaa.gameObject.SetActive(true);
        }
    }

    public void Spawn()
    {
        int moduleIndex = Random.Range(0, Array.Length);

        Array[moduleIndex].SetActive(true);
        Array[moduleIndex].transform.position = PuntoDisparo.instance.Spawn.position;
    }


}
