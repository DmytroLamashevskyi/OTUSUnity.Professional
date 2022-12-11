using Elementary;
using Sirenix.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Vector3Observer_UpdateTransformPosition : MonoBehaviour
{
    [SerializeField]
    private Transform rigidbodyTransform; 

    [SerializeField]
    private Transform[] transforms; 

    private void Update()
    {
        UpdateVisual(rigidbodyTransform);
    }

    private void UpdateVisual(Transform newVector)
    {
        foreach(var transform in transforms)
        {
            transform.position = newVector.position;
            transform.rotation = newVector.rotation;
        } 
    }
}
