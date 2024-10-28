using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMute : MonoBehaviour
{
    [SerializeField] private List<GameObject> _audioPictures = new List<GameObject>();
    [SerializeField] private AudioListener _audioListener;
    [SerializeField] private Button _muteButton;

    private bool _isAudioPlaying = true;
    private int _audioOn = 1;
    private int _audioOff = 0;

    private void OnEnable()
    {       
        _muteButton.onClick.AddListener(Mute);
    }

    private void OnDisable()
    {       
        _muteButton.onClick.RemoveListener(Mute);
    }

    private void Mute()
    {
        _audioListener.enabled = !_audioListener.enabled;
    }

    public void AudioToggle()
    {
        if(_isAudioPlaying)
        {
            _isAudioPlaying = false;
            _audioPictures[_audioOff].gameObject.SetActive(true);
            _audioPictures[_audioOn].gameObject.SetActive(false);
 
        }
        else
        {
            _isAudioPlaying = true;
            _audioPictures[_audioOff].gameObject.SetActive(false);
            _audioPictures[_audioOn].gameObject.SetActive(true);
        }
    }
}
