using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Game Database/Piece")]
public class SO_Piece : ScriptableObject
{
    [SerializeField] int pieceId;
    [SerializeField] string pieceName;
    [SerializeField] PieceType pieceType;
    [SerializeField] GameObject prefab;

    public int id { get { return pieceId; } }
    public PieceType type { get { return pieceType; } }
}

public enum PieceType
{
    Pawn,
    Horse,
    Tower,
    King,
    Queen,
    Bishop,
    Custom,
    DEV
}