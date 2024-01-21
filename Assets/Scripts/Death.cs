using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Death : MonoBehaviour
{
    public Transform targetObject;
    public int GameOver = 3;
    

    private void Update()
    {

        float distance = Vector3.Distance(transform.position, targetObject.position);


        if (distance < 0.5f)
        {
            SceneManager.LoadScene(GameOver, LoadSceneMode.Single);
        }
        
    }
}
