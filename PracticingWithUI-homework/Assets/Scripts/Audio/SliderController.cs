using UnityEngine;

public class SliderController : MonoBehaviour
{
    private const string MasterVolume = nameof(MasterVolume);
    private const string EffectVolume = nameof(EffectVolume);
    private const string BackgroundVolume = nameof(BackgroundVolume);

    [SerializeField] private AudioSlider _overallVolumeSlider;
    [SerializeField] private AudioSlider _effectsVolumeSlider;
    [SerializeField] private AudioSlider _backgroundVolumePanel;

    private void Start()
    {
        _overallVolumeSlider.Init(MasterVolume);
        _effectsVolumeSlider.Init(EffectVolume);
        _backgroundVolumePanel.Init(BackgroundVolume);
    }
}

