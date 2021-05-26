using UnityEngine;
using UnityEngine.Events;

public class ClickHandler : MonoBehaviour
{
    [SerializeField] UnityEvent clickEvent;

    private void OnMouseUpAsButton()
    {
        clickEvent?.Invoke();
    }

}
