using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Color[] colors = new Color[] {Color.white, Color.red, Color.green, Color.blue};
	private int currentColor,length;
	// Use this for initialization

	void Start () 
	{
		currentColor = 0; //White
		length = colors.Length;
		renderer.material.color = colors [currentColor];
	}

	void Update () {

		if(Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 100))
			{
				currentColor = (currentColor+1)%length;
				renderer.material.color = colors[currentColor];
			}
		}
	}
}
