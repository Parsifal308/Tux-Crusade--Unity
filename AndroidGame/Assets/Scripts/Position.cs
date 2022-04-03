using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    [SerializeField] private int xPosition;
    [SerializeField] private int yPosition;
    private Collider positionCollider;
    [SerializeField] private Piece occupiedBy;

    private void Start()
    {
        positionCollider = GetComponentInChildren<Collider>();
    }
}
