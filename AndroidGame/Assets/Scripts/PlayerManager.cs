using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] MouseInput mouseInput;
    [SerializeField] MobileInputs mobileInputs;

    public MouseInput MouseInput { get { return mouseInput; } }
    public MobileInputs MobileInputs { get { return mobileInputs; } }
    private void Start()
    {
        mouseInput = GetComponent<MouseInput>();
        mobileInputs= GetComponent<MobileInputs>();
    }
}
