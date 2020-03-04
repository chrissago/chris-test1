using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButtonColour : MonoBehaviour
{


	#region Serialized Fields
	
	[SerializeField]
	private List<Color> m_Colors;
	[SerializeField] 
	private Button m_TargetButton;

	#endregion


	#region Non-Serialized Fields

	[System.NonSerialized]
	private int m_NextColour = 1;

	#endregion


	#region Monobehavior Methods

	private void Start()
	{
		SetColour(0);
	}

	#endregion


	#region Methods

	private void SetColour(int index)
	{
		if (this.m_TargetButton == null || this.m_Colors.Count <= index)
		{
			return;
		}

		Color c = this.m_Colors[index];
		ColorBlock block = m_TargetButton.colors;
		block.normalColor = c;
		block.highlightedColor = c;
		m_TargetButton.colors = block;
	}

	public void Toggle()
	{
		SetColour(m_NextColour);
		m_NextColour = (m_NextColour + 1) % 2;
	}

	#endregion
}
