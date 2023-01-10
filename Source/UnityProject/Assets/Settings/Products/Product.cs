using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Products", menuName = "Products/New Product")]
public class Product : ScriptableObject
{
    [PreviewField]
    [SerializeField]
    public Sprite icon;

    [SerializeField]
    public string title;

    [SerializeField]
    public string description;

    [Space]
    [SerializeField]
    public ulong price;
}