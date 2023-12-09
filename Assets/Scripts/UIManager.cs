using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI selectedMoleText;
    [SerializeField] private GameObject wallLeft, wallUp, wallRight;
    [SerializeField] private AudioSource leftMoleAudio, upMoleAudio, rightMoleAudio;
    [SerializeField] private Renderer leftRenderer, upRenderer, rightRenderer;

    [SerializeField] private Toggle wallActivationToggle;
    [SerializeField] private Toggle soundActivationToggle;
    [SerializeField] private Slider soundVolume;
    [SerializeField] private Slider pitchVolume;

    private Moles _selectedMole;
    private GameObject _selectedWall;
    private AudioSource _selectedAudioSource;

    private void Start()
    {
        InitMoles();
    }

    public void OnLeftGone()
    {
        leftMoleAudio.mute = true;
        leftRenderer.enabled = false;
    }

    public void OnUpGone()
    {
        upMoleAudio.mute = true;
        upRenderer.enabled = false;
    }

    public void OnRightGone()
    {
        rightMoleAudio.mute = true;
        rightRenderer.enabled = false;
    }

    public void OnLeftAppear()
    {
        leftMoleAudio.mute = false;
        leftRenderer.enabled = true;
    }

    public void OnUpAppear()
    {
        leftMoleAudio.mute = false;
        upRenderer.enabled = true;
    }

    public void OnRightAppear()
    {
        rightMoleAudio.mute = false;
        rightRenderer.enabled = true;
    }

    private void InitMoles()
    {
        _selectedMole = Moles.LMole;
        leftMoleAudio.enabled = true;
        upMoleAudio.enabled = true;
        rightMoleAudio.enabled = true;
        UpdateObjects();
    }

    public void UpdateObjects()
    {
        switch (_selectedMole)
        {
            case Moles.LMole:
                selectedMoleText.text = "Left mole selected";
                _selectedWall = wallLeft;
                _selectedAudioSource = leftMoleAudio;
                break;
            case Moles.UMole:
                selectedMoleText.text = "Upper mole selected";
                _selectedWall = wallUp;
                _selectedAudioSource = upMoleAudio;
                break;
            case Moles.RMole:
                selectedMoleText.text = "Right mole selected";
                _selectedWall = wallRight;
                _selectedAudioSource = rightMoleAudio;
                break;
        }
        UpdateReferences();
    }

    private void UpdateReferences()
    {
        wallActivationToggle.isOn = _selectedWall.activeSelf;
        soundActivationToggle.isOn = _selectedAudioSource.mute;
        soundVolume.value = _selectedAudioSource.volume;
        pitchVolume.value = _selectedAudioSource.pitch;
    }

    public void WallEvent()
    {
        _selectedWall.SetActive(wallActivationToggle.isOn);
    }

    public void MuteEvent()
    {
        _selectedAudioSource.mute = soundActivationToggle.isOn;
    }

    public void VolumeEvent()
    {
        _selectedAudioSource.volume = soundVolume.value;
    }

    public void PitchEvent()
    {
        _selectedAudioSource.pitch = pitchVolume.value;
    }

    public void SwitchToLMole()
    {
        _selectedMole = Moles.LMole;
    }

    public void SwitchToUMole()
    {
        _selectedMole = Moles.UMole;
    }

    public void SwitchToRMole()
    {
        _selectedMole = Moles.RMole;
    }

    private enum Moles
    {
        LMole,
        UMole,
        RMole
    }
}
