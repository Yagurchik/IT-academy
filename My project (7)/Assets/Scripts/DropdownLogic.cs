using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DropDown : MonoBehaviour
{
    public TextMeshProUGUI menu;
    public void InputMenu(int index)
    {
        switch (index)
        {
            case 0:
                menu.text = "Option A";
                break;
            case 1:
                menu.text = "Option B";
                break;
            case 2:
                menu.text = "Option C";
                break;
        }
    }
}
