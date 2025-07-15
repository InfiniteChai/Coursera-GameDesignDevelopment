using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Class which handles camera movement
/// </summary>

public class Tracker : MonoBehaviour
{    
    [Header("GameObject References")]
    [Tooltip("The target to follow with this camera")]
    public Transform target = null;


    /// <summary>
    /// Description:
    /// Standard Unity function that is called every frame
    /// Input: 
    /// none
    /// Returns: 
    /// void (no return)
    /// </summary>
    void Update()
    {
        SetPosition();
    }

    /// <summary>
    /// Description:
    /// Sets the camera's position according to the settings
    /// Input:
    /// none
    /// Return:
    /// void (no return)
    /// </summary>
    private void SetPosition()
    {
        if (target != null)
        {
            Vector3 targetPosition = GetTargetPosition();
            transform.position = targetPosition;
        }      
    }

    /// <summary>
    /// Description:
    /// Gets the follow target's position
    /// Input: 
    /// none
    /// Returns: 
    /// Vector3
    /// </summary>
    /// <returns>Vector3: The position of the target assigned to this camera controller.</returns>
    public Vector3 GetTargetPosition()
    {
        if (target != null)
        {
            return target.position;
        }
        return transform.position;
    }
}
