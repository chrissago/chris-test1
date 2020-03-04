using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButtonColour : MonoBehaviour {


	#region Serialized Fields
	
	[SerializeField]
	private List<Color> m_Colors;
	[SerializeField] 

	private Button m_TargetButton;

	#endregion


	#region Non-Serialized Fields

	[System.NonSerialized]
	private int m_NextColor = 1;

	#endregion


	#region Monobehavior Methods

	private void Start()
	{
		SetColor(0);
	}

	#endregion


	#region Methods

	private void SetColor(int index)
	{
		if (m_TargetButton == null || m_Colors.Count <= index)
		{
			return;
		}

		Color c = m_Colors[index];
		ColorBlock block = m_TargetButton.colors;
		block.normalColor = c;
		block.highlightedColor = c;
		m_TargetButton.colors = block;
	}

	public void Toggle()
	{
		SetColor(m_NextColor);
		m_NextColor = (m_NextColor + 1) % 2;
	}

	#endregion
}
