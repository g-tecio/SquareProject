using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour {

    public UnityEngine.UI.RawImage img;

private Texture2D backgroundTexture ;

void Awake()
{
    backgroundTexture  = new Texture2D(1, 2);
    backgroundTexture.wrapMode = TextureWrapMode.Clamp;
    backgroundTexture.filterMode = FilterMode.Bilinear;
    SetColor( Color.black, Color.white ) ;
}

public void SetColor( Color color1, Color color2 )
{
    backgroundTexture.SetPixels( new Color[] { color1, color2 } );
    backgroundTexture.Apply();
    img.texture = backgroundTexture;
}
}
