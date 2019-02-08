using UnityEngine;
using System.Collections;

public class loadlevel : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		StartCoroutine ("load");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	IEnumerator load()
	{
		yield return new WaitForSeconds (2.3f);
		Application.LoadLevel (1);
	}
}
