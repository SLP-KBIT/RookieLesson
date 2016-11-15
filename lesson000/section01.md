Lesson000#section01 : ディレクトリ構造
---

基本的に，各レッスンは次のようなディレクトリ構造にならう．

```
lesson000/
  ├── README.md
  ├── section01.md
  ├── section02.md
  └── section03.md
  └── programs
        └── sample.js
  └── elements
        └── example.png
```

- lessonのディレクトリ名は，`lesson` + 0埋め３桁 の lesson番号とする
- lessonは，ひとつの`README.md` を持っている．
- README.md は 各セクションの目次が記述されている必要がある．
- lessonは，いくつかのsectionを持っている．
- sectionのファイル名は，`section` + 0埋め2ケタ の section番号とし，拡張子は `md` とする．
- elements には，図やパワーポイントなどの関連資料を入れる．
- code には，サンプルコードや，CTFの問題などを入れる．

---

次のセクション，[secion02 : 問題作成時のブランチの切り方](./section02.md) へと進む
