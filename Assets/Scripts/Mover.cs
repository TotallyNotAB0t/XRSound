using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform Target;
    [SerializeField] private Transform UL;
    [SerializeField] private Transform UR;
    [SerializeField] private Transform DR;
    [SerializeField] private Transform DL;
    [SerializeField] private float speed;
    private Zones _actualZone;
    private Transform _goalTransform;

    private void Start()
    {
        _actualZone = Zones.UL;
        InvokeRepeating(nameof(SwitchPlaces), 0, 3);
    }

    private void Update()
    {
        var step = speed * Time.deltaTime;
        Target.position = Vector3.MoveTowards(Target.position, _goalTransform.position, step);
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
