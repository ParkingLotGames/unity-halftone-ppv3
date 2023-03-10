using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public sealed class CGA4HalftoneRenderer : PostProcessEffectRenderer<CGA4Halftone>
{ 
    readonly int contributionID = Shader.PropertyToID("_Contribution");
    Material cga4Material;

    public override void Init()
    {
        Shader cga4Shader = Shader.Find("Hidden/CGAHalftone");
        cga4Material = new Material(cga4Shader);
    }

    public override void Render(PostProcessRenderContext context)
    {
        var sheet = context.propertySheets.Get(Shader.Find("Hidden/CGAHalftone"));
        sheet.properties.SetFloat(contributionID, settings.contribution);
        context.command.BlitFullscreenTriangle(context.source, context.destination, sheet, 0);
    }
}
