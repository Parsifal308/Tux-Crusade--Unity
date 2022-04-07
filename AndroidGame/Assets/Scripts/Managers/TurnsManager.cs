using UnityEngine;

public class TurnsManager : MonoBehaviour
{
    [SerializeField] private bool isWhiteTurn;
    [SerializeField] private bool isReady;
    [SerializeField] private bool isMoving;
    float maxDistance = 10f;
    private LineRenderer lineRenderer;
    private Ray selectRay;
    private RaycastHit itemHit;
    private int squareMask;

    public bool IsWhiteTurn { get { return isWhiteTurn; }  }


    public void EndTurn()
    {
        isWhiteTurn = !isWhiteTurn;
    }
    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        squareMask = LayerMask.GetMask("Position");
    }
    private void Update()
    {
        lineRenderer.SetPosition(0, Camera.main.transform.position);
        lineRenderer.SetPosition(1, selectRay.origin + selectRay.direction * maxDistance);
        selectRay.origin = Camera.main.transform.position;
        selectRay.direction = Camera.main.transform.forward;
        if (isReady)
        {
            if (Physics.Raycast(selectRay, out itemHit, maxDistance, squareMask))
            {
                Debug.Log("XXXXXXXXXXXXXXXXXXXXXX");
            }
        }
    }
}
