# Railsとは

## Railsとは

- Ruby製のWebアプリケーションフレームワーク
- MVCアーキテクチャに基づいて構築
- 強力なORM ActiveRecordを組込んでいる

## フレームワークとは

```
プログラミングにおいて、一般的な機能をもつ共通コードをユーザーが選択的に上書きしたり特化させたりすることで、ある特定の機能をもたせようとする抽象概念のことである。（Wikipediaより）
```

- 大きなライブラリ

## MVCアーキテクチャ

プログラムをModel、View、Controllerに分割する

- Model      : アプリケーションデータ、ビジネスルール、ロジック、関数
- View       : グラフや図などの任意の情報表現
- Controller : 入力を受け取りModelとViewへの命令に変換する

## ORM(ORマッパー)

「オブジェクト」と「リレーショナル・データベース」を対応付けするもの。
実装時のデータベース操作にかかわる煩雑な作業を軽減してくれる。

```
# SQL

INSERT INTO table VALUES (1, 'hoge', ...)

# ORM(AR)

Table.new(1, 'hoge')
```

---
次: [Section03](./section03.md): Railsプロジェクトを作る
