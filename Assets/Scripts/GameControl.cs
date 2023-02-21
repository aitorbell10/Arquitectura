using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public string Tag;
    public GameObject playerPrefab;
    GameObject Enemigoo;
    public GameObject[] spawnPoints;
    public GameObject selectedSpawnPoint;
    public EnemieController enemigo;
    public GameObject[] enemy;
    public int aleatorio;
    public int numselec = 7;
    // Start is called before the first frame update
    void Start()
    {
        placePlayerRandom();
    }

    // Update is called once per frame

    //Acceso a la clase EnemieController por el SINGLETON.
    void Update()
    {
        if (EnemieController.instance.enemigo == false)
        {
            placePlayerRandom();
        }
    }

    public void placePlayerRandom()
    {
            spawnPoints = GameObject.FindGameObjectsWithTag(Tag);

            int rand = Random.Range(0, spawnPoints.Length);
            selectedSpawnPoint = spawnPoints[rand];
            Enemigoo = Instantiate(playerPrefab, selectedSpawnPoint.transform.position, selectedSpawnPoint.transform.localRotation);
    }
}
