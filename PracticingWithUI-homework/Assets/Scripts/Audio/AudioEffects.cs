using UnityEngine;
using UnityEngine.Audio;

public class AudioEffects : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixerSoundEffect;
    
    private string _effectVolumeName = "EffectVolume";
    private float _minSliderValue = 0.0001f;
    private float _maxSliderValue = 1f;
    private float _correctionNumber = 20f;

    public void ChangeEffectVolume(float volume)
    {
        volume = Mathf.Clamp(volume, _minSliderValue, _maxSliderValue);
        _mixerSoundEffect.audioMixer.SetFloat(_effectVolumeName, Mathf.Log10(volume) * _correctionNumber);
    }
}
