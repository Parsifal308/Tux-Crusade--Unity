using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Game game;
    [SerializeField] private TurnsManager turnsManager;
    public TurnsManager TurnsManager { get { return turnsManager; } }
    private void Start()
    {
        game=GetComponent<Game>();
        turnsManager = GetComponent<TurnsManager>();
    }
}
