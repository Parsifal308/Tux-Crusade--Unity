using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Game Database/Square")]
public class SO_Square : ScriptableObject
{
    [SerializeField] private string squareName;
    [SerializeField] SquareType squareType;

    public string SquareName { get { return squareName; } }
    public SquareType SquareType { get { return squareType; } }
}
public enum SquareType
{
    Classic,
    Custom,
    Dev
}