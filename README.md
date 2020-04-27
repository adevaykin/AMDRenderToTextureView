# AMDRenderToTextureView
Repro case for AMD bug report https://community.amd.com/message/2909820

## How to use
1. Open solution in Visual Studio (2019)
2. Compile and run
3. Displayed image should show smooth UV coordinates change drawn as color - compare to the attached results

Directory "results" contains screenshots from other GPU vendors renderings and from AMD GPU renderings.

## Bug description

Rendering to a TextureView results in corrupt data in the texture storage. In presented case texture storage with format GL_R32UI is used as a base for the view with format GL_RGBA8. Sampling texture view does not result in the data written to the texture view during rendering to that texture view.

### Expected

Values written to a texture view in particular format can correctly be read from that texture view in the same format independent from the underlying texture storage format as long as the formats are compatible for texture view according to the OpenGL specification.

![Correct Rendering](https://github.com/adevaykin/AMDRenderToTextureView/blob/master/results/correct.PNG)

### Actual

All tested AMD GPUs return unexpected data while sampling a texture view previously used as a framebuffer attachment for rendering.

![Buggy Rendering](https://github.com/adevaykin/AMDRenderToTextureView/blob/master/results/amd.JPG)
