#version 430 core
out vec4 FragColor;

in vec2 TexCoord;

void main()
{
	//FragColor = vec4(sin(pow(TexCoord.x*10.0, 2.0)), sin(pow(TexCoord.y*10.0, 2.0)), 1.0, 1.0);
	FragColor = vec4(TexCoord, 1.0, 1.0);
}