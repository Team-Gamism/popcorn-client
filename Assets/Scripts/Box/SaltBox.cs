using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SalttBox : MonoBehaviour, IPointerClickHandler, IPointerExitHandler
{
    public GameObject Spoon;
    public GameObject Spoon1;

    public Sprite BoxOpen;
    public Sprite BoxClose;

    private Image myBoxImage;

    void Start()
    {
        myBoxImage = GetComponent<Image>();
        if (myBoxImage != null && BoxClose != null)
        {
            myBoxImage.sprite = BoxClose;
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {

        if (Spoon1 != null && Spoon1.activeSelf == true) // 다른 스푼(=SaltSpoon)이 켜져있다면 실행 안 함
        {
            return;
        }

        if (Spoon != null)
        {
            if (Spoon.activeSelf == false)
            {
                Debug.Log("d");
                Spoon.SetActive(true);
                myBoxImage.sprite = BoxOpen;
            }
            else
            {
                Debug.Log("s");
                Spoon.SetActive(false);
                myBoxImage.sprite = BoxClose;
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (myBoxImage.sprite == BoxOpen)
        {
            myBoxImage.sprite = BoxClose;
        }
    }
}