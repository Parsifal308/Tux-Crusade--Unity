using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] MouseInput mouseInput;

    public MouseInput MouseInput { get { return mouseInput; } }
    private void Start()
    {
        mouseInput = GetComponent<MouseInput>();
    }
}
