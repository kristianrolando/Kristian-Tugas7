using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class SpriteFromAtlas : MonoBehaviour
{
    [SerializeField]
    private SpriteAtlas atlas;
    [SerializeField]
    private string spriteName;

    private void Start()
    {
        GetComponent<Image>().sprite = atlas.GetSprite(spriteName);
    }

}
