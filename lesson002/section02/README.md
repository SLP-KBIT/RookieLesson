# Section02

## 概要

- 本セクションでは、カプセル化、アクセス修飾子について述べる

## アンチパターン

- 以下のコマンドを実行する

```sh
$ cd /path/to/lesson002/section02/anti
$ csc.exe game.cs soldier.cs
$ ./game.exe
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
  - [soldier.cs](./anti/soldier.cs)

## 解答案

- 以下のコマンドを実行する
- 実行結果は上記の場合と同じなので割愛する

```sh
$ cd /path/to/lesson002/section02/answer
$ csc.exe game.cs soldier.cs
$ ./game.exe
```

- さらなる改良案について議論する
  - [game.cs](./answer/game.cs)
  - [soldier.cs](./answer/soldier.cs)

## 練習問題

- 以下のコマンドを実行して、自分なりのsoldier.csを実装する
- practice/game.cs以外は、解答案なので出来るだけ見ないこと
- 実行結果は上記の場合と同じなので割愛する

```sh
$ cd /path/to/lesson002/section02/practice
$ cp ../answer/soldier.cs soldier.cs
$ vim soldier.cs
$ csc.exe game.cs soldier.cs
$ ./game.exe
```

- 解答案は以下の通りである
  - [game.cs](./practice/game.cs)
  - [soldier.cs](./practice/soldier.cs)

