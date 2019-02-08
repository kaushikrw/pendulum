using UnityEngine;
using System.Collections;
using MaterialUI;
using UnityEngine.UI;

public class LengthChanges : MonoBehaviour {

	public Text text;
	public HingeJoint2D hinge;

	// Use this for initialization
	void Start () 
	{
		text.text = "1.0"+"M";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Changed(float value)
	{	
		float newval = 0f;
		if (value >=10) 
		{
			newval = value / 20;
		} 
		else 
		{
			newval = 0.5f;
		}

		text.text = "" + newval.ToString ("f1") + "M";

		value = value * -1;

		hinge.connectedAnchor = new Vector2 (hinge.connectedAnchor.x,value);
	}
}
