using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MobileInputs : MonoBehaviour
{
    private ChessControls chessControl;

    private InputAction leftStick;
    private InputAction rightStick;
    private InputAction touchDelta;
    private InputAction touchPosition;

    [SerializeField] private Vector3 touchPositionVector;

    public Vector3 TouchPosition { get { return touchPositionVector; } }
    public InputAction LeftStick { get { return leftStick; } }
    public InputAction RightStick { get { return rightStick; } }
    public InputAction TouchDelta { get { return touchDelta; } }
    public InputAction inputAction { get { return inputAction; } }
    private void Awake()
    {
        chessControl = new ChessControls();
    }

    private void OnEnable()
    {
        leftStick = chessControl.MobileControls.LeftStick;
        rightStick = chessControl.MobileControls.RightStick;
        touchDelta = chessControl.MobileControls.TouchDelta;
        touchPosition = chessControl.MobileControls.TouchPosition;

        leftStick.Enable();
        rightStick.Enable();
        touchDelta.Enable();
        touchPosition.Enable();

        touchPosition.performed += this.ScreenToWorldTouch;
    }
    private void OnDisable()
    {
        leftStick.Disable();
        rightStick.Disable();
        touchDelta.Disable();
        touchPosition.Disable();
    }
    private void ScreenToWorldTouch(InputAction.CallbackContext obj)
    {
        touchPositionVector = Camera.main.ScreenToWorldPoint(new Vector3 (obj.ReadValue<Vector2>().x, obj.ReadValue<Vector2>().y, 1));
    }

}



