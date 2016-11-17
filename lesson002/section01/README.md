# Section01

## 概要

- 本セクションでは、アクセス修飾子、カプセル化について述べる
- hp(ヒットポイント)とpower(攻撃力)を持ったSoldierクラスを題材とする

## アクセス修飾子

- 以下のコマンドを実行する

```sh
$ cd /path/to/lesson002/section01
$ csc.exe game.cs soldier.cs
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

- 使用したプログラムは以下の通りである
  - [game.cs](./game.cs)
  - [soldier.cs](./soldier.cs)

