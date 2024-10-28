using UnityEngine;
using UnityEngine.Audio;

public class AudioBackground : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixerBackgroundMusic;
    
    private string _backgroundVolumeName = "BackgroundVolume";
    private float _minSliderValue = 0.0001f;
    private float _maxSliderValue = 1f;
    private float _correctionNumber = 20f;

    public void ChangeBackgroundVolume(float volume)
    {
        volume = Mathf.Clamp(volume, _minSliderValue, _maxSliderValue);
        _mixerBackgroundMusic.audioMixer.SetFloat(_backgroundVolumeName, Mathf.Log10(volume) * _correctionNumber);
    }
}
