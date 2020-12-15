using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ObjectClicker : MonoBehaviour
{

    private Animator animator;

	public Interactable OrbOne;

	float animate = 1;

    Animator anim;
    Camera cam;

	GameObject _orb1;
	GameObject _orb2;
	GameObject _orb3;
	GameObject _orb4;
	GameObject _orb5;
	GameObject _orb6;
	GameObject _orb7;
	GameObject _portal;

    void Start()
    {
		cam = GameObject.Find ("CenterEyeAnchor").GetComponent<Camera>();

		_orb1 = GameObject.Find("OrbOne");
		_orb2 = GameObject.Find("OrbTwo");
		_orb3 = GameObject.Find("OrbThree");
		_orb4 = GameObject.Find("OrbFour");
		_orb5 = GameObject.Find("OrbFive");
		_orb6 = GameObject.Find("OrbSix");
		_orb7 = GameObject.Find("OrbSeven");
		_portal = GameObject.Find("Portal");

		_orb1.GetComponent<MeshRenderer>().enabled = true;
		_orb2.GetComponent<MeshRenderer>().enabled = false;
		_orb3.GetComponent<MeshRenderer>().enabled = false;
		_orb4.GetComponent<MeshRenderer>().enabled = false;
		_orb5.GetComponent<MeshRenderer>().enabled = false;
		_orb6.GetComponent<MeshRenderer>().enabled = false;
		_orb7.GetComponent<MeshRenderer>().enabled = false;
		_portal.GetComponent<MeshRenderer>().enabled = false;

		_orb1.GetComponent<Collider> ().enabled = true;
		_orb2.GetComponent<Collider> ().enabled = false;
		_orb3.GetComponent<Collider> ().enabled = false;
		_orb4.GetComponent<Collider> ().enabled = false;
		_orb5.GetComponent<Collider> ().enabled = false;
		_orb6.GetComponent<Collider> ().enabled = false;
		_orb7.GetComponent<Collider> ().enabled = false;
		_portal.GetComponent<Collider> ().enabled = false;

    } 

    private void Update()
    {

		Ray ray = cam.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 0));
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit))
		{
			//print (hit.transform.name);
			if (hit.transform.name == "_orb1")
			{

			}

		}

	}
}

