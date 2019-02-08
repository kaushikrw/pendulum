using UnityEngine;
using System.Collections;


public class RotationLimiter : MonoBehaviour {

	public float curangle;

	public float maxAngle;
	public float minAngle;
	public float ClampAround;
	public float newangle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		curangle = transform.rotation.eulerAngles.z;

		if (curangle > 90 && curangle < 180)
		{
			curangle = 90 - curangle;	
		} 
		else if (curangle > 180 && curangle < 270) 
		{
			curangle = 180 - curangle;
		} 
		else if (curangle > 270 && curangle <= 360) 
		{
			curangle = 360 - curangle;
		}

		if (curangle > 90 || curangle < 0)
		{
			ClampRotation ();
		}
	}

	void ClampRotation()
	{
		newangle = Mathf.Clamp (curangle, minAngle, maxAngle);
			
		transform.rotation = Quaternion.Euler (new Vector3(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y,newangle));
	}
}
