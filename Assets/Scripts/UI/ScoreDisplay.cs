using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Uses some code from Adapted from https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/
/// </summary>
public class ScoreDisplay : MonoBehaviour
{
    [Tooltip("The text UI to use for display")]
    public Text displayText = null;

    /// <summary>
    /// Description:
    /// Updates the score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void DisplayScore()
    {
        if (displayText != null)
        {
            float timeToDisplay = Time.timeSinceLevelLoad;

            float minutes = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);

            displayText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    /// <summary>
    /// Description:
    /// Overides the virtual Update function and uses the DisplayScore to update the score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void Update()
    {

        // The remaining code is only called for this sub-class of UIelement and not others
        DisplayScore();
    }
}
