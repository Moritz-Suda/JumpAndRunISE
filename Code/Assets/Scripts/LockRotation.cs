using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Quaternion initialRotation;

    private void Start()
    {
        
        initialRotation = transform.rotation;
    }

    private void Update()
    {
        
        transform.rotation = Quaternion.Euler(initialRotation.eulerAngles.x, transform.rotation.eulerAngles.y, initialRotation.eulerAngles.z);
    }
}
