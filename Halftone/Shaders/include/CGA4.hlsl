#include "Common.hlsl" 
 
float4 frag(VaryingsDefault i) : SV_Target
{
	float4 color = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, i.texcoord);
	float lum = color.r*.3 + color.g*.59 + color.b*.11;
	float4 dotColor = float4(0.3,1,1,1);
	if(lum < 0.4)
	{
		dotColor = float4(1,0.3,1,1);
	}
	float x = i.vertex.x;
	float y = i.vertex.y;
	float dotSize = 8;
	float rad = (1.4 * dotSize) / 2;
	// depending on lum [0,1] we draw as halftone with black background.
	float cx = (x - (x % dotSize)) + rad;
	float cy = (y - (y % dotSize)) + rad;
	float dx = x - cx;
	float dy = y - cy;
	float r = sqrt((dx*dx) + (dy*dy));
	float cr = (dotSize * lum) / 2;
	if(r > cr)
	{					
		dotColor = float4(0,0,0,1) ; // black
	}
	dotColor = lerp(color, dotColor, _Contribution);
	return dotColor;
}