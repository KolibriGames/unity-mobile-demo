using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] [Range(0, 100)] private float _rotateFactor;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var rotate = Time.deltaTime * _rotateFactor;
        var localeRotation = _transform.localEulerAngles;
        _transform.localEulerAngles =
            new Vector3(localeRotation.x, localeRotation.y + rotate, localeRotation.z);
    }
}