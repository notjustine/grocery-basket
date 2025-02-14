using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// tutorial: https://youtu.be/kkAjpQAM-jE?si=n1_lKX9YDvTf5H5_

public class Tile : MonoBehaviour
{

    [SerializeField] private Color _baseColor;
    [SerializeField] private Color _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;

    // Start is called before the first frame update
    void Start()
    {
        //_renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(bool isOffset)
    {
        _renderer.color = isOffset ? _offsetColor : _baseColor;
    }

    void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
}
