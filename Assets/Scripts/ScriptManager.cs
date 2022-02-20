using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScriptManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro _emotionText;
    [SerializeField]
    private TextMeshPro _stateText;

    public void SetEmotionText(string text)
    {
        _emotionText.SetText(text);
    }

    public void SetStateText(string text)
    {
        _stateText.SetText(text);
    }
}
