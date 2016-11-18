# Section01

## 概要

- 本セクションでは、クラスによる分割について述べる
- hp(ヒットポイント)とpower(攻撃力)を持ったSoldierクラスを題材とする

## アンチパターンの紹介

- 以下のコマンドを実行する

```sh
$ cd /path/to/lesson002/section01/anti
$ csc.exe game.cs
$ game.exe
```

- 以下のような実行結果が得られる

```
---s1---
hp : 100, power : 30
---s2---
hp : 200, power : 10
---s1---
hp : 90, power : 30
---s2---
hp : 170, power : 10
```

- アンチパターンである理由を議論する
  - [game.cs](./anti/game.cs)

## 解答例の紹介

- 以下のコマンドを実行する
- 実行結果は上記と同じものなので割愛する

```sh
$ cd /path/to/lesson002/section01/answer
$ csc.exe game.cs soldier.cs
$ game.exe
```

- さらなる改良案を議論する
  - [game.cs](./answer/game.cs)
  - [soldier.cs](./answer/soldier.cs)

