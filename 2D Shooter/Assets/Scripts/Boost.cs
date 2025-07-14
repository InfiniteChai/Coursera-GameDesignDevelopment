using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A class which controls enemy behaviour
/// </summary>
public class Boost : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("The time (in seconds) which the boost will show for before disappearing")]
    public float lifetime = 5.0f;
	private float timeAlive = 0.0f;
	public static bool quitting = false;
	public float boostTime = 5.0f;
	public PlayerBoost boost;

	private void OnApplicationQuit()
	{
		quitting = true;
		DestroyImmediate(this.gameObject);
	}

	void Update()
	{
		if (timeAlive > lifetime)
		{
			Destroy(this.gameObject);
		}
		else
		{
			timeAlive += Time.deltaTime;
		}
	}

	private void OnDestroy()
	{
		if (!quitting && Application.isPlaying)
		{
			int childCount = transform.childCount;
			for (int i = childCount - 1; i >= 0; i--)
			{
				GameObject childObject = transform.GetChild(i).gameObject;
				if (childObject != null)
				{
					DestroyImmediate(childObject);
				}
			}
		}
		transform.DetachChildren();
	}

	private void OnTriggerEnter2D(Collider2D collision)
    {
		// We apply the boost as a temporary layer - 
		if (collision.gameObject.tag == "Player")
		{
			collision.gameObject.GetComponent<Controller>().AddBoost(new TimedPlayerBoost(boostTime, boost));
			Destroy(this.gameObject);
		}
    }
}
