// Made with Amplify Shader Editor
// Available at the Unity Asset Store - http://u3d.as/y3X 
Shader "E3DEffect/URP/C3/DDisslove"
{
	Properties
	{
		[HideInInspector] _AlphaCutoff("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor("Emission Color", Color) = (1,1,1,1)
		_UVFlowSpeed("UVFlowSpeed", Vector) = (0,-0.3,0,0)
		_TextureSample0("Texture Sample 0", 2D) = "white" {}
		[HDR]_BaseColor("BaseColor", Color) = (0.3574827,0.5000507,0.8382353,0)
		_UVTiling("UV-Tiling", Range( 0 , 4)) = 0
		_MaskMap("MaskMap", 2D) = "white" {}
		_DissLoveMap("DissLoveMap", 2D) = "white" {}
		[Toggle]_DissAlpha("Diss-Alpha", Float) = 1
		_DissInstensity("Diss-Instensity", Range( 0.01 , 1)) = 0.468391
		_Thickness("Thickness  ", Range( 0 , 0.2)) = 0.3574858
		[HDR]_EdgeColor("EdgeColor", Color) = (0.4411765,0.8843812,1,0)
		_Opacity("Opacity", Range( 0 , 5)) = 2.843909
		[HideInInspector] _texcoord( "", 2D ) = "white" {}

	}

	SubShader
	{
		LOD 0

		
		Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Transparent" "Queue"="Transparent" }
		
		Cull Off
		HLSLINCLUDE
		#pragma target 2.0
		ENDHLSL

		
		Pass
		{
			
			Name "Forward"
			Tags { "LightMode"="UniversalForward" }
			
			Blend SrcAlpha OneMinusSrcAlpha , One OneMinusSrcAlpha
			ZWrite Off
			ZTest LEqual
			Offset 0 , 0
			ColorMask RGBA
			

			HLSLPROGRAM
			#define _RECEIVE_SHADOWS_OFF 1
			#pragma multi_compile_instancing
			#define ASE_SRP_VERSION 70108

			#pragma prefer_hlslcc gles
			#pragma exclude_renderers d3d11_9x

			#pragma vertex vert
			#pragma fragment frag

			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
			#include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Color.hlsl"
			#include "Packages/com.unity.render-pipelines.core/ShaderLibrary/UnityInstancing.hlsl"
			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/ShaderGraphFunctions.hlsl"

			#if ASE_SRP_VERSION <= 70108
			#define REQUIRES_VERTEX_SHADOW_COORD_INTERPOLATOR
			#endif

			

			struct VertexInput
			{
				float4 vertex : POSITION;
				float3 ase_normal : NORMAL;
				float4 ase_texcoord : TEXCOORD0;
				float4 ase_color : COLOR;
				UNITY_VERTEX_INPUT_INSTANCE_ID
			};

			struct VertexOutput
			{
				float4 clipPos : SV_POSITION;
				#if defined(ASE_NEEDS_FRAG_WORLD_POSITION)
				float3 worldPos : TEXCOORD0;
				#endif
				#if defined(REQUIRES_VERTEX_SHADOW_COORD_INTERPOLATOR) && defined(ASE_NEEDS_FRAG_SHADOWCOORDS)
				float4 shadowCoord : TEXCOORD1;
				#endif
				#ifdef ASE_FOG
				float fogFactor : TEXCOORD2;
				#endif
				float4 ase_texcoord3 : TEXCOORD3;
				float4 ase_color : COLOR;
				UNITY_VERTEX_INPUT_INSTANCE_ID
				UNITY_VERTEX_OUTPUT_STEREO
			};

			sampler2D _DissLoveMap;
			sampler2D _MaskMap;
			sampler2D _TextureSample0;
			CBUFFER_START( UnityPerMaterial )
			float _UVTiling;
			float2 _UVFlowSpeed;
			float _Opacity;
			float _DissInstensity;
			float4 _DissLoveMap_ST;
			float4 _TextureSample0_ST;
			float4 _BaseColor;
			float _Thickness;
			float4 _EdgeColor;
			float _DissAlpha;
			CBUFFER_END


			
			VertexOutput vert ( VertexInput v  )
			{
				VertexOutput o = (VertexOutput)0;
				UNITY_SETUP_INSTANCE_ID(v);
				UNITY_TRANSFER_INSTANCE_ID(v, o);
				UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);

				o.ase_texcoord3 = v.ase_texcoord;
				o.ase_color = v.ase_color;
				#ifdef ASE_ABSOLUTE_VERTEX_POS
					float3 defaultVertexValue = v.vertex.xyz;
				#else
					float3 defaultVertexValue = float3(0, 0, 0);
				#endif
				float3 vertexValue = defaultVertexValue;
				#ifdef ASE_ABSOLUTE_VERTEX_POS
					v.vertex.xyz = vertexValue;
				#else
					v.vertex.xyz += vertexValue;
				#endif
				v.ase_normal = v.ase_normal;

				float3 positionWS = TransformObjectToWorld( v.vertex.xyz );
				float4 positionCS = TransformWorldToHClip( positionWS );

				#if defined(ASE_NEEDS_FRAG_WORLD_POSITION)
				o.worldPos = positionWS;
				#endif
				#if defined(REQUIRES_VERTEX_SHADOW_COORD_INTERPOLATOR) && defined(ASE_NEEDS_FRAG_SHADOWCOORDS)
				VertexPositionInputs vertexInput = (VertexPositionInputs)0;
				vertexInput.positionWS = positionWS;
				vertexInput.positionCS = positionCS;
				o.shadowCoord = GetShadowCoord( vertexInput );
				#endif
				#ifdef ASE_FOG
				o.fogFactor = ComputeFogFactor( positionCS.z );
				#endif
				o.clipPos = positionCS;
				return o;
			}

			half4 frag ( VertexOutput IN  ) : SV_Target
			{
				UNITY_SETUP_INSTANCE_ID( IN );
				UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX( IN );

				#if defined(ASE_NEEDS_FRAG_WORLD_POSITION)
				float3 WorldPosition = IN.worldPos;
				#endif
				float4 ShadowCoords = float4( 0, 0, 0, 0 );

				#if defined(ASE_NEEDS_FRAG_SHADOWCOORDS)
					#if defined(REQUIRES_VERTEX_SHADOW_COORD_INTERPOLATOR)
						ShadowCoords = IN.shadowCoord;
					#elif defined(MAIN_LIGHT_CALCULATE_SHADOWS)
						ShadowCoords = TransformWorldToShadowCoord( WorldPosition );
					#endif
				#endif
				float2 temp_cast_0 = (_UVTiling).xx;
				float mulTime5 = _TimeParameters.x * 0.4;
				float2 panner24 = ( mulTime5 * _UVFlowSpeed + float2( 0,0 ));
				float2 uv04 = IN.ase_texcoord3 * temp_cast_0 + panner24;
				float4 tex2DNode46 = tex2D( _DissLoveMap, uv04 );
				float2 temp_cast_1 = (_UVTiling).xx;
				float mulTime28 = _TimeParameters.x * 0.4;
				float2 panner27 = ( mulTime28 * ( _UVFlowSpeed * 3.0 ) + float2( 0,0 ));
				float2 uv025 = IN.ase_texcoord3.xy * temp_cast_1 + panner27;
				float4 temp_output_7_0 = ( tex2DNode46 * tex2D( _MaskMap, uv025 ) * _Opacity );
				float4 uv042 = IN.ase_texcoord3;
				uv042.xy = IN.ase_texcoord3.xy * float2( 1,1 ) + float2( 0,0 );
				float temp_output_22_0 = ( uv042.z + _DissInstensity );
				float4 temp_cast_2 = (temp_output_22_0).xxxx;
				float2 uv_DissLoveMap = IN.ase_texcoord3.xy * _DissLoveMap_ST.xy + _DissLoveMap_ST.zw;
				float2 uv_TextureSample0 = IN.ase_texcoord3.xy * _TextureSample0_ST.xy + _TextureSample0_ST.zw;
				float4 temp_output_45_0 = ( tex2D( _DissLoveMap, uv_DissLoveMap ).r * tex2D( _TextureSample0, uv_TextureSample0 ) );
				float4 temp_output_10_0 = step( temp_cast_2 , temp_output_45_0 );
				float4 temp_cast_3 = (temp_output_22_0).xxxx;
				float4 temp_output_14_0 = step( temp_cast_3 , ( temp_output_45_0 + _Thickness ) );
				float4 temp_cast_4 = (temp_output_22_0).xxxx;
				
				float4 temp_cast_6 = (1.0).xxxx;
				float4 temp_cast_7 = (temp_output_22_0).xxxx;
				float4 clampResult36 = clamp( temp_output_7_0 , float4( 0.2205882,0.2205882,0.2205882,0 ) , float4( 1,1,1,0 ) );
				
				float3 BakedAlbedo = 0;
				float3 BakedEmission = 0;
				float3 Color = ( ( tex2DNode46 * temp_output_7_0 * ( temp_output_10_0 * _BaseColor ) ) + ( ( temp_output_14_0 - temp_output_10_0 ) * _EdgeColor ) ).rgb;
				float Alpha = ( (( _DissAlpha )?( temp_output_14_0 ):( temp_cast_6 )) * IN.ase_color.a * clampResult36 ).r;
				float AlphaClipThreshold = 0.5;

				#ifdef _ALPHATEST_ON
					clip( Alpha - AlphaClipThreshold );
				#endif

				#ifdef ASE_FOG
					Color = MixFog( Color, IN.fogFactor );
				#endif

				#ifdef LOD_FADE_CROSSFADE
					LODDitheringTransition( IN.clipPos.xyz, unity_LODFade.x );
				#endif

				return half4( Color, Alpha );
			}

			ENDHLSL
		}

		
		Pass
		{
			
			Name "DepthOnly"
			Tags { "LightMode"="DepthOnly" }

			ZWrite On
			ColorMask 0

			HLSLPROGRAM
			#define _RECEIVE_SHADOWS_OFF 1
			#pragma multi_compile_instancing
			#define ASE_SRP_VERSION 70108

			#pragma prefer_hlslcc gles
			#pragma exclude_renderers d3d11_9x

			#pragma vertex vert
			#pragma fragment frag

			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/ShaderGraphFunctions.hlsl"
			#include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Color.hlsl"

			

			struct VertexInput
			{
				float4 vertex : POSITION;
				float3 ase_normal : NORMAL;
				float4 ase_texcoord : TEXCOORD0;
				float4 ase_color : COLOR;
				UNITY_VERTEX_INPUT_INSTANCE_ID
			};

			struct VertexOutput
			{
				float4 clipPos : SV_POSITION;
				#if defined(ASE_NEEDS_FRAG_WORLD_POSITION)
				float3 worldPos : TEXCOORD0;
				#endif
				#if defined(REQUIRES_VERTEX_SHADOW_COORD_INTERPOLATOR) && defined(ASE_NEEDS_FRAG_SHADOWCOORDS)
				float4 shadowCoord : TEXCOORD1;
				#endif
				float4 ase_texcoord2 : TEXCOORD2;
				float4 ase_color : COLOR;
				UNITY_VERTEX_INPUT_INSTANCE_ID
				UNITY_VERTEX_OUTPUT_STEREO
			};

			sampler2D _DissLoveMap;
			sampler2D _TextureSample0;
			sampler2D _MaskMap;
			CBUFFER_START( UnityPerMaterial )
			float _UVTiling;
			float2 _UVFlowSpeed;
			float _Opacity;
			float _DissInstensity;
			float4 _DissLoveMap_ST;
			float4 _TextureSample0_ST;
			float4 _BaseColor;
			float _Thickness;
			float4 _EdgeColor;
			float _DissAlpha;
			CBUFFER_END


			
			VertexOutput vert( VertexInput v  )
			{
				VertexOutput o = (VertexOutput)0;
				UNITY_SETUP_INSTANCE_ID(v);
				UNITY_TRANSFER_INSTANCE_ID(v, o);
				UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);

				o.ase_texcoord2 = v.ase_texcoord;
				o.ase_color = v.ase_color;
				#ifdef ASE_ABSOLUTE_VERTEX_POS
					float3 defaultVertexValue = v.vertex.xyz;
				#else
					float3 defaultVertexValue = float3(0, 0, 0);
				#endif
				float3 vertexValue = defaultVertexValue;
				#ifdef ASE_ABSOLUTE_VERTEX_POS
					v.vertex.xyz = vertexValue;
				#else
					v.vertex.xyz += vertexValue;
				#endif

				v.ase_normal = v.ase_normal;

				float3 positionWS = TransformObjectToWorld( v.vertex.xyz );

				#if defined(ASE_NEEDS_FRAG_WORLD_POSITION)
				o.worldPos = positionWS;
				#endif

				o.clipPos = TransformWorldToHClip( positionWS );
				#if defined(REQUIRES_VERTEX_SHADOW_COORD_INTERPOLATOR) && defined(ASE_NEEDS_FRAG_SHADOWCOORDS)
					VertexPositionInputs vertexInput = (VertexPositionInputs)0;
					vertexInput.positionWS = positionWS;
					vertexInput.positionCS = clipPos;
					o.shadowCoord = GetShadowCoord( vertexInput );
				#endif
				return o;
			}

			half4 frag(VertexOutput IN  ) : SV_TARGET
			{
				UNITY_SETUP_INSTANCE_ID(IN);
				UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX( IN );

				#if defined(ASE_NEEDS_FRAG_WORLD_POSITION)
				float3 WorldPosition = IN.worldPos;
				#endif
				float4 ShadowCoords = float4( 0, 0, 0, 0 );

				#if defined(ASE_NEEDS_FRAG_SHADOWCOORDS)
					#if defined(REQUIRES_VERTEX_SHADOW_COORD_INTERPOLATOR)
						ShadowCoords = IN.shadowCoord;
					#elif defined(MAIN_LIGHT_CALCULATE_SHADOWS)
						ShadowCoords = TransformWorldToShadowCoord( WorldPosition );
					#endif
				#endif

				float4 temp_cast_0 = (1.0).xxxx;
				float4 uv042 = IN.ase_texcoord2;
				uv042.xy = IN.ase_texcoord2.xy * float2( 1,1 ) + float2( 0,0 );
				float temp_output_22_0 = ( uv042.z + _DissInstensity );
				float4 temp_cast_1 = (temp_output_22_0).xxxx;
				float2 uv_DissLoveMap = IN.ase_texcoord2.xy * _DissLoveMap_ST.xy + _DissLoveMap_ST.zw;
				float2 uv_TextureSample0 = IN.ase_texcoord2.xy * _TextureSample0_ST.xy + _TextureSample0_ST.zw;
				float4 temp_output_45_0 = ( tex2D( _DissLoveMap, uv_DissLoveMap ).r * tex2D( _TextureSample0, uv_TextureSample0 ) );
				float4 temp_output_14_0 = step( temp_cast_1 , ( temp_output_45_0 + _Thickness ) );
				float2 temp_cast_2 = (_UVTiling).xx;
				float mulTime5 = _TimeParameters.x * 0.4;
				float2 panner24 = ( mulTime5 * _UVFlowSpeed + float2( 0,0 ));
				float2 uv04 = IN.ase_texcoord2.xy * temp_cast_2 + panner24;
				float4 tex2DNode46 = tex2D( _DissLoveMap, uv04 );
				float2 temp_cast_3 = (_UVTiling).xx;
				float mulTime28 = _TimeParameters.x * 0.4;
				float2 panner27 = ( mulTime28 * ( _UVFlowSpeed * 3.0 ) + float2( 0,0 ));
				float2 uv025 = IN.ase_texcoord2.xy * temp_cast_3 + panner27;
				float4 temp_output_7_0 = ( tex2DNode46 * tex2D( _MaskMap, uv025 ) * _Opacity );
				float4 clampResult36 = clamp( temp_output_7_0 , float4( 0.2205882,0.2205882,0.2205882,0 ) , float4( 1,1,1,0 ) );
				
				float Alpha = ( (( _DissAlpha )?( temp_output_14_0 ):( temp_cast_0 )) * IN.ase_color.a * clampResult36 ).r;
				float AlphaClipThreshold = 0.5;

				#ifdef _ALPHATEST_ON
					clip(Alpha - AlphaClipThreshold);
				#endif

				#ifdef LOD_FADE_CROSSFADE
					LODDitheringTransition( IN.clipPos.xyz, unity_LODFade.x );
				#endif
				return 0;
			}
			ENDHLSL
		}

	
	}
	CustomEditor "ASEMaterialInspector"
	Fallback "Hidden/InternalErrorShader"
	
}
/*ASEBEGIN
Version=18000
1961;41;1879;993;2015.769;84.39689;1.818797;True;False
Node;AmplifyShaderEditor.Vector2Node;1;-1673.945,132.8393;Float;False;Property;_UVFlowSpeed;UVFlowSpeed;0;0;Create;True;0;0;False;0;0,-0.3;0,0;0;3;FLOAT2;0;FLOAT;1;FLOAT;2
Node;AmplifyShaderEditor.RangedFloatNode;40;-1661.327,407.9665;Float;False;Constant;_Float1;Float 1;10;0;Create;True;0;0;False;0;3;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleTimeNode;28;-1265.743,568.1488;Inherit;False;1;0;FLOAT;0.4;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;38;-1415.327,321.9665;Inherit;False;2;2;0;FLOAT2;0,0;False;1;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleTimeNode;5;-1249.454,237.6467;Inherit;False;1;0;FLOAT;0.4;False;1;FLOAT;0
Node;AmplifyShaderEditor.SamplerNode;9;-1382.393,1057.125;Inherit;True;Property;_DissLoveMap;DissLoveMap;4;0;Create;True;0;0;False;0;-1;723d609500fd514409fabd10ed79ed0e;ef7d9f8f093e28f46b80f3b211446a92;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.PannerNode;24;-1036.408,119.023;Inherit;False;3;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SamplerNode;44;-1365.702,1318.045;Inherit;True;Property;_TextureSample0;Texture Sample 0;0;0;Create;True;0;0;False;0;-1;None;2cdf2c2462f64d447a8d1848b97a1b6c;True;0;False;white;Auto;False;Instance;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.PannerNode;27;-1037.978,447.8551;Inherit;False;3;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;34;-1250.035,307.3705;Float;False;Property;_UVTiling;UV-Tiling;2;0;Create;True;0;0;False;0;0;0;0;4;0;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;13;-1315.565,1557.645;Float;False;Property;_Thickness;Thickness  ;7;0;Create;True;0;0;False;0;0.3574858;0.2;0;0.2;0;1;FLOAT;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;42;-1088.891,719.6761;Inherit;False;0;-1;4;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;23;-1129.716,936.9177;Float;False;Property;_DissInstensity;Diss-Instensity;6;0;Create;True;0;0;False;0;0.468391;0.255;0.01;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;25;-820.139,403.2906;Inherit;False;0;-1;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.TextureCoordinatesNode;4;-812.6773,120.0522;Inherit;False;0;-1;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;45;-1003.414,1210.287;Inherit;False;2;2;0;FLOAT;0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.SamplerNode;8;-523.5349,377.0211;Inherit;True;Property;_MaskMap;MaskMap;3;0;Create;True;0;0;False;0;-1;None;e5e4f8d6f0dfeca45a8fcc8174dfa252;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleAddOpNode;12;-733.0718,1295.409;Inherit;True;2;2;0;COLOR;0,0,0,0;False;1;FLOAT;0;False;1;COLOR;0
Node;AmplifyShaderEditor.SimpleAddOpNode;22;-755.3536,813.8474;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SamplerNode;46;-485.8701,80.21361;Inherit;True;Property;_TextureSample1;Texture Sample 1;4;0;Create;True;0;0;False;0;-1;723d609500fd514409fabd10ed79ed0e;723d609500fd514409fabd10ed79ed0e;True;0;False;white;Auto;False;Instance;9;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;35;-485.4724,601.6407;Float;False;Property;_Opacity;Opacity;9;0;Create;True;0;0;False;0;2.843909;5;0;5;0;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;30;201.3798,1439.482;Float;False;Constant;_Float0;Float 0;8;0;Create;True;0;0;False;0;1;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;7;33.68195,441.3041;Inherit;True;3;3;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;2;FLOAT;0;False;1;COLOR;0
Node;AmplifyShaderEditor.StepOpNode;14;-447.7909,1119.049;Inherit;True;2;0;FLOAT;0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.VertexColorNode;33;524.2264,999.8;Inherit;False;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.ToggleSwitchNode;29;524.4994,1212.31;Float;True;Property;_DissAlpha;Diss-Alpha;5;0;Create;True;0;0;False;0;1;2;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.ClampOpNode;36;531.7144,743.4788;Inherit;False;3;0;COLOR;0,0,0,0;False;1;COLOR;0.2205882,0.2205882,0.2205882,0;False;2;COLOR;1,1,1,0;False;1;COLOR;0
Node;AmplifyShaderEditor.ColorNode;19;-154.4691,918.8425;Float;False;Property;_BaseColor;BaseColor;1;1;[HDR];Create;True;0;0;False;0;0.3574827,0.5000507,0.8382353,0;0.1172414,0,1,1;False;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;20;161.9189,839.0635;Inherit;True;2;2;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;16;-171.7437,1084.554;Inherit;True;2;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;18;191.4832,1151.166;Inherit;True;2;2;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.ColorNode;17;-162.6417,1341.432;Float;False;Property;_EdgeColor;EdgeColor;8;1;[HDR];Create;True;0;0;False;0;0.4411765,0.8843812,1,0;0,1.180572,3.981,1;False;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.Vector2Node;26;-1267.978,443.8551;Float;False;Constant;_Vector1;Vector 1;0;0;Create;True;0;0;False;0;0,-0.9;0,0;0;3;FLOAT2;0;FLOAT;1;FLOAT;2
Node;AmplifyShaderEditor.SimpleAddOpNode;21;895.4907,778.7656;Inherit;True;2;2;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;6;555.6655,400.0595;Inherit;True;3;3;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;2;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.StepOpNode;10;-462.3815,846.6862;Inherit;True;2;0;FLOAT;0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;32;894.7187,1036.953;Inherit;True;3;3;0;COLOR;0,0,0,0;False;1;FLOAT;0;False;2;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.TemplateMultiPassMasterNode;47;1211.563,734.7306;Float;False;False;-1;2;UnityEditor.ShaderGraph.PBRMasterGUI;0;1;New Amplify Shader;2992e84f91cbeb14eab234972e07ea9d;True;ExtraPrePass;0;0;ExtraPrePass;5;False;False;False;True;0;False;-1;False;False;False;False;False;True;3;RenderPipeline=UniversalPipeline;RenderType=Opaque=RenderType;Queue=Geometry=Queue=0;True;0;0;True;1;1;False;-1;0;False;-1;0;1;False;-1;0;False;-1;False;False;True;0;False;-1;True;True;True;True;True;0;False;-1;True;False;255;False;-1;255;False;-1;255;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;True;1;False;-1;True;3;False;-1;True;True;0;False;-1;0;False;-1;True;0;False;0;Hidden/InternalErrorShader;0;0;Standard;0;0
Node;AmplifyShaderEditor.TemplateMultiPassMasterNode;49;1211.563,734.7306;Float;False;False;-1;2;UnityEditor.ShaderGraph.PBRMasterGUI;0;1;New Amplify Shader;2992e84f91cbeb14eab234972e07ea9d;True;ShadowCaster;0;2;ShadowCaster;0;False;False;False;True;0;False;-1;False;False;False;False;False;True;3;RenderPipeline=UniversalPipeline;RenderType=Opaque=RenderType;Queue=Geometry=Queue=0;True;0;0;False;False;False;False;False;False;True;1;False;-1;True;3;False;-1;False;True;1;LightMode=ShadowCaster;False;0;Hidden/InternalErrorShader;0;0;Standard;0;0
Node;AmplifyShaderEditor.TemplateMultiPassMasterNode;50;1211.563,734.7306;Float;False;False;-1;2;UnityEditor.ShaderGraph.PBRMasterGUI;0;1;New Amplify Shader;2992e84f91cbeb14eab234972e07ea9d;True;DepthOnly;0;3;DepthOnly;0;False;False;False;True;0;False;-1;False;False;False;False;False;True;3;RenderPipeline=UniversalPipeline;RenderType=Opaque=RenderType;Queue=Geometry=Queue=0;True;0;0;False;False;False;False;True;False;False;False;False;0;False;-1;False;True;1;False;-1;False;False;True;1;LightMode=DepthOnly;False;0;Hidden/InternalErrorShader;0;0;Standard;0;0
Node;AmplifyShaderEditor.TemplateMultiPassMasterNode;51;1211.563,734.7306;Float;False;False;-1;2;UnityEditor.ShaderGraph.PBRMasterGUI;0;1;New Amplify Shader;2992e84f91cbeb14eab234972e07ea9d;True;Meta;0;4;Meta;0;False;False;False;True;0;False;-1;False;False;False;False;False;True;3;RenderPipeline=UniversalPipeline;RenderType=Opaque=RenderType;Queue=Geometry=Queue=0;True;0;0;False;False;False;True;2;False;-1;False;False;False;False;False;True;1;LightMode=Meta;False;0;Hidden/InternalErrorShader;0;0;Standard;0;0
Node;AmplifyShaderEditor.TemplateMultiPassMasterNode;48;1218.563,838.7306;Float;False;True;-1;2;ASEMaterialInspector;0;3;E3DEffect/URP/C3/DDisslove;2992e84f91cbeb14eab234972e07ea9d;True;Forward;0;1;Forward;7;False;False;False;True;2;False;-1;False;False;False;False;False;True;3;RenderPipeline=UniversalPipeline;RenderType=Transparent=RenderType;Queue=Transparent=Queue=0;True;0;0;True;1;5;False;-1;10;False;-1;1;1;False;-1;10;False;-1;False;False;False;True;True;True;True;True;0;False;-1;True;False;255;False;-1;255;False;-1;255;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;True;2;False;-1;True;3;False;-1;True;True;0;False;-1;0;False;-1;True;1;LightMode=UniversalForward;False;0;Hidden/InternalErrorShader;0;0;Standard;11;Surface;1;  Blend;0;Two Sided;0;Cast Shadows;0;Receive Shadows;0;GPU Instancing;1;LOD CrossFade;0;Built-in Fog;0;Meta Pass;0;Extra Pre Pass;0;Vertex Position,InvertActionOnDeselection;1;0;5;False;True;False;True;False;False;;0
WireConnection;38;0;1;0
WireConnection;38;1;40;0
WireConnection;24;2;1;0
WireConnection;24;1;5;0
WireConnection;27;2;38;0
WireConnection;27;1;28;0
WireConnection;25;0;34;0
WireConnection;25;1;27;0
WireConnection;4;0;34;0
WireConnection;4;1;24;0
WireConnection;45;0;9;1
WireConnection;45;1;44;0
WireConnection;8;1;25;0
WireConnection;12;0;45;0
WireConnection;12;1;13;0
WireConnection;22;0;42;3
WireConnection;22;1;23;0
WireConnection;46;1;4;0
WireConnection;7;0;46;0
WireConnection;7;1;8;0
WireConnection;7;2;35;0
WireConnection;14;0;22;0
WireConnection;14;1;12;0
WireConnection;29;0;30;0
WireConnection;29;1;14;0
WireConnection;36;0;7;0
WireConnection;20;0;10;0
WireConnection;20;1;19;0
WireConnection;16;0;14;0
WireConnection;16;1;10;0
WireConnection;18;0;16;0
WireConnection;18;1;17;0
WireConnection;21;0;6;0
WireConnection;21;1;18;0
WireConnection;6;0;46;0
WireConnection;6;1;7;0
WireConnection;6;2;20;0
WireConnection;10;0;22;0
WireConnection;10;1;45;0
WireConnection;32;0;29;0
WireConnection;32;1;33;4
WireConnection;32;2;36;0
WireConnection;48;2;21;0
WireConnection;48;3;32;0
ASEEND*/
//CHKSM=3A8543CA27F26CE0366917226A730D2E95064FAA