using DG.Tweening;
using System.Collections;
using UnityEngine;

public class ColorChanger : ObjectController
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private float _delay = 2f;

    private WaitForSeconds _wait;

    private void Start()
    {
        _wait = new(_delay);

        StartTween();
    }

    private IEnumerator ChangeColor()
    {
        while (enabled)
        {
            _meshRenderer.material.DOColor(GetColor(), _duration);

            yield return _wait;
        }
    }

    protected override void StartTween()
    {
        StartCoroutine(ChangeColor());
    }

    private Color GetColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}