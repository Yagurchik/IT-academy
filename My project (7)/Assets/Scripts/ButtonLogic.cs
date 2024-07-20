using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonLogic : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textLable;
    [SerializeField] private string text;
    private Button button;
    private void Awake()
    {
        textLable = textLable ?? GetComponent<TextMeshProUGUI>();
    }
    void GetText()
    {
        textLable.text = text;
    }
    public void OnEnable()
    {
        button = button ?? GetComponent<Button>();
        button.onClick.AddListener(GetText);
    }
    public void OnDisable()
    {
        button.onClick.RemoveListener(GetText);
    }
}