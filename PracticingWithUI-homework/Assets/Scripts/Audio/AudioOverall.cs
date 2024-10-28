using UnityEngine;
using UnityEngine.Audio;

public class AudioOverall : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixerMaster;
    
    private string _masterVolumeName = "MasterVolume";
    private float _minSliderValue = 0.0001f;
    private float _maxSliderValue = 1f;
    private float _correctionNumber = 20f;

    public void ChangeAllVolume(float volume)
    {
        volume = Mathf.Clamp(volume, _minSliderValue, _maxSliderValue);
        _mixerMaster.audioMixer.SetFloat(_masterVolumeName, Mathf.Log10(volume) * _correctionNumber);
    }
}
