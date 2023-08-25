using UnityEngine;

public class Thief : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        float value = _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.Translate(value, 0, 0);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(-value, 0, 0);

        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, 0, -value);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, 0, value);
    }
}
