using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using System;

[Serializable]
[PostProcess(typeof(CGA4HalftoneRenderer), PostProcessEvent.AfterStack, "CGA4 Halftone")]
public sealed class CGA4Halftone : PostProcessEffectSettings
{
    [Range(0f, 1f), Tooltip("Halftone contribution.")]
    public FloatParameter contribution = new FloatParameter { value = 1f };
}
