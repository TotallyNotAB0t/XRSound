using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform Target;
    [SerializeField] private Transform UL;
    [SerializeField] private Transform UR;
    [SerializeField] private Transform DR;
    [SerializeField] private Transform DL;
    [SerializeField] private float squareSpeed;

    private GameObject _wallTransform;

    private Zones _actualZone;
    private Transform _goalTransform;
    private Transform _cameraTransform;

    public float speed = 5.0f;
    public float sensitivity = 5.0f;
    private float mouseX;
    private float mouseY;

    private void Start()
    {
        _actualZone = Zones.UL;
        _cameraTransform = Camera.main.transform;
        _wallTransform = GameObject.Find("Wall");
        InvokeRepeating(nameof(SwitchPlaces), 0, 3);
    }

    private void Update()
    {
        var step = squareSpeed * Time.deltaTime;
        Target.position = Vector3.MoveTowards(Target.position, _goalTransform.position, step);

        _cameraTransform.position += _cameraTransform.forward * (Input.GetAxis("Vertical") * speed * Time.deltaTime);
        _cameraTransform.position += _cameraTransform.right * (Input.GetAxis("Horizontal") * speed * Time.deltaTime);

        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        _cameraTransform.eulerAngles += new Vector3(-mouseY * sensitivity, mouseX * sensitivity, 0);

        if (Input.GetKeyDown(KeyCode.T))
        {
            _wallTransform.SetActive(!_wallTransform.activeSelf);
        }

    }

    private void SwitchPlaces()
    {
        switch (_actualZone)
        {
            case Zones.UL:
                _actualZone = Zones.UR;
                _goalTransform = UR;
                break;
            case Zones.UR:
                _actualZone = Zones.DR;
                _goalTransform = DR;
                break;
            case Zones.DR:
                _actualZone = Zones.DL;
                _goalTransform = DL;
                break;
            case Zones.DL:
                _actualZone = Zones.UL;
                _goalTransform = UL;
                break;
        }
    }

    private enum Zones
    {
        UL,
        UR,
        DR,
        DL
    }
}
