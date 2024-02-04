using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public Transform targetObject;
    public int Teleport_to_room = 0;

    private void Update()
    {
        
        float distance = Vector3.Distance(transform.position, targetObject.position);

        
        if (distance < 1.0f)
        {
            SceneManager.LoadScene(Teleport_to_room, LoadSceneMode.Single);
            Debug.Log("Collision " + targetObject.name);
        }
    }
}
