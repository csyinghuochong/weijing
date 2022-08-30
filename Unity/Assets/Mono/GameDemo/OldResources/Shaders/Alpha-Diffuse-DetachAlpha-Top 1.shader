Shader "Transparent/DiffuseDetachAlphaTop" {
Properties {
	_MainTex ("LigthMap Base (RGB) A", 2D) = "white" {}
	_MainTexLM ("Base (RGB)", 2D) = "white" {}
	_AlphaTexLM ("Trans (A)", 2D) = "white" {}
}

SubShader {
	Tags {"Queue"="Transparent+1" "IgnoreProjector"="True" "RenderType"="Transparent"}
	LOD 200

CGPROGRAM
#pragma surface surf Lambert alpha

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

Fallback "Transparent/VertexLit"
}
