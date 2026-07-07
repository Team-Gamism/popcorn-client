using Unity.VisualScripting;
using UnityEngine;

public class CornSpoon : MonoBehaviour
{

    
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;
    }
}
