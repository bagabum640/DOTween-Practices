using DG.Tweening;
using System.Collections;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private float _duration = 3f;
    [SerializeField] private float _delay = 2f;

    private WaitForSeconds _wait;

    private void Start()
    {
        _wait = new(_delay);

        StartCoroutine(ChangeColor());
    }

    private IEnumerator ChangeColor()
    {
        while (enabled)
        {
            _meshRenderer.material.DOColor(GetColor(), _duration);

            yield return _wait;
        }
    }

    private Color GetColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}