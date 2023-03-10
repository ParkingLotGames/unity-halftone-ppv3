using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public sealed class CGA4HalftoneRenderer : PostProcessEffectRenderer<CGA4Halftone>
{ 
    readonly int contributionID = Shader.PropertyToID("_Contribution");
    
    public override void Render(PostProcessRenderContext context)
    {
        var sheet = context.propertySheets.Get(Shader.Find("Hidden/CGAHalftone"));
        sheet.properties.SetFloat(contributionID, settings.contribution);
        context.command.BlitFullscreenTriangle(context.source, context.destination, sheet, 0);
    }
}
