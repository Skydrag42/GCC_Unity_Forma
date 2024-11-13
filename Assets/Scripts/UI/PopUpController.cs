using UnityEngine;

public class PopUpController : MonoBehaviour
{
    public static PopUpController Instance;

    public GameObject popUpObject;

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
    }

    public void HidePopUp()
    {
        popUpObject.SetActive(false);
    }
}
