Shader "Unlit/ProgressBarWithAlpha"
{
    Properties
    {
        _Fill ("Fill", Range(0, 1)) = 1
        _StartColor ("Start Color", Color) = (1, 0, 0, 1)
        _EndColor ("End Color", Color) = (0, 1, 0, 1)
    }
    SubShader
    {
        Tags { 
            "RenderType"="Transparent"
            "Queue"="Transparent" 
        }
        
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct MeshData
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct Interpolators
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            float _Fill;
            float4 _StartColor;
            float4 _EndColor;

            Interpolators vert (MeshData v)
            {
                Interpolators o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (Interpolators i) : SV_Target
            {
                return (
                        lerp(_StartColor, _EndColor, _Fill)
                      * (_Fill > i.uv.x));
            }
            ENDCG
        }
    }
}
