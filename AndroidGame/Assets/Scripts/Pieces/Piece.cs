using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour, I_Piece
{
    [SerializeField] private SO_Piece pieceData;

    public SO_Piece GetData {get {return pieceData;}}
}
