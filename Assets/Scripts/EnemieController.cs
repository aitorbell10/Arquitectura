using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieController : MonoBehaviour
{
    private Animator anim;
    public GameObject flechaa;
    public GameObject Enemigo;
    public bool enemigo = true;
    public GameControl Respawn;
    public static EnemieController instance;
    public AudioClip death;
    AudioSource fuenteAudio;

    // Start is called before the first frame update

    //PATRON SINGLETON
    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

    }
    void Start()
    {
        anim = GetComponent<Animator>();
        fuenteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {   

    }
    public void OnCollisionEnter(Collision collision)
    {
        anim.SetTrigger("die");
        Destroy(this.gameObject, 0.5f);
        enemigo = false;
        fuenteAudio.clip = death;
        fuenteAudio.Play();
    }

}
