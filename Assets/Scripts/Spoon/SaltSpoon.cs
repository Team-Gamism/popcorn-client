using Unity.VisualScripting;
using UnityEngine;

public class SaltSpoon : MonoBehaviour
{


    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (mainCamera != null)
        {
            Vector2 pos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = pos;
        }
    }
}
