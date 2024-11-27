using UnityEngine;
using System;


public class CubemapManager : MonoBehaviour
{
    private TiledCubemap _lowResCubemap;
    private TiledCubemap _highResCubemap;
    private const float SIZE = 100f;


    void Start()
    {
        _lowResCubemap = new TiledCubemap(TiledCubemap.DivisionType.Matrix1x1, SIZE);
        _lowResCubemap.CubemapObject.name = "Cubemap2K";
        _highResCubemap = new TiledCubemap(TiledCubemap.DivisionType.Matrix4x4, SIZE);
        _highResCubemap.CubemapObject.name = "Cubemap8K";
    }


    void Update()
    {
        
    }
}