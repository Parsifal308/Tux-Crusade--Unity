using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Game Database/Movement")]
public class SO_Movement : ScriptableObject
{
    [SerializeField] MovementType movementType;
}
enum MovementType
{
    Classic,
    Custom,
    Dev
}