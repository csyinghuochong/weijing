// Made with Amplify Shader Editor
// Available at the Unity Asset Store - http://u3d.as/y3X 
Shader "E3DEffect/AirDistort/Noise-Mask"
{
	Properties
	{
		_DistortMap("DistortMap", 2D) = "white" {}
		_Distrot("Distrot", Range( 0 , 0.1)) = 0.255728
		_DistortOffset("DistortOffset", Range( -2 , 2)) = -0.8
		_MaskMap("MaskMap", 2D) = "white" {}
		_Alpha("Alpha", Range( 0 , 5)) = 2
		[HideInInspector] _texcoord( "", 2D ) = "white" {}
		[HideInInspector] __dirty( "", Int ) = 1
	}

	SubShader
	{
		Tags{ "RenderType" = "Transparent"  "Queue" = "Overlay+0" "IsEmissive" = "true"  }
		Cull Back
		ZWrite Off
		Blend SrcAlpha OneMinusSrcAlpha
		
		GrabPass{ }
		CGPROGRAM
		#pragma target 3.0
		#pragma surface surf Unlit keepalpha noshadow 
		struct Input
		{
			float4 screenPos;
			float2 uv_texcoord;
			float4 vertexColor : COLOR;
		};

		uniform sampler2D _GrabTexture;
		uniform sampler2D _DistortMap;
		uniform float4 _DistortMap_ST;
		uniform float _DistortOffset;
		uniform sampler2D _MaskMap;
		uniform float4 _MaskMap_ST;
		uniform float _Alpha;
		uniform float _Distrot;

		inline half4 LightingUnlit( SurfaceOutput s, half3 lightDir, half atten )
		{
			return half4 ( 0, 0, 0, s.Alpha );
		}

		void surf( Input i , inout SurfaceOutput o )
		{
			float4 ase_screenPos = float4( i.screenPos.xyz , i.screenPos.w + 0.00000000001 );
			float4 ase_screenPosNorm = ase_screenPos / ase_screenPos.w;
			ase_screenPosNorm.z = ( UNITY_NEAR_CLIP_VALUE >= 0 ) ? ase_screenPosNorm.z : ase_screenPosNorm.z * 0.5 + 0.5;
			float2 appendResult8 = (float2(ase_screenPosNorm.x , ase_screenPosNorm.y));
			float2 uv_DistortMap = i.uv_texcoord * _DistortMap_ST.xy + _DistortMap_ST.zw;
			float4 tex2DNode9 = tex2D( _DistortMap, uv_DistortMap );
			float2 appendResult17 = (float2(tex2DNode9.r , tex2DNode9.g));
			float2 uv_MaskMap = i.uv_texcoord * _MaskMap_ST.xy + _MaskMap_ST.zw;
			float4 tex2DNode4 = tex2D( _MaskMap, uv_MaskMap );
			float4 clampResult15 = clamp( ( ( tex2DNode4 * tex2DNode4.a * i.vertexColor.a ) * _Alpha ) , float4( 0,0,0,0 ) , float4( 1,1,1,0 ) );
			float2 lerpResult2 = lerp( appendResult8 , ( appendResult17 * _DistortOffset ) , saturate( ( clampResult15 * _Distrot ) ).rg);
			float4 screenColor1 = tex2D( _GrabTexture, lerpResult2 );
			o.Emission = screenColor1.rgb;
			o.Alpha = clampResult15.r;
		}

		ENDCG
	}
	CustomEditor "ASEMaterialInspector"
}
/*ASEBEGIN
Version=16400
90;861;1419;760;1507.706;-50.12314;1;True;False
Node;AmplifyShaderEditor.VertexColorNode;6;-1543.762,-436.5042;Float;False;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SamplerNode;4;-1634.437,-739.0858;Float;True;Property;_MaskMap;MaskMap;4;0;Create;True;0;0;False;0;None;ad0c8b6a37a4a9a45b626a4e408b968c;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;14;-1610.229,-221.2127;Float;False;Property;_Alpha;Alpha;5;0;Create;True;0;0;False;0;2;3.3;0;5;0;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;5;-1120.335,-554.6775;Float;False;3;3;0;COLOR;0,0,0,0;False;1;FLOAT;0;False;2;FLOAT;0;False;1;COLOR;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;16;-754.2572,-555.1882;Float;False;2;2;0;COLOR;0,0,0,0;False;1;FLOAT;0;False;1;COLOR;0
Node;AmplifyShaderEditor.RangedFloatNode;3;-778.4739,596.5288;Float;False;Property;_Distrot;Distrot;2;0;Create;True;0;0;False;0;0.255728;0.0221;0;0.1;0;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;15;-592.5397,-348.1727;Float;True;3;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;2;COLOR;1,1,1,0;False;1;COLOR;0
Node;AmplifyShaderEditor.SamplerNode;9;-1221.101,211.6357;Float;True;Property;_DistortMap;DistortMap;1;0;Create;True;0;0;False;0;None;7abc32cbcbe367844ac624c77a525a2d;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.ScreenPosInputsNode;7;-1096.233,-82.74902;Float;False;0;False;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;22;-92.49423,320.6691;Float;False;2;2;0;COLOR;0,0,0,0;False;1;FLOAT;0;False;1;COLOR;0
Node;AmplifyShaderEditor.DynamicAppendNode;17;-818.2756,229.0524;Float;True;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;45;-850.5129,479.9724;Float;False;Property;_DistortOffset;DistortOffset;3;0;Create;True;0;0;False;0;-0.8;1.72;-2;2;0;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;8;-698.6367,-36.88651;Float;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SaturateNode;23;188.9498,284.9368;Float;False;1;0;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;42;-471.6567,300.2694;Float;True;2;2;0;FLOAT2;0,0;False;1;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.LerpOp;2;357.8701,12.93179;Float;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.ScreenColorNode;1;639.412,-35.76579;Float;False;Global;_GrabScreen0;Grab Screen 0;0;0;Create;True;0;0;False;0;Object;-1;False;False;1;0;FLOAT2;0,0;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.StandardSurfaceOutputNode;0;1069.36,-303.1503;Float;False;True;2;Float;ASEMaterialInspector;0;0;Unlit;E3DEffect/AirDistort/Noise-Mask;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;Back;2;False;-1;0;False;-1;False;0;False;-1;0;False;-1;False;0;Custom;0.5;True;False;0;True;Transparent;;Overlay;All;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;0;False;-1;False;0;False;-1;255;False;-1;255;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;False;2;15;10;25;False;0.5;False;2;5;False;-1;10;False;-1;0;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;0;0,0,0,0;VertexOffset;True;False;Cylindrical;False;Relative;0;;0;-1;-1;-1;0;False;0;0;False;-1;-1;0;False;-1;0;0;0;False;0.1;False;-1;0;False;-1;15;0;FLOAT3;0,0,0;False;1;FLOAT3;0,0,0;False;2;FLOAT3;0,0,0;False;3;FLOAT;0;False;4;FLOAT;0;False;6;FLOAT3;0,0,0;False;7;FLOAT3;0,0,0;False;8;FLOAT;0;False;9;FLOAT;0;False;10;FLOAT;0;False;13;FLOAT3;0,0,0;False;11;FLOAT3;0,0,0;False;12;FLOAT3;0,0,0;False;14;FLOAT4;0,0,0,0;False;15;FLOAT3;0,0,0;False;0
WireConnection;5;0;4;0
WireConnection;5;1;4;4
WireConnection;5;2;6;4
WireConnection;16;0;5;0
WireConnection;16;1;14;0
WireConnection;15;0;16;0
WireConnection;22;0;15;0
WireConnection;22;1;3;0
WireConnection;17;0;9;1
WireConnection;17;1;9;2
WireConnection;8;0;7;1
WireConnection;8;1;7;2
WireConnection;23;0;22;0
WireConnection;42;0;17;0
WireConnection;42;1;45;0
WireConnection;2;0;8;0
WireConnection;2;1;42;0
WireConnection;2;2;23;0
WireConnection;1;0;2;0
WireConnection;0;2;1;0
WireConnection;0;9;15;0
ASEEND*/
//CHKSM=11C2654E81B0EC757E91C176A6A498D1CA0F063F