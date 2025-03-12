using DG.Tweening;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    [SerializeField] private float _duration = 3f;

    private void Start()
    {
        transform.DORotate(new Vector3(0, 360, 0), _duration,RotateMode.FastBeyond360)
                 .SetEase(Ease.Linear)
                 .SetLoops(-1);
    }
}