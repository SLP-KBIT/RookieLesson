Lesson000#section01 : ディレクトリ構造
---

基本的に，各レッスンは次のようなディレクトリ構造になるようにならう．

```
lesson000/
  ├── README.md
  ├── section01.md
  ├── section02.md
  └── section03.md
  └── elements
        └── example.png
```

- lessonのディレクトリ名は，`lesson` + 0埋め３桁 の lesson番号とする
- lessonは，ひとつの`README.md`持っている．
- README.md は 各セクションの目次が事柄が記述されていつ必要がある．
- lessonは，いくつかのsectionを持っている．
- sectionのファイル名は，`section` + 0埋め2ケタ の section番号とし，拡張子は `md` とする．
- elements には，図やパワーポイントなどの関連資料を入れる．

---

次のセクション，[secion02 : 問題作成時のブランチの切り方](./section02.md) へと進む