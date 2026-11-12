# GBS Editor - WinForms Sample

GBS Editorは、C# / .NET 8で開発されたWindows Forms向けのテキストエディタコンポーネントです。

このリポジトリは、GBS Editorを使用したサンプルアプリケーションのソースコードを公開しています。

GBS Editor本体のソースコードは公開していません。

## 主な特徴

- 大容量テキストファイルの閲覧・編集
- UTF-8 / Shift_JIS対応
- 行番号・ルーラー表示
- 右端での折り返し表示
- Undo / Redo
- 通常の選択操作および矩形選択
- Windows Formsアプリケーションへの組み込み

GBS Editorは現在β版です。機能や仕様は今後変更される可能性があります。

## 動作環境

- Windows 10 / 11
- .NET 8（Windows Forms）
- Visual Studio 2022以降

## ビルド方法

1. このリポジトリをCloneまたはZIPでダウンロードします。
2. `GBS.Sample.WinForms.slnx` をVisual Studioで開きます。
3. ソリューションをビルドして実行します。

GBS EditorのDLLは `lib/bin/` に同梱されています。

- `GBS.Core.dll`
- `GBS.Text.dll`
- `GBS.WinForms.dll`

別途DLLを入手する必要はありません。

## サンプルアプリケーション

基本的なテキストエディタとして、次の操作を確認できます。

- 新規作成
- ファイルを開く
- 上書き保存
- 名前を付けて保存
- 未保存の変更確認
- GBS BBSへのアクセス

## 質問・不具合報告

GBS Editorについての質問や不具合報告は、専用BBSで受け付けています。

[GBS Editor BBS](https://academy.hooray-eri.com/gbseditor/bbs/)

BBSは誰でも閲覧できます。投稿する場合は、サンプルアプリケーションの「ヘルプ → 質問を投稿する」からアクセスしてください。

## ライセンス

GBS EditorのDLLは無償で利用できます。商用アプリケーションへの組み込みも可能です。

ただし、GBS Editor本体の著作権は開発者に帰属します。DLLの再配布・改変等については、別途定めるライセンス条件に従ってください。

本ソフトウェアは無保証で提供されます。

Copyright © 2026 進学塾ちかみち
