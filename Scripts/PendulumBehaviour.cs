using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class PendulumBehaviour : MonoBehaviour {


	float distance = 0;

	public TextMesh text;

	public Transform pivot;

	private float curangle;

	public Rigidbody2D rigid;

	public  Text ab;

	private bool ad = false;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		curangle = pivot.transform.rotation.eulerAngles.z;
		
		if (curangle > 0.5) 
		{
			CalculateAngle();
			text.text = " : " + curangle.ToString("f1");
			ab.text = "Swinging Angle : " + curangle.ToString("f1");
		}
	}

	void CalculateAngle ()
	{
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

	}

	void OnMouseDrag()
	{
		Vector3 Screepoint = Camera.main.WorldToScreenPoint (transform.position);
		
		Vector3 mouseposition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Screepoint.z);
		
		Vector3 objposition = Camera.main.ScreenToWorldPoint (mouseposition);
		
		transform.position = objposition;
		
		transform.position = new Vector3 (transform.position.x,transform.position.y,0);
	}

	void OnMouseExit()
	{
		StartCoroutine ("ClearAngle");
		ad = false;

	}

	IEnumerator ClearAngle()
	{
		yield return new WaitForSeconds(1.0f);

		text.text = "";

	}
}
