using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MenuClicker : MonoBehaviour
{

	float time;

	Camera cam;

	GameObject Go1;
	GameObject Go2;
	GameObject Go3;

	void Start()
	{
		cam = GameObject.Find ("CenterEyeAnchor").GetComponent<Camera>();
		Go1 = GameObject.Find ("Go1");
		Go2 = GameObject.Find ("Go2");
		Go3 = GameObject.Find ("Go3");
	} 

	void Update()
	{

	Ray ray = cam.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 0));
	RaycastHit hit;
		if (Physics.Raycast (ray, out hit))
		{
			if (hit.transform.name == "Go1")
				time += Time.deltaTime;
			if (time > 1.0f)
			{
				Debug.Log ("Play Button Clicked");
				SceneManager.LoadScene (1);
			}	
		}
	}
}
