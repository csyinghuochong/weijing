Shader "Transparent/Cutout/DetachAlphaDiffuse" {
Properties {
	_MainTex ("LigthMap Base (RGB) A", 2D) = "white" {}
	_MainTexLM ("Base (RGB)", 2D) = "white" {}
	_AlphaTexLM ("Trans (A)", 2D) = "white" {}
	_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
}

SubShader {
	Tags {"Queue"="AlphaTest" "IgnoreProjector"="True" "RenderType"="TransparentCutout"}
	LOD 200
	
CGPROGRAM
#pragma surface surf Lambert alphatest:_Cutoff

sampler2D _MainTexLM;
sampler2D _AlphaTexLM;

struct Input {
	float2 uv_MainTexLM;
	float2 uv_AlphaTexLM;
};

void surf (Input IN, inout SurfaceOutput o) {
	fixed4 c = tex2D(_MainTexLM, IN.uv_MainTexLM);
	fixed4 a = tex2D(_AlphaTexLM, IN.uv_AlphaTexLM);
	o.Albedo = c.rgb;
	o.Alpha = a;
}
ENDCG
}

Fallback "Transparent/Cutout/VertexLit"
}
