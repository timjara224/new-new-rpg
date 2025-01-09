using UnityEngine;

public class NPCcontroller : MonoBehaviour, interactable
{
    [SerializeField] dialogs dialog;
    public void Interact()
    {
        Debug.Log("haha");
        StartCoroutine(Dialog.Instance.show(dialog));
    }
}
