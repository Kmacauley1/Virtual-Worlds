#version 450 core

layout(binding = 0) uniform sampler2D ColTexture;
layout(binding = 1) uniform sampler2D ColTextureB;

in float Intensity;
in vec2 TexCoord;

float intensity = 0.2;
float intensityB = 0.5;

out vec4 FragColor; // Color that will be used for the fragment
out vec4 FragColorB;

//////////////////////////////////////////////////////////////////
// main()
//////////////////////////////////////////////////////////////////
void main()
{
    vec4 colour = texture(ColTexture, TexCoord.xy); 
    vec4 colourB = texture(ColTextureB, TexCoord.xy);

	FragColor = colour * intensity + colourB * intensityB;

    
}