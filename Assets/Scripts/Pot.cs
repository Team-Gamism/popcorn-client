using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class Pot : MonoBehaviour, IPointerClickHandler
{
    public GameObject Cornspoon;
    public GameObject Saltspoon;

    public Sprite NotCorn;
    public Sprite Corn1;
    public Sprite Corn2;
    public Sprite Corn3;
    public Sprite OverCorn;

    private Image myPotImage;
    private Animator PotAnime;

    public int Corn = 0; //옥수수가 담긴 횟수
    public int Salt = 0; //소금이 담긴 횟수

    public Sprite PowerCornSprite;

    public bool isPowerActivated = false;


    public FullCorn TargetFullCorn;

    void Start()
    {
        myPotImage = GetComponent<Image>();
        PotAnime = GetComponent<Animator>();

        if (myPotImage != null && NotCorn != null)
        {
            myPotImage.sprite = NotCorn;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {

        if (isPowerActivated)
        {
            if (PotAnime != null) PotAnime.SetTrigger("PlayClickAnimation");

            StartCoroutine(WaitAndChangeFullCornUI());
            return;
        }

        

        if (Cornspoon != null && Cornspoon.activeSelf)
        {
            Corn++;
            Cornspoon.SetActive(false);

        }

        if (Saltspoon != null && Saltspoon.activeSelf)
        {
            Salt++;
            Saltspoon.SetActive(false);
        }
    }

    IEnumerator WaitAndChangeFullCornUI()
    {
        yield return new WaitForSeconds(1.0f);
        if(TargetFullCorn != null)
        {
            TargetFullCorn.UpdateUIBYCornCount(Corn);
        }
    }
    public void ChangeSpriteByPower()
    {
        if(myPotImage == null)
        {
            myPotImage = GetComponent<Image>();
        }

        if (myPotImage != null && PowerCornSprite != null)
        {
            isPowerActivated = true;
            myPotImage.sprite = PowerCornSprite;
        }
        else
        {
            Debug.LogError("오류");
        }
    }

    void Update()
    {
        if (isPowerActivated) return;

        if(Corn == 1) myPotImage.sprite = Corn1;
        else if (Corn == 2) myPotImage.sprite = Corn2;
        else if (Corn == 3) myPotImage.sprite = Corn3;
        else if (Corn == 4) myPotImage.sprite = OverCorn;
    }
}