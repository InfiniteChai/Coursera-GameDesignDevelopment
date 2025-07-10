using UnityEngine;
using System.Collections;

public class DayRotation : MonoBehaviour {
    
    [Tooltip("This is the speed at which the object rotates, in Earth Days")]
	public float earthDays; // the speed of rotation	
	
	// Update is called once per frame
	void Update () {				
		transform.RotateAround(this.transform.position, this.transform.up, Time.deltaTime * 360.0f / earthDays / SolarSystemController.Instance.secondsPerEarthDay);
		foreach (Transform childTransform in this.transform)
		{
			childTransform.RotateAround(this.transform.position, this.transform.up, -Time.deltaTime * 360.0f / earthDays / SolarSystemController.Instance.secondsPerEarthDay);
		}
	}
}
