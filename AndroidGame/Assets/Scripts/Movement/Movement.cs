using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour, I_Movement
{
    [SerializeField] private SO_Movement movementData;
    public SO_Movement GetData { get {return movementData;}}
}
