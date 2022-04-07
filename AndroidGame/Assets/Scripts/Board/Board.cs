using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour,I_Board
{
    [SerializeField] GameManager manager;
    [SerializeField] private SO_Board boardData;
    [SerializeField] private GameObject squarePrefab;
    [SerializeField] private Material squareWhite;
    [SerializeField] private Material squareBlack;
    [SerializeField, SerializeReference] private Square[,] squares;

    public SO_Board GetData { get { return boardData; } }
    public Square[,] GetSquares { get { return squares; } }

    private void Awake()    {
        manager = GetComponentInParent<GameManager>();
        try{    
            squares = new Square[boardData.XSize, boardData.YSize];
        }catch(Exception ex)        {
            Debug.LogError("Un error ha ocurrido: Tipo: " + ex.GetType());
            Debug.LogError("Mensaje de error: " + ex.Message);
        }
        for (int i = 0; i < boardData.XSize; i++){
            for (int j = 0; j < boardData.YSize; j++){
                try{
                    GameObject square;
                    square = Instantiate(squarePrefab, new Vector3(i, 0, j), new Quaternion(0f, 0f, 0f, 0f));
                    square.transform.SetParent(this.transform);
                    squares[i, j] = square.GetComponent<Square>();
                    if ((i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0))                    {
                        square.transform.GetComponentInChildren<MeshRenderer>().material = squareBlack;
                    }
                    else                    {
                        square.transform.GetComponentInChildren<MeshRenderer>().material = squareWhite;
                    }
                }
                catch (Exception ex)                {
                    Debug.LogError("Un error ha ocurrido: Tipo: " + ex.GetType());
                    Debug.LogError("Mensaje de error: " + ex.Message);
                }
            }
        }
    }
}
