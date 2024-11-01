using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioSlider : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixerGroup;
    [SerializeField] private Slider _slider;

    private float _minSliderValue = 0.0001f;
    private float _maxSliderValue = 1f;
    private float _correctionNumber = 20f;
    private float _standartSliderVolume = 1;
    private string _parameterSliderName;

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeVolume);
    }

    public void Init(string parameterSliderName)
    {
        _parameterSliderName = parameterSliderName;
        _slider.value = _standartSliderVolume;
    }

    public void ChangeVolume(float volume)
    {
        volume = Mathf.Clamp(volume, _minSliderValue, _maxSliderValue);
        _mixerGroup.audioMixer.SetFloat(_parameterSliderName, Mathf.Log10(volume) * _correctionNumber);
    }
}
