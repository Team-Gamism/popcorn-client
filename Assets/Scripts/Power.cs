using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;


public class Power : MonoBehaviour, IPointerClickHandler
{
    public Pot TargetPot;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (TargetPot != null && TargetPot.isPowerActivated) return;        

        if(TargetPot.Corn == 0)
        {
            Debug.Log("올바른실행");
            return;
        }
        StartCoroutine(PowerRoutine());
    }

    IEnumerator PowerRoutine()
    {
        Time.timeScale = 0f;

        yield return new WaitForSecondsRealtime(1.5f);
        Time.timeScale = 1f;

        if (TargetPot != null)
        {
            TargetPot.ChangeSpriteByPower();
        }
        else
        {
            Debug.LogError("연결안됨");
        }
    }
}
