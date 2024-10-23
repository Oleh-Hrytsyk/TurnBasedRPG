using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonDeselect : MonoBehaviour
{
    [SerializeField] private Button currentButton;

    void Start()
    {
        // ϳ��������� �� ���� ���� �� ������
        currentButton.onClick.AddListener(DeselectButton);
    }

    void DeselectButton()
    {
        // ��������, �� � �������� EventSystem
        if (EventSystem.current != null)
        {
            // ������������ �������� ��'��� �� null, �� ���� ����� � ������
            EventSystem.current.SetSelectedGameObject(null);
        }
    }
}