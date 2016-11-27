# Section03

## 概要

- 本セクションでは、継承、オーバーライド、多態性(ポリモーフィズム)について述べる
- ユニットに応じて攻撃力をアップするpowerUp()メソッドを実装する
  - soldierはpowerUp()メソッドを実行することで、攻撃力が2倍にアップする

## アンチパターン

- 新たにWarriorクラスを実装する
  - warriorはpowerUp()メソッドを実行することで、攻撃力が3倍にアップする

- 以下のコマンドを実行する

```sh
$ cd /path/to/lesson002/section03/anti
$ csc.exe game.cs soldier.cs warrior.cs
$ ./game.exe
```

- 以下のような実行結果が得られる

```
---s1---
hp : 100, power : 10
---s2---
hp : 100, power : 10
---s1---
hp : 70, power : 20
---s2---
hp : 80, power : 30
```

- アンチパターンである理由を議論する
  - [game.cs](./anti/game.cs)
  - [soldier.cs](./anti/soldier.cs)
  - [warrior.cs](./anti/warrior.cs)

## 解答例

- 以下のコマンドを実行する
- 実行結果は上記の場合と同じなので割愛する

```sh
$ cd /path/to/lesson002/section03/answer
$ csc.exe game.cs soldier.cs warrior.cs unit.cs
$ ./game.exe
```

- さらなる改良案について議論する
  - [game.cs](./answer/game.cs)
  - [soldier.cs](./answer/soldier.cs)
  - [warrior.cs](./answer/warrior.cs)
  - [unit.cs](./answer/unit.cs)

## 練習問題

- 新たにBerserkerクラスを実装する
  - berserkerはpowerUp()メソッドを実行することで、攻撃力が4倍にアップする

```sh
$ cd /path/to/lesson002/section03/practice
$ csc.exe game.cs soldier.cs warrior.cs berserker.cs unit.cs
$ ./game.exe
```

- 今回は、ユニットのHPと攻撃力を出力するだけとする
- 実行結果は以下の通りである

```
hp : 100, power : 20
hp : 100, power : 30
hp : 100, power : 40
```

- ポリモーフィズムについて議論する
- 解答例は以下の通りである
  - [game.cs](./answer/game.cs)
  - [soldier.cs](./answer/soldier.cs)
  - [warrior.cs](./answer/warrior.cs)
  - [berserker.cs](./answer/berserker.cs)
  - [unit.cs](./answer/unit.cs)

