using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactor : MonoBehaviour
{
	public LayerMask interactableLayer;
	public float maxInteractionDistance = 3f;
	private bool interactRequested = false;


	RaycastHit hitInfo;
	private void FixedUpdate()
	{
		if (interactRequested)
		{
			if (Physics.Raycast(Camera.main.ViewportPointToRay(new Vector3(.5f, .5f)), out hitInfo, maxInteractionDistance, interactableLayer))
			{
				IInteractable interactable = hitInfo.collider.GetComponent<IInteractable>();
				if (interactable != null) interactable.Interact();
			}
			interactRequested = false;
		}
	}

	public void GetInteract(InputAction.CallbackContext context)
	{
		if (context.performed)
		{
			interactRequested = true;
		}
	}
}
