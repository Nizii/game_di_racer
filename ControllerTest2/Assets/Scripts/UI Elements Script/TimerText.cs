using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerText : MonoBehaviour
{
    TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update
    void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = "60";
    }

    // Update is called once per frame
    public void UpdateText(float gameTime)
    {
        textMeshPro.text = gameTime.ToString("0");
    }
}
