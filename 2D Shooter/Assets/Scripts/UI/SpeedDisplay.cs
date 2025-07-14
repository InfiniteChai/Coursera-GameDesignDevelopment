using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class inherits from the UIelement class and handles the display of the high score
/// </summary>
public class SpeedDisplay : UIelement
{
    [Tooltip("The text UI to use for display")]
    public TextMeshProUGUI displayText = null;

    /// <summary>
    /// Description:
    /// Changes the high score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void DisplaySpeed()
    {
        if (displayText != null)
        {
            displayText.text = "Speed: " + string.Format("{0:F1}", GameManager.instance.currentSpeed);
        }
    }

    /// <summary>
    /// Description:
    /// Overrides the virtual function UpdateUI() of the UIelement class and uses the DisplayHighScore function to update
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public override void UpdateUI()
    {
        // This calls the base update UI function from the UIelement class
        base.UpdateUI();

		// The remaining code is only called for this sub-class of UIelement and not others
		DisplaySpeed();
    }
}
