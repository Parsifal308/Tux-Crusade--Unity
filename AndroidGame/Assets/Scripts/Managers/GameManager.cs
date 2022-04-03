using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Game game;

    private void Start()
    {
        game=GetComponent<Game>();
    }
}
