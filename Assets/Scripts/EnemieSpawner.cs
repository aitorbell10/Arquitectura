using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieSpawner : MonoBehaviour
{
    public float timeRespawnLife;

    private float randomX;
    private float randomY;

    //Esta clase accede al Prototype para hacer que funcione en el juego
    private void Start()
    {
        StartCoroutine(RespawnLife());
    }


    IEnumerator RespawnLife()
    {
        randomX = Random.Range(1, 26);
        randomY = -0.98f;
        GameObject cubeLife = ProEnemies.Clone(new Vector3(randomX, randomY, -5.9972f));
        MeshRenderer rend = cubeLife.GetComponent<MeshRenderer>();
        rend.material.color = new Color(0, 190, 255);
        //cubeLife.AddComponent<TriggerAddLife>();

        cubeLife.transform.SetParent(gameObject.transform);

        yield return new WaitForSeconds(timeRespawnLife);

        /*
         *
         *Cuando acaba el tiempo de espera se vuelve a llamar a la misma corrutina para que nunca termine
         * 
         */

        StartCoroutine(RespawnLife());
    }
}


