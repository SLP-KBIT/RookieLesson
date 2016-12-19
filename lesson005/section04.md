# ページを作成する

## 作成するWebアプリの概要

- 記事管理システム
- ユーザと記事を作成
- ユーザは複数の記事を持つ

## モデルの作成

Userモデルの作成

**演習1.** Userモデルにどのような情報が必要か

```
# Rails側に作成
bundle exec rails g model User <column>:<type>
# DBに適用
bundle exec rake db:migrate
```

## ユーザの作成

コンソールから初期データを入力する

```
bundle exec rails console
irb(main):001:0> User.create(<column>:<value>)
```