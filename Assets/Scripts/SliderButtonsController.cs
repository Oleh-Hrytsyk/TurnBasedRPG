using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderButtonsController : MonoBehaviour
{
    [SerializeField] private Button sliderDownButton;
    [SerializeField] private Button sliderUpButton;
    [SerializeField] private Slider sliderValue;
    [SerializeField] private TextMeshProUGUI text;

    void Start()
    {
        sliderUpButton.onClick.AddListener(() => ChangeSliderValue(1));  // �������� �������� 1 ��� ���������
        sliderDownButton.onClick.AddListener(() => ChangeSliderValue(-1));  // �������� �������� -1 ��� ���������
        sliderValue.onValueChanged.AddListener(ChangeTextValue);
        sliderValue.onValueChanged.AddListener(delegate { MinMaxValueHandler(); });  // ��������� MinMaxValueHandler ��� ��� �������� ��������
        MinMaxValueHandler();  // ���������� ������ ������ �� �����
    }

    private void ChangeSliderValue(int direction)
    {
        sliderValue.value = Mathf.Clamp(sliderValue.value + direction, sliderValue.minValue, sliderValue.maxValue);
        MinMaxValueHandler();
    }

    private void ChangeTextValue(float value)
    {
        text.text = value.ToString();
    }

    private void MinMaxValueHandler()
    {
        sliderDownButton.interactable = sliderValue.value > sliderValue.minValue;
        sliderUpButton.interactable = sliderValue.value < sliderValue.maxValue;
    }
}