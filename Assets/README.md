# What?

* プルダウンから SortingLayer を選択可能にする string フィールド向けの Attribute を提供します。

# Why?

* 頻繁に必要とする割には、実装がちょっと面倒だったので共通化しました。

# Install

### With Unity Package Manager

```bash
upm add package dev.upm-packages.sortinglayername-attribute
```

Note: `upm` command is provided by [this repository](https://github.com/upm-packages/upm-cli).

You can also edit `Packages/manifest.json` directly.

```jsonc
{
  "dependencies": {
    // (snip)
    "dev.upm-packages.sortinglayername-attribute": "[latest version]",
    // (snip)
  },
  "scopedRegistries": [
    {
      "name": "Unofficial Unity Package Manager Registry",
      "url": "https://upm-packages.dev",
      "scopes": [
        "dev.upm-packages"
      ]
    }
  ]
}
```

### Any other else (classical umm style)

```shell
$ npm install github:umm/sortinglayername_attribute.git
```

# Usage

```csharp
using UnityEngine;
using UnityModule;

public class Sample : MonoBehaviour {

    [SortingLayerName]
    public string SortingLayerName;

}
```

* string 型の Serializable なフィールドに対して `[SortingLayerName]` 属性をセットするだけです。

# License

Copyright (c) 2017 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)
