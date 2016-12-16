# Rubyとは

## Rubyとは

- オープンソースの動的なプログラミング言語
- スクリプト言語(Not コンパイラ言語)
- オブジェクト指向を採用
- Perl、Smalltalk、Eiffel、Ada、Lispの一部をブレンド
- 関数型プログラミングと命令形プログラミングが調和

## Rubyのプログラムの特徴

### スクリプト言語(逐次実行)

```
#### sample.rb
puts "hoge1"
puts "hoge2"
pust "hoge3"

$ ruby sample.rb
hoge1
hoge2
hoge1
hoge2
sample.rb:3:in `<main>': undefined method `pust' for main:Object (NoMethodError)
```

### 動的型付け

```
### C言語
int i;
i = 0 // OK
i = "hoge" // NG

### Ruby
i = 0 # OK
i = "hoge" # OK
```

### 全てがオブジェクト(Not プリミティブ型)

```
1.class
=> Fixnum

"hoge".class
=> String
```

### オープンクラス(柔軟性)

Rubyでは、ユーザーが自由にその一部を変更することが可能

```
class String
  def to_hoge
    "hoge"
  end
end

"foo".to_hoge
=> "hoge"
```

---
次: [Section02](./section02.md): Railsとは
