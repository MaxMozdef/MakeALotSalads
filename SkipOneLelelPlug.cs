using UnityEngine;

public class SkipOneLelelPlug : MonoBehaviour
{
    [SerializeField] GameObject oneLevelPlug;

    void Update()
    {
        ChitSkipMonologueOneLevel();
    }

    void ChitSkipMonologueOneLevel()
    {
        if (Input.GetKey(KeyCode.I))
        {
            oneLevelPlug.SetActive(false);
        }
    }
}
