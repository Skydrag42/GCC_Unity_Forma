using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
	public Animator animator;
	private bool opened = false;
	AudioSource sfx;

	public ItemData item;

	private void Start()
	{
		sfx = GetComponent<AudioSource>();
	}

	public void Interact()
	{
		if (opened) return;
		opened = true;
		animator.SetBool("open", true);
		PopUpController.Instance?.SetupPopup(item);
		PopUpController.Instance?.ShowPopUp();
		sfx.Play();
	}

}
