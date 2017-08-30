# What?

* プルダウンから SortingLayer を選択可能にする string フィールド向けの Attribute を提供します。

# Why?

* 頻繁に必要とする割には、実装がちょっと面倒だったので共通化しました。

# Install

```shell
$ npm install @umm/sortinglayername_attribute
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

