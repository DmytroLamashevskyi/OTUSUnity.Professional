using Elementary;
using Sirenix.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Observer_UpdateTransformPosition : MonoBehaviour
{
    [SerializeField]
    private Vector3Bechavior observableVector;

    [SerializeField]
    private Transform[] transforms; 

    private void OnEnable()
    {
        observableVector.OnValueChanged += OnVectorChanged;
    }

    private void OnDisable()
    {
        observableVector.OnValueChanged -= OnVectorChanged;
    }

    private void OnVectorChanged(Vector3 newVector)
    {
        foreach(var transform in transforms)
        {
            transform.position += newVector;
        } 
    }
}
