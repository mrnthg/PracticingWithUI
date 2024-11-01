using UnityEngine;
using UnityEngine.UI;

public class AudioMute : MonoBehaviour
{
    [SerializeField] private AudioListener _audioListener;
    [SerializeField] private Button _offButton;
    [SerializeField] private Button _onButton;

    private void Start()
    {
        _offButton.gameObject.SetActive(false);
        _onButton.gameObject.SetActive(true);
    }

    private void OnEnable()
    {
        _offButton.onClick.AddListener(Mute);
        _onButton.onClick.AddListener(Mute);
    }

    private void OnDisable()
    {
        _offButton.onClick.RemoveListener(Mute);
        _onButton.onClick.RemoveListener(Mute);
    }

    private void Mute()
    {
        ChangeButton();
        _audioListener.enabled = !_audioListener.enabled;
    }

    private void ChangeButton()
    {
        if (_audioListener.enabled)
        {
            _offButton.gameObject.SetActive(true);
            _onButton.gameObject.SetActive(false);
        }
        else
        {
            _onButton.gameObject.SetActive(true);
            _offButton.gameObject.SetActive(false);           
        }
    }
}
