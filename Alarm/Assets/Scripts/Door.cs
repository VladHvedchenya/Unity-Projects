using UnityEngine;

[RequireComponent(typeof(Alarm))]
public class Door : MonoBehaviour
{
    private Alarm _alarm;
    private bool _isOpened = false;

    private void Awake()
    {
        _alarm = GetComponent<Alarm>();
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if(otherCollider.TryGetComponent(out Thief _))
        {
            if (_isOpened)
            {
                _alarm.TurnOff();
                _isOpened = false;
            }
            else
            {
                _alarm.TurnOn();
                _isOpened = true;
            }
        }
    }
}