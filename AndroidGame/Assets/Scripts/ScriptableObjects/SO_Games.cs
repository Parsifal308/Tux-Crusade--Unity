using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Game Database/Game")]
public class SO_Games : ScriptableObject
{
    [SerializeField] private GameType gameType;

    [SerializeField] private GameObject pawnPrefab;
    [SerializeField] private GameObject rookPrefab;
    [SerializeField] private GameObject knightPrefab;
    [SerializeField] private GameObject bishopPrefab;
    [SerializeField] private GameObject queenPrefab;
    [SerializeField] private GameObject kingPrefab;

    public GameType GameType { get { return gameType; } }
    public GameObject PawnPrefab { get { return pawnPrefab; } }
    public GameObject RookPrefab { get { return rookPrefab; } }
    public GameObject KnightPrefab { get { return knightPrefab; } }
    public GameObject BishopPrefab { get { return bishopPrefab; } }
    public GameObject QueenPrefab { get { return queenPrefab; } }
    public GameObject KingPrefab { get { return kingPrefab; } }
}
public enum GameType
{
    Classic,
    Custom,
    Dev
}