using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public Transform targetObjekt;

    private void Update()
    {

        float distance = Vector3.Distance(transform.position, targetObjekt.position);


        if (distance < 1.0f)
        {
            Application.Quit();
            Debug.Log("Collision " + targetObjekt.name);
        }
    }
}