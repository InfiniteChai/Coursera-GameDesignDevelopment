﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class handles displayig the score
/// </summary>
public class ScoreDisplay : UIelement
{
    [Header("References")]
    [Tooltip("The text to use when displaying the score")]
    public TMP_Text displayText = null;

    /// <summary>
    /// Description:
    /// Displays the score onto the display text
    /// Input:
    /// none
    /// Return:
    /// void (no return)
    /// </summary>
    public void DisplayScore()
    {
        if (displayText != null)
        {
            displayText.SetText("Shards: " + GameManager.score.ToString());
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
        DisplayScore();
    }
}
