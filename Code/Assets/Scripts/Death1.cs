using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Death1 : MonoBehaviour
{
    public Transform targetObject;
    public int GameOver = 3;
    public int Death_radius = 1;

    private void Update()
    {

        float distance = Vector3.Distance(transform.position, targetObject.position);


        if (distance < Death_radius)
        {
            SceneManager.LoadScene(GameOver, LoadSceneMode.Single);
        }
        
    }
}
