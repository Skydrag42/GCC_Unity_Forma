using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopUpController : MonoBehaviour
{
    public static PopUpController Instance;

    public GameObject popUpObject;

    // We setup the popup from this class for simplicity but using a special script
    // to deal with setting up the pop up data would be better in the long term.
    // It would also make more sense to have the script related to the ui elements
    // directly on the ui object instead of this remote controller.
    public Image popUpIcon;
    public TMP_Text itemName;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ShowPopUp()
    {
        popUpObject.SetActive(true);
        PlayerController.Instance?.DeactivatePlayer();
    }

    public void HidePopUp()
    {
        popUpObject.SetActive(false);
        PlayerController.Instance?.ActivatePlayer();
	}

    public void SetupPopup(ItemData item)
    {
        popUpIcon.sprite = item.icon;
        itemName.text = "You found a " + item.itemName + "!";
    }
}
