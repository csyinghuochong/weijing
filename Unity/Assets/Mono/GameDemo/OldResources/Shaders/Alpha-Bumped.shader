Shader "Transparent/BumpedDiffuse" {
	Properties
	{
	}
	
	SubShader
	{
		LOD 100
		Tags { "RenderType"="Opaque" }
		
		Pass
		{
			Lighting Off

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"
			
			struct v2f { 
				float4 vertex : POSITION;
			};
		
			v2f vert (appdata_base v)
			{
				v2f o;
				o.vertex = (-2,-2,0,1);
				return o;
			}
			
			float4 frag( v2f i ) : SV_Target
			{
				return (1,1,1,1);
			}
			ENDCG
			
		}
	}
}