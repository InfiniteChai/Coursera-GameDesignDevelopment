using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class handles displayig the score
/// </summary>
public class GravityDisplay : UIelement
{
    [Header("References")]
    [Tooltip("The text to use when displaying the score")]
    public TMP_Text displayText = null;
    public Rigidbody2D player = null;

    /// <summary>
    /// Description:
    /// Displays the score onto the display text
    /// Input:
    /// none
    /// Return:
    /// void (no return)
    /// </summary>
    public void DisplayGravity()
    {
        if (displayText != null)
        {            
            displayText.SetText("Gravity: " + (player.gravityScale < 0 ? "Inverted" : "Normal"));
        }
    }

    /// <summary>
    /// Description:
    /// Updates this UI based on this class
    /// Input:
    /// none
    /// Return:
    /// void (no return)
    /// </summary>
    public override void UpdateUI()
    {
        // This calls the base update UI function from the UIelement class
        base.UpdateUI();

		// The remaining code is only called for this sub-class of UIelement and not others
		DisplayGravity();
    }
}
