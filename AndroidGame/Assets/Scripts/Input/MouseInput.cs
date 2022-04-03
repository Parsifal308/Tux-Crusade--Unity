using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseInput : MonoBehaviour
{
    private ChessControls chessControl;

    private InputAction mouseDelta;
    private InputAction mousePosition;

    [SerializeField] private Vector2 mouseDeltaValue;
    [SerializeField] private Vector2 mousePositionValue;

    public Vector2 MouseDeltaValue { get { return mouseDeltaValue; } }
    public Vector2 MousePositionValue { get { return mousePositionValue; } }

    private void Awake()
    {
        chessControl = new ChessControls();
    }
    private void OnEnable()
    {
        mouseDelta = chessControl.MouseInput.MouseDelta;
        mousePosition = chessControl.MouseInput.MousePosition;

        mouseDelta.Enable();
        mousePosition.Enable();
    }
    private void OnDisable()
    {
        mouseDelta.Disable();
        mousePosition.Disable();
    }

    private void Update()
    {
        mouseDeltaValue = mouseDelta.ReadValue<Vector2>();
        mousePositionValue = mousePosition.ReadValue<Vector2>();

    }
}
