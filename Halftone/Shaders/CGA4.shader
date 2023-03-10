Shader "Hidden/CGAHalftone" 
{
	SubShader
	{
		Cull Off ZWrite Off ZTest Always
		Pass
		{
			HLSLPROGRAM
			#pragma vertex VertDefault
			#pragma fragment frag
			#include "include/CGA4.hlsl"
			ENDHLSL
		}
	} 
}