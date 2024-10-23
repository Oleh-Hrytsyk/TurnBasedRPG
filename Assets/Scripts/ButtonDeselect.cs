using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonDeselect : MonoBehaviour
{
    [SerializeField] private Button currentButton;

    void Start()
    {
        // Підписуємося на подію кліку на кнопці
        currentButton.onClick.AddListener(DeselectButton);
    }

    void DeselectButton()
    {
        // Перевірка, чи є активний EventSystem
        if (EventSystem.current != null)
        {
            // Встановлюємо активний об'єкт на null, що знімає фокус з кнопки
            EventSystem.current.SetSelectedGameObject(null);
        }
    }
}