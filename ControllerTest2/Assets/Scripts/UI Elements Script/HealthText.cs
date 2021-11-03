using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthText : MonoBehaviour
{

    TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update
    void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = "100";
    }

    // Update is called once per frame
    public void UpdateText(int currentHealth)
    {
        textMeshPro.text = currentHealth.ToString("0") + "%";
    }
}
