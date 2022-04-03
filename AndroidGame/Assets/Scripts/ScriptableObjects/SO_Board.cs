using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Game Database/Board")]
public class SO_Board : ScriptableObject
{
    [SerializeField] private string boardName;
    [SerializeField] private int xSize;
    [SerializeField] private int ySize;
    [SerializeField] private BoardType boardType;
    [SerializeField] private GameObject boardPrefab;

    public int XSize { get { return xSize; } }
    public int YSize { get { return ySize; } }
    public string BoardName { get { return boardName; } }
    public GameObject BoardPrefab { get { return boardPrefab; } }
}
public enum BoardType
{
    Classic,
    Custom,
    Dev
}
