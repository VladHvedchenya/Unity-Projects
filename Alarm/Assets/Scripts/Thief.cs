using UnityEngine;

public class Thief : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _value;

    private void Update()
    {
        _value = _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.Translate(_value, 0, 0);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(-_value, 0, 0);

        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, 0, -_value);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, 0, _value);
    }
}
