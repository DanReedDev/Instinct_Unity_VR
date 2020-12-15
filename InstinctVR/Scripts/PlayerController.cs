using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

    public Interactable focus;

    public LayerMask Ethan;

	bool isFocus = false;
    
    Camera cam;
    PlayerMotor motor;

	void Start () {
		cam = GameObject.Find ("CenterEyeAnchor").GetComponent<Camera> ();
        motor = GetComponent<PlayerMotor>();
	}

	void Update () {

		Ray ray = cam.ViewportPointToRay (new Vector3 (0.5F, 0.5F, 0));
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit)) {
			print (hit.transform.name);
			Interactable interactable = hit.collider.GetComponent<Interactable>();
			if (interactable != null)
			{
				SetFocus(interactable);
			}

			if (Physics.Raycast(ray, out hit, Ethan))
			{
				motor.MoveToPoint(hit.point);

				// Stop focusing any objects
				RemoveFocus();
			}
		}
	}

    void SetFocus (Interactable newFocus)
    {
        if (newFocus != focus)
        {
            if (focus != null)
            focus.OnDefocused();

            focus = newFocus;
            motor.FollowTarget(newFocus);
        }

        focus = newFocus;
        newFocus.OnFocused(transform);
        motor.FollowTarget(newFocus);

    }

    void RemoveFocus()
    {
        focus.OnDefocused();
        focus = null;
        motor.StopFollowingTarget();
    }
}
