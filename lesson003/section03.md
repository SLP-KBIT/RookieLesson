Section03 : DOMの内容を変更してみよう
---

### DOMの内容を変更する

- 例題2: github上の適当なDOMを取得し，内容を変更する

  ![Modify DOM Text](./elements/3_1_modify-dom-text.gif)

#### :paperclip: elements.innerText : `String`

DOMが持っている子要素の文字列を取得，変更できる．

#### :paperclip: elements.innerHTML : `String`

element の全ての子を削除し、content の文字列を解析し得られたノードを
element の子として割り当てます。

##### :x: セキュリティ上の注意事項

ウェブページにテキストを挿入するのに innerHTML を使うことは珍しくありません。
しかし，これにはセキュリティ上のリスクがあります。

```
var name = "<img src=x onerror=alert(1)>";
el.innerHTML = name; // 警告が出ます
```

## 演習問題２

[github/SLP-KBIT/RookieLesson](https://github.com/SLP-KBIT/RookieLesson)から，

- リポジトリ名を変更せよ
- スターの数を変更せよ

---
次のセクション，[section04 : DOMのスタイルを変更してみよう](./section04.md) へと進む
