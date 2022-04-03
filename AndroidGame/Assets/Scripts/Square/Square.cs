using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour, I_Square
{
    [SerializeField] private SO_Square squareData;
    [SerializeField] private List<Piece> piecesOnSquare;
    public SO_Square GetData { get { return squareData; } }
    public List<Piece> PiecesOnSquare { get { return piecesOnSquare; } }
}
