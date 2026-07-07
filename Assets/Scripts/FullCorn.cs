using UnityEngine;
using UnityEngine.UI;

public class FullCorn : MonoBehaviour
{
    private Image fullCorn;

    public Sprite[] fullCornSprites;

    void Start()
    {
        fullCorn = GetComponent<Image>();
    }

    public void UpdateUIBYCornCount(int cornCount)
    {
        if(fullCorn == null) fullCorn = GetComponent<Image>();

        if(fullCorn != null && fullCornSprites != null)
        {
            if(cornCount >= 0 && cornCount < fullCornSprites.Length)
            {
                if (fullCornSprites[cornCount] != null)
                {
                    fullCorn.sprite = fullCornSprites[cornCount];
                }
            }
        }
    }
}
