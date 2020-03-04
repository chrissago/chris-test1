using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButtonColour : MonoBehaviour
{
    [SerializeField] List<Color> colours;
    [SerializeField] Button targetButton;

    private int _nextColour = 1;

    private void Start()
    {
        SetColour(0);
    }

    private void SetColour(int index)
    {
        if (this.targetButton == null || this.colours.Count <= index)
        {
            return;
        }

        Color c = this.colours[index];
        ColorBlock block = targetButton.colors;
        block.normalColor = c;
        block.highlightedColor = c;
        targetButton.colors = block;
    }

    public void Toggle()
    {
        SetColour(_nextColour);
        _nextColour = (_nextColour + 1) % 2;

    }
}
