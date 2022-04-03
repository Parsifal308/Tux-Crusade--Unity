using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    [SerializeField] private GameObject boardPrefab;
    [SerializeField] private Board board;
    [SerializeField] private SO_Games gameData;
    [SerializeField] private List<Piece> teamBlackPieces;
    [SerializeField] private List<Piece> teamWhitePieces;


    private void Awake()
    {
        
        board = Instantiate(boardPrefab, new Vector3(0f, 0f, 0f), new Quaternion(0f, 0f, 0f, 0f)).GetComponent<Board>();
    }
    private void Start()
    {
        if (gameData.GameType == GameType.Classic)
        {
            SetClassicPieces();
        }
        
    }
    public void SetClassicPieces()
    {
        for (int i = 0; i < board.GetSquares.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetSquares.GetLength(1); j++)
            {
                Debug.Log(board.GetSquares[i, j].GetData.SquareName);
                if (j == 1)
                {
                    GameObject newPiece = Instantiate(gameData.PawnPrefab, new Vector3(i, 0.5f, j), new Quaternion(0f, 0f, 0f, 0f));
                    board.GetSquares[i, j].PiecesOnSquare.Add(newPiece.GetComponent<Piece>());
                }
                if (i == 6)
                {
                    GameObject newPiece = Instantiate(gameData.PawnPrefab, new Vector3(i, 0.5f, j), new Quaternion(0f, 0f, 0f, 0f));
                    board.GetSquares[i, j].PiecesOnSquare.Add(newPiece.GetComponent<Piece>());
                }
            }
        }
    }
}
