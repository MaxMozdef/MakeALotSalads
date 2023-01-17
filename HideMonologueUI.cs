using System.Collections;
using TMPro;
using UnityEngine;

public class HideMonologueUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI skipCookDialogue;
    [SerializeField] GameObject CookMonologueUI;

    bool isEndedMonologue;
    
    void Start()
    {
        StartCoroutine(ShowHideUIMessage());
    }

    IEnumerator ShowHideUIMessage()
    {
        yield return new WaitForSeconds(13);
        skipCookDialogue.text = "[skip & start game]"; 
        isEndedMonologue = true;
    }

    private void Update()
    {
        HideOneLevelPlug();
    }

    void HideOneLevelPlug()
    {
        if (Input.GetMouseButtonDown(0) && isEndedMonologue)
            CookMonologueUI.SetActive(false);
    }
}
