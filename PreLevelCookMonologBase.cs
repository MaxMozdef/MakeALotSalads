using System.Collections;
using TMPro;
using UnityEngine;

public class PreLevelCookMonologBase : MonoBehaviour
{
    [SerializeField] TMP_Text cookTalkText;

    protected IEnumerator phrasesCook(string str1, string str2, string str3, string str4)
    {
        print(str1);    
        yield return new WaitForSeconds(1.5f);
        cookTalkText.text = str1;

        yield return new WaitForSeconds(1.5f);
        cookTalkText.text = str2;

        yield return new WaitForSeconds(3.5f);
        cookTalkText.text = str3;

        yield return new WaitForSeconds(3.5f);
        cookTalkText.text = str4;
    }
}
