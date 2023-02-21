using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouLose : MonoBehaviour
{
    public GameObject suelo;
    public GameObject flecha;
    int vidas = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vidas == 0)
        {
            ScoreScript.scoreValue = 0;
            SceneManager.LoadScene(2);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        vidas -= 1;
    }
}
