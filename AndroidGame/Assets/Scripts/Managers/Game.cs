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


    public List<Piece> TeamBlackPieces { get { return teamBlackPieces; } }
    public List<Piece> TeamWhitePieces { get { return teamWhitePieces; } }


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
                //WHITE PIECES
                if (j == 1)
                {
                    GameObject newPiece = Instantiate(gameData.PawnPrefab, new Vector3(i, 0.5f, j), new Quaternion(0f, 0f, 0f, 0f));
                    board.GetSquares[i, j].PiecesOnSquare.Add(newPiece.GetComponent<Piece>());
                    newPiece.transform.Rotate(new Vector3(0f, 90f, 0));
                    MeshRenderer[] materials = newPiece.GetComponentsInChildren<MeshRenderer>();
                    for (int k = 0; k < materials.Length; k++)
                    {
                        materials[k].material.color = Color.white;
                    }
                    teamWhitePieces.Add(newPiece.GetComponent<Piece>());
                }
                if (j == 0 && (i == 0 || i == 7))
                {
                    GameObject newPiece = Instantiate(gameData.RookPrefab, new Vector3(i, 0.5f, j), new Quaternion(0f, 0f, 0f, 0f));
                    board.GetSquares[i, j].PiecesOnSquare.Add(newPiece.GetComponent<Piece>());
                    newPiece.transform.Rotate(new Vector3(0f, 90f, 0));
                    MeshRenderer[] materials = newPiece.GetComponentsInChildren<MeshRenderer>();
                    for (int k = 0; k < materials.Length; k++)
                    {
                        materials[k].material.color = Color.white;
                    }
                    teamWhitePieces.Add(newPiece.GetComponent<Piece>());
                }
                if (j == 0 && (i == 1 || i == 6))
                {
                    GameObject newPiece = Instantiate(gameData.KnightPrefab, new Vector3(i, 0.5f, j), new Quaternion(0f, 0f, 0f, 0f));
                    board.GetSquares[i, j].PiecesOnSquare.Add(newPiece.GetComponent<Piece>());
                    newPiece.transform.Rotate(new Vector3(0f, 90f, 0));
                    MeshRenderer[] materials = newPiece.GetComponentsInChildren<MeshRenderer>();
                    for (int k = 0; k < materials.Length; k++)
                    {
                        materials[k].material.color = Color.white;
                    }
                    teamWhitePieces.Add(newPiece.GetComponent<Piece>());
                }
                if (j == 0 && (i == 2 || i == 5))
                {
                    GameObject newPiece = Instantiate(gameData.BishopPrefab, new Vector3(i, 0.5f, j), new Quaternion(0f, 0f, 0f, 0f));
                    board.GetSquares[i, j].PiecesOnSquare.Add(newPiece.GetComponent<Piece>());
                    newPiece.transform.Rotate(new Vector3(0f, 90f, 0));
                    MeshRenderer[] materials = newPiece.GetComponentsInChildren<MeshRenderer>();
                    for (int k = 0; k < materials.Length; k++)
                    {
                        materials[k].material.color = Color.white;
                    }
                    teamWhitePieces.Add(newPiece.GetComponent<Piece>());
                }
                if (j == 0 && i == 3)
                {
                    GameObject newPiece = Instantiate(gameData.QueenPrefab, new Vector3(i, 0.5f, j), new Quaternion(0f, 0f, 0f, 0f));
                    board.GetSquares[i, j].PiecesOnSquare.Add(newPiece.GetComponent<Piece>());
                    newPiece.transform.Rotate(new Vector3(0f, 90f, 0));
                    MeshRenderer[] materials = newPiece.GetComponentsInChildren<MeshRenderer>();
                    for (int k = 0; k < materials.Length; k++)
                    {
                        materials[k].material.color = Color.white;
                    }
                    teamWhitePieces.Add(newPiece.GetComponent<Piece>());
                }
                if (j == 0 && i == 4)
                {
                    GameObject newPiece = Instantiate(gameData.KingPrefab, new Vector3(i, 0.5f, j), new Quaternion(0f, 0f, 0f, 0f));
                    board.GetSquares[i, j].PiecesOnSquare.Add(newPiece.GetComponent<Piece>());
                    newPiece.transform.Rotate(new Vector3(0f, 90f, 0));
                    MeshRenderer[] materials = newPiece.GetComponentsInChildren<MeshRenderer>();
                    for (int k = 0; k < materials.Length; k++)
                    {
                        materials[k].material.color = Color.white;
                    }
                    teamWhitePieces.Add(newPiece.GetComponent<Piece>());
                }


                //BLACK PIECES
                if (j == 6)
                {
                    GameObject newPiece = Instantiate(gameData.PawnPrefab, new Vector3(i, 0.5f, j), new Quaternion(0f, 0f, 0f, 0f));
                    board.GetSquares[i, j].PiecesOnSquare.Add(newPiece.GetComponent<Piece>());
                    newPiece.transform.Rotate(new Vector3(0f, -90f, 0));
                    MeshRenderer[] materials = newPiece.GetComponentsInChildren<MeshRenderer>();
                    for (int k = 0; k < materials.Length; k++)
                    {
                        materials[k].material.color = Color.black;
                    }
                    teamBlackPieces.Add(newPiece.GetComponent<Piece>());


                }
                if (j == 7 && (i == 0 || i == 7))
                {
                    GameObject newPiece = Instantiate(gameData.RookPrefab, new Vector3(i, 0.5f, j), new Quaternion(0f, 0f, 0f, 0f));
                    board.GetSquares[i, j].PiecesOnSquare.Add(newPiece.GetComponent<Piece>());
                    newPiece.transform.Rotate(new Vector3(0f, -90f, 0));
                    MeshRenderer[] materials = newPiece.GetComponentsInChildren<MeshRenderer>();
                    for (int k = 0; k < materials.Length; k++)
                    {
                        materials[k].material.color = Color.black;
                    }
                    teamBlackPieces.Add(newPiece.GetComponent<Piece>());
                }
                if (j == 7 && (i == 1 || i == 6))
                {
                    GameObject newPiece = Instantiate(gameData.KnightPrefab, new Vector3(i, 0.5f, j), new Quaternion(0f, 0f, 0f, 0f));
                    board.GetSquares[i, j].PiecesOnSquare.Add(newPiece.GetComponent<Piece>());
                    newPiece.transform.Rotate(new Vector3(0f, -90f, 0));
                    MeshRenderer[] materials = newPiece.GetComponentsInChildren<MeshRenderer>();
                    for (int k = 0; k < materials.Length; k++)
                    {
                        materials[k].material.color = Color.black;
                    }
                    teamBlackPieces.Add(newPiece.GetComponent<Piece>());
                }
                if (j == 7 && (i == 2 || i == 5))
                {
                    GameObject newPiece = Instantiate(gameData.BishopPrefab, new Vector3(i, 0.5f, j), new Quaternion(0f, 0f, 0f, 0f));
                    board.GetSquares[i, j].PiecesOnSquare.Add(newPiece.GetComponent<Piece>());
                    newPiece.transform.Rotate(new Vector3(0f, -90f, 0));
                    MeshRenderer[] materials = newPiece.GetComponentsInChildren<MeshRenderer>();
                    for (int k = 0; k < materials.Length; k++)
                    {
                        materials[k].material.color = Color.black;
                    }
                    teamBlackPieces.Add(newPiece.GetComponent<Piece>());
                }
                if (j == 7 && i == 4)
                {
                    GameObject newPiece = Instantiate(gameData.QueenPrefab, new Vector3(i, 0.5f, j), new Quaternion(0f, 0f, 0f, 0f));
                    board.GetSquares[i, j].PiecesOnSquare.Add(newPiece.GetComponent<Piece>());
                    newPiece.transform.Rotate(new Vector3(0f, -90f, 0));
                    MeshRenderer[] materials = newPiece.GetComponentsInChildren<MeshRenderer>();
                    for (int k = 0; k < materials.Length; k++)
                    {
                        materials[k].material.color = Color.black;
                    }
                    teamBlackPieces.Add(newPiece.GetComponent<Piece>());
                }
                if (j == 7 && i == 3)
                {
                    GameObject newPiece = Instantiate(gameData.KingPrefab, new Vector3(i, 0.5f, j), new Quaternion(0f, 0f, 0f, 0f));
                    board.GetSquares[i, j].PiecesOnSquare.Add(newPiece.GetComponent<Piece>());
                    newPiece.transform.Rotate(new Vector3(0f, -90f, 0));
                    MeshRenderer[] materials = newPiece.GetComponentsInChildren<MeshRenderer>();
                    for (int k = 0; k < materials.Length; k++)
                    {
                        materials[k].material.color = Color.black;
                    }
                    teamBlackPieces.Add(newPiece.GetComponent<Piece>());
                }
            }
        }
    }
}
