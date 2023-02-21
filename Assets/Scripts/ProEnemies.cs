using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///Clase Prototype
///</summary>


public class ProEnemies : Object
{

    //Prototype
    public static GameObject Clone(Vector3 pos)
    {

        GameObject cubeClone = GameObject.CreatePrimitive(PrimitiveType.Cube);

        MeshRenderer rend = cubeClone.GetComponent<MeshRenderer>();
        rend.material.color = new Color(0, 190, 255);
        cubeClone.AddComponent<Rigidbody>();
        cubeClone.GetComponent<Rigidbody>().isKinematic = true;
        cubeClone.AddComponent<BoxCollider>();
        cubeClone.GetComponent<BoxCollider>().isTrigger = true;
        cubeClone.name = "Cube(Clone)";
        cubeClone.tag = "Enemigo";
        cubeClone.gameObject.SetActive(true);
        cubeClone.transform.position = pos;
        cubeClone.transform.localScale = new Vector3(2, 2, 3);
        //cubeClone.AddComponent<TriggerAddLife>();

        return cubeClone;
    }

}

