using TMPro;
using UnityEngine;

public class FieldsSetting : MonoBehaviour
{
    [SerializeField] private TMP_InputField _rateField;
    [SerializeField] private TMP_InputField _speedField;
    [SerializeField] private TMP_InputField _distanceField;

    [SerializeField] private CubeCannon _cubeCannon;

    private void Awake()
    {
        _rateField.onValueChanged.AddListener(RateField);
        _speedField.onValueChanged.AddListener(SpeedField);
        _distanceField.onValueChanged.AddListener(DistanceField);
    }

    public void RateField(string value)
    {
        _cubeCannon.SetRate(int.Parse(value));
    }
    public void SpeedField(string value)
    {
        _cubeCannon.SetSpeed(int.Parse(value));
    }
    public void DistanceField(string value)
    {
        _cubeCannon.SetDistance(int.Parse(value));
    }
}
