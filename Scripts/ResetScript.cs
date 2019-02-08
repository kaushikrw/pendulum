using UnityEngine;
using System.Collections;

public class ResetScript : MonoBehaviour {

	public Rigidbody2D pivot;

	public float curangle;

	public float resetangle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void reset()
	{
		pivot.drag = 50;	
		StartCoroutine ("rese");
	}

	IEnumerator rese()
	{
		yield return new WaitForSeconds (1.5f);
		pivot.drag = 0.01f;
	}

}
