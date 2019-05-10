using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D m_backgroundcollider;
    private float m_BackgroundSize;

    void Start()
    {
        m_backgroundcollider = GetComponent<BoxCollider2D>();
        m_BackgroundSize = m_backgroundcollider.size.y;
    }

    void Update()
    {
        if (transform.position.y < -m_BackgroundSize)
            RepeateBackground();
    }
    void RepeateBackground()
    {
        Vector2 BGoffset = new Vector2(0, m_BackgroundSize * 2f);
        transform.position = (Vector2)transform.position + BGoffset;
    }
}