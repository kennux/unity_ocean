Unity ocean shader
=========

This unity shader "simulates" an ocean based on a displacement map.
It supports displacement map scrolling (tiled), bumpmapping, bumpmap scrolling, specular lightning, tessellation, caustics, cubemap reflection and fresnel color.
It is based on the unity free water shader and the WaterSimple.cs scrolling script.

The shader is still work in progress, there are still some features planned and the code still need some tweaking.

Current features
=========

- Fresnel lens colors
- Caustics
- Specular lightning
- Cubemap reflections
- Tessellation (distance, edge length and static based)
- Displacement mapping (tiled+scrolling)
- Bumpmapping (+scrolling)

Planned features
=========

- Perlin noise
- Own lightning model
- Simple fallback-shader for ex. mobile devices
- Displacement map generator

License
=========
Copyright (c) 2013 Kenneth Ellersdorfer
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.