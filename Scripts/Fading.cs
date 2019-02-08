using UnityEngine;
using System.Collections;

public class Fading : MonoBehaviour {

	public Texture2D fadeouttex;
	public float fspeed = 0.0f;


	private int DrawDepth = -1000;
	private float aplha = 1.0f;
	private int fadedirection = -1;

	void OnGUI()
	{
		aplha += fadedirection * fspeed * Time.deltaTime;
		aplha = Mathf.Clamp01 (aplha);

		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b,aplha);
		GUI.depth = DrawDepth;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeouttex);
		                       
	}

	public float BeginFade(int direction)
	{
		fadedirection = direction;
		return(fspeed);
	}

	void OnLevelWasLoaded()
	{
		aplha = 1;
		BeginFade (-1);
	}

}
