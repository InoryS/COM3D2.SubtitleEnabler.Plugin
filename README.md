# COM3D2.SubtitleEnabler.Plugin

It is not well known that COM3D2 has multiple language versions, currently including English, Traditional Chinese, Simplified Chinese, and Japanese.
Each version is divided into a public version and an adult version (at least in the code)
KISS uses the [Unity I2 Localization plugin](https://assetstore.unity.com/packages/tools/localization/i2-localization-14884) to provide localization support for the game. Different game versions share some code, but they are not exactly the same.

Most players play the Japanese version because the content is the most complete.

In the English and Chinese versions of the game, there is a subtitle function that can enable subtitles in dances and yotogi.

This plugin tricks the game into thinking that it is running a multi-language version, so that the localization options are turned on.

Some UI/texts have multi-language versions themselves, and the official version will be used at this time. For example, if you choose English, the interface will become English. If you use YAtranslator to replace access to do the translation, you will find that it does not work. This is because you only overwrite the Japanese UI, but not the English UI. These are different files, and sometimes in different locations in a file.

Basically the [I18nEX](https://github.com/ghorsington/COM3D2.i18nEx) plugin works on the same principle, using the official translation options, but adding some non-existent translations to the game, so it can only translate content that is officially marked as translatable.

[YAtranslator](https://github.com/ghorsington/CM3D2.YATranslator) simply overwrites the original resources, so it can translate almost everything.

This plugin is not a translation plugin, it is only created to enable subtitles, it is not a replacement for any translation plugin.

*Dance subtitles require additional files, which require MaidLoader and additional files support

<br>
<br>
<br>
<br>



众所不周知，COM3D2 有多语言版本，目前包括 英文版、正体中文版、简体中文版、日文版。
每个版本又分为公共版本和成人版本（至少在代码中是这样）
KISS 使用 [Unity I2 Localization](https://assetstore.unity.com/packages/tools/localization/i2-localization-14884) 插件来为游戏提供本地化支持，不同的游戏版本共享一些代码，但不完全相同。

大部分玩家玩日语版，因为内容最完整。

在英文和中文版游戏中，有一个字幕功能，可以在舞蹈和yotogi中启用字幕。

本插件欺骗游戏让其认为在运行多语言版本，从而打开本地化选项。

部分 UI/文本 本身有多语言版本，此时会使用官方的版本，例如：如果你选择 English，那么界面会变成英文。如果你使用 YAtranslator 来替换 access 来做翻译，你会发现没有生效，这是因为你只覆盖了日语UI，而没有覆盖英文 UI，这是不同的文件，有时也在一个文件的不同的位置上。

基本上 [I18nEX](https://github.com/ghorsington/COM3D2.i18nEx) 插件也是同样的原理，使用官方提供的翻译选项，但新增一些不存在的翻译到游戏中，因此它只能翻译官方标记为可翻译的内容。

而 [YAtranslator](https://github.com/ghorsington/CM3D2.YATranslator) 只是简单的覆盖原始资源，因此它可以翻译几乎所有内容。


本插件不是一个翻译插件，只是为了启用字幕创建的，它不是任何翻译插件的替代品。




*舞蹈字幕需要额外文件，这需要 MaidLoader 和额外文件支持
