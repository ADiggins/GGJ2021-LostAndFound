// Upgrade NOTE: upgraded instancing buffer 'DiffuseDoubleSided' to new syntax.

// Made with Amplify Shader Editor
// Available at the Unity Asset Store - http://u3d.as/y3X 
Shader "Diffuse, DoubleSided"
{
	Properties
	{
		_Texture("Texture", 2D) = "white" {}
		_AO("AO", 2D) = "white" {}
		_NormalMap("NormalMap", 2D) = "white" {}
		_HowSmoovedoyouwantitD("How Smoove do you want it? :D", Range( 0 , 5)) = 0
		[HideInInspector] _texcoord( "", 2D ) = "white" {}
		[HideInInspector] __dirty( "", Int ) = 1
	}

	SubShader
	{
		Tags{ "RenderType" = "Opaque"  "Queue" = "Geometry+0" }
		Cull Off
		CGPROGRAM
		#pragma target 3.0
		#pragma multi_compile_instancing
		#pragma surface surf Standard keepalpha addshadow fullforwardshadows 
		struct Input
		{
			float2 uv_texcoord;
		};

		uniform sampler2D _NormalMap;
		uniform sampler2D _Texture;
		uniform sampler2D _AO;

		UNITY_INSTANCING_BUFFER_START(DiffuseDoubleSided)
			UNITY_DEFINE_INSTANCED_PROP(float4, _NormalMap_ST)
#define _NormalMap_ST_arr DiffuseDoubleSided
			UNITY_DEFINE_INSTANCED_PROP(float4, _Texture_ST)
#define _Texture_ST_arr DiffuseDoubleSided
			UNITY_DEFINE_INSTANCED_PROP(float4, _AO_ST)
#define _AO_ST_arr DiffuseDoubleSided
			UNITY_DEFINE_INSTANCED_PROP(float, _HowSmoovedoyouwantitD)
#define _HowSmoovedoyouwantitD_arr DiffuseDoubleSided
		UNITY_INSTANCING_BUFFER_END(DiffuseDoubleSided)

		void surf( Input i , inout SurfaceOutputStandard o )
		{
			float4 _NormalMap_ST_Instance = UNITY_ACCESS_INSTANCED_PROP(_NormalMap_ST_arr, _NormalMap_ST);
			float2 uv_NormalMap = i.uv_texcoord * _NormalMap_ST_Instance.xy + _NormalMap_ST_Instance.zw;
			o.Normal = tex2D( _NormalMap, uv_NormalMap ).rgb;
			float4 _Texture_ST_Instance = UNITY_ACCESS_INSTANCED_PROP(_Texture_ST_arr, _Texture_ST);
			float2 uv_Texture = i.uv_texcoord * _Texture_ST_Instance.xy + _Texture_ST_Instance.zw;
			o.Albedo = tex2D( _Texture, uv_Texture ).rgb;
			float _HowSmoovedoyouwantitD_Instance = UNITY_ACCESS_INSTANCED_PROP(_HowSmoovedoyouwantitD_arr, _HowSmoovedoyouwantitD);
			o.Smoothness = _HowSmoovedoyouwantitD_Instance;
			float4 _AO_ST_Instance = UNITY_ACCESS_INSTANCED_PROP(_AO_ST_arr, _AO_ST);
			float2 uv_AO = i.uv_texcoord * _AO_ST_Instance.xy + _AO_ST_Instance.zw;
			o.Occlusion = tex2D( _AO, uv_AO ).r;
			o.Alpha = 1;
		}

		ENDCG
	}
	Fallback "Diffuse"
	CustomEditor "ASEMaterialInspector"
}
/*ASEBEGIN
Version=18000
0;21;1796;588;1279.511;113.9396;1;True;True
Node;AmplifyShaderEditor.SamplerNode;2;-738.5733,-51.79855;Inherit;True;Property;_NormalMap;NormalMap;4;0;Create;True;0;0;False;0;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SamplerNode;3;-744.1038,145.8184;Inherit;True;Property;_Matallic;Matallic;1;0;Create;True;0;0;False;0;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SamplerNode;5;-758.6254,573.7698;Inherit;True;Property;_AO;AO;2;0;Create;True;0;0;False;0;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SamplerNode;1;-730.7712,-249.2892;Inherit;True;Property;_Texture;Texture;0;0;Create;True;0;0;False;0;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SamplerNode;4;-753.9991,356.9232;Inherit;True;Property;_Emission;Emission;3;0;Create;True;0;0;False;0;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;10;-437.8515,129.0915;Inherit;True;InstancedProperty;_HowSmoovedoyouwantitD;How Smoove do you want it? :D;5;0;Create;True;0;0;False;0;0;0;0;5;0;1;FLOAT;0
Node;AmplifyShaderEditor.StandardSurfaceOutputNode;0;0,0;Float;False;True;-1;2;ASEMaterialInspector;0;0;Standard;Diffuse, DoubleSided;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;Off;0;False;-1;0;False;-1;False;0;False;-1;0;False;-1;False;0;Opaque;0.5;True;True;0;False;Opaque;;Geometry;All;14;all;True;True;True;True;0;False;-1;False;0;False;-1;255;False;-1;255;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;False;2;15;10;25;False;0.5;True;0;0;False;-1;0;False;-1;0;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;0;0,0,0,0;VertexOffset;True;False;Cylindrical;False;Relative;0;;-1;-1;-1;-1;0;False;0;0;False;-1;-1;0;False;-1;0;0;0;False;0.1;False;-1;0;False;-1;16;0;FLOAT3;0,0,0;False;1;FLOAT3;0,0,0;False;2;FLOAT3;0,0,0;False;3;FLOAT;0;False;4;FLOAT;0;False;5;FLOAT;0;False;6;FLOAT3;0,0,0;False;7;FLOAT3;0,0,0;False;8;FLOAT;0;False;9;FLOAT;0;False;10;FLOAT;0;False;13;FLOAT3;0,0,0;False;11;FLOAT3;0,0,0;False;12;FLOAT3;0,0,0;False;14;FLOAT4;0,0,0,0;False;15;FLOAT3;0,0,0;False;0
WireConnection;0;0;1;0
WireConnection;0;1;2;0
WireConnection;0;4;10;0
WireConnection;0;5;5;0
ASEEND*/
//CHKSM=67DC53BE8C95696AEAEDB8A6724239D85872B39B